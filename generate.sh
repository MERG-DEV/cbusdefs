#!/bin/bash
#set -x

# Although this may seem like a random collection of punctuation it is 
# actually a bash script. I.e. it is executed by the bash command. 
#
# Git Bash may be downloaded as part of the Git tools from 
# https://git-scm.com/downloads
#
# This script produces language specific variants of cbusdefs.csv

############################
# cbusdefs.inc
############################
OUTPUT=cbusdefs.inc
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
; DO NOT EDIT THIS FILE.
; This file is automatically generated by $0 from cbusdefs.csv

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ $type = "comment" ]; then
		echo -e "; $name\t$value\t$comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "; $value$comment" 
		else
			start=`echo -e $value | cut -c1-2 | tr "x" "X"`
			if [ "x$start" = "x0X" ]; then
				echo -e "$name\tequ $value\t; $comment" 
			else
				echo -e "$name\tequ .$value\t; $comment" 
			fi
		fi
	fi
done < cbusdefs.csv >>$OUTPUT
	
# finally output the trailer stuff
# none needed


############################
# cbusdefs.h
############################
OUTPUT=cbusdefs.h
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from cbusdefs.csv
 */
#ifndef __CBUSDEFS
#define __CBUSDEFS

#ifdef	__cplusplus
extern "C" {
#endif

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ $type = "comment" ]; then
		echo -e "// $name\t$value\t$comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "// $value$comment" 
		else
			echo -e "#define $name\t$value\t// $comment" 
		fi
	fi
done < cbusdefs.csv >>$OUTPUT
	
# finally output the trailer stuff
cat << EOF >> $OUTPUT

#ifdef	__cplusplus
}
#endif

#endif // __CBUSDEFS

EOF


############################
# cbusdefs.pas
############################
OUTPUT=cbusdefs.pas
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
{ DO NOT EDIT THIS FILE.
  This file is automatically generated by $0 from cbusdefs.csv
} 
unit cbusdefs;

interface

const

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ $type = "comment" ]; then
		echo -e "{ $name\t$value\t$comment }" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "// $value$comment" 
		else
			echo -e " $name\t=  $value;\t// $comment" 
		fi
	fi
done < cbusdefs.csv >>$OUTPUT
	
# finally output the trailer stuff
cat << EOF >> $OUTPUT

implementation

end.
EOF

############################
#  Java files
############################
PACKAGE=uk.org.merg.cbus
JAVAPATH=`echo java/$PACKAGE|tr '.' '/'`
mkdir -p $JAVAPATH
# get the list of classes
for class in $(cat cbusdefs.csv|cut -f1 -d ,|grep -v comment|sort|uniq)
do
	OUTPUT="$JAVAPATH/$class.java"
	echo "Generating $OUTPUT"
	# output the fixed part
	cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from cbusdefs.csv
 */ 

package $PACKAGE;

EOF
	# output the comments
	grep '^comment' cbusdefs.csv | cut -f2- -d , | sed 's!^!// !' |sed 's!,!!' | sed 's!,!!' >> $OUTPUT
	# output heading
	cat << EOF >> $OUTPUT

public enum $class {
EOF
	# capture the name and values into a variable
	BODY=`while IFS="," read type	name value comment 
	do
		if [ $type = "$class" ]; then
			if [ "X$name" = "X" ]; then
				echo -e "// $value$comment" 
			else
				echo -e "\t$name($value),\t//$comment" 
			fi
		fi
	done < cbusdefs.csv`
	# change the ',' at the end of the last entry to ';'
	#echo "$BODY" | sed 's!\(.*\)),!\1);!' >>$OUTPUT
	# find the line to change
	CHANGE_LINE=`echo "$BODY" | grep -n '),' | tail -1 |cut -f1 -d ':'`
	# output the lines prior to that
	echo "$BODY"|head -n `expr $CHANGE_LINE - 1` >>$OUTPUT
	# output the remainder with the change
	echo "$BODY"|tail -n +$CHANGE_LINE | sed 's!),!);!' >> $OUTPUT


	# output trailer
	cat << EOF >> $OUTPUT

	private final int v;

	private $class(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
EOF
done

############################
# cbusdefs.cs
############################
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
grep '^comment' cbusdefs.csv | cut -f2- -d , | sed 's!^!\t// !' |sed 's!,!!' | sed 's!,!!' >> $OUTPUT

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

############################
# cbusdefsenums.cs
############################
OUTPUT=cbusdefsenums.cs
echo "Generating $OUTPUT"
# first output the header stuff
cat << EOF > $OUTPUT
/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by $0 from cbusdefs.csv
 */ 

namespace Merg.Cbus
{

EOF

# output the comments
grep '^comment' cbusdefs.csv | cut -f2- -d , | sed 's!^!\t// !' |sed 's!,!!' | sed 's!,!!' >> $OUTPUT

cat << EOF >> $OUTPUT

EOF

for class in $(cat cbusdefs.csv|cut -f1 -d ,|grep -v comment|sort|uniq)
do
	echo "           CbusDefs.$class"

	cat << EOF >> $OUTPUT
	/// <summary>
EOF

	while IFS="," read type	name value comment 
	do
		if [ $type = $class ]; then
			if [ "X$name" = "X" ]; then
				if [ "X$comment" != "X" ]; then
					echo -e "\t/// $value$comment" 
					break
				fi
			fi
		fi
	done < cbusdefs.csv >> $OUTPUT

	enum="$(sed -e 's/Cbus//' <<< $class)"

	cat << EOF >> $OUTPUT
	/// </summary>
	public enum $enum
	{
EOF

	# now output the actual contents
	while IFS="," read type	name value comment 
	do
		if [ $type = $class ]; then
			if [ "X$name" = "X" ]; then
				if [ "X$comment" != "X" ]; then
					echo -e "\t\t// $value$comment" 
				else
					echo -e "\t"
				fi
			else

				#rewrite $name to match C# standards and remove redundancy
				if [[ $name == *"_"* ]]; then
					IFS="_" read -ra typename <<< $name

					name="$(sed -e 's/^SASP_//' -e 's/^CMDERR_//' -e 's/^PAR_//' -e 's/^ERR_//' -e 's/^MANU_//' -e 's/^MTYP_//' -e 's/^OPC_//' -e 's/^PF_//' -e 's/^PAR_//' -e 's/^CPUM_//' -e 's/^SSTAT_//' -e 's/^TMOD_//' <<< $name)"
					

					name="$(sed -e 's/\(.\)\([^_]*\)_\{0,1\}/\U\1\L\2/g' <<< $name)"
				fi
				if [ "X$comment" != "X" ]; then
					echo -e "\t\t/// <summary>$comment</summary>"
				fi
				echo -e "\t\t$name = $value," 
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
EOF

############################
# cbusdefs.py
############################
OUTPUT=cbusdefs.py
echo "Generating $OUTPUT"
# first out put the header stuff
cat << EOF > $OUTPUT
# DO NOT EDIT THIS FILE.
# This file is automatically generated by $0 from cbusdefs.csv
#

from micropython import const

EOF
# now output the actual contents
while IFS="," read type	name value comment 
do
	if [ $type = "comment" ]; then
		echo -e "# $name    $value    $comment" 
	else
		if [ "X$name" = "X" ]; then
			echo -e "# $value$comment" 
		else
			echo -e "$name = const($value)    # $comment" 
		fi
	fi
done < cbusdefs.csv >>$OUTPUT

# finally output the trailer stuff
# there is none for Python

echo "Finished"
exit 0
