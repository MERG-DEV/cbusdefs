#!/bin/bash
#set -x

OUTPUT=cbusdefs.cs
echo "Generating $OUTPUT"
# first output the header stuff
cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from cbusdefs.csv
 */ 

namespace merg.cbus
{

EOF

# output the comments
grep '^comment' cbusdefs.csv | cut -f2- -d , | sed 's!^!    // !' |sed 's!,!!' | sed 's!,!!' >> $OUTPUT

cat << EOF >> $OUTPUT

	public static class CbusDefs
	{
EOF

# Each type is a static nested class.
for class in $(cat cbusdefs.csv|cut -f1 -d ,|grep -v comment|sort|uniq)
do
	echo "           CbusDefs.$class"

	cat << EOF >> $OUTPUT
		public static class $class
		{
EOF

	# now output the actual contents
	while IFS="," read type	name value comment 
	do
		if [ $type = $class ]; then
			if [ "X$name" = "X" ]; then
				echo -e "\t\t\t// $value$comment" 
			else
				echo -e "\t\t\tpublic const int $name\t=  $value;\t// $comment" 
			fi
		fi
	done < cbusdefs.csv >> $OUTPUT

	cat << EOF >> $OUTPUT
		}

EOF
done

# finally output the trailer stuff
cat << EOF >> $OUTPUT
	}
}
EOF
