# cbusdefs
This repo is for the control of MERG cbusdefs files. It allows a variety of language specific cbus definitions files from a single version controlled source CSV file.

The _generate.sh_ script is a bash that can be executed using "Git Bash" which is part of the git download (https://git-scm.com/downloads).

The current _generate.sh_ script produces the following output files from the cbusdefs.csv:
1.	cbusdefs.h
2.	cbusdefs.inc
3.	cbusdefs.pas
4.	java/\*

# New versions of cbusdefs
MERG will occasionally update cbusdefs. This has historically be done as a zip file of named-versioned files such as cbusdefs8r.h, cbusdefs8r.inc, cbusdefs8r.pas. The ZIP has historically been put onto the MERG wiki (https://www.merg.org.uk/merg_wiki/doku.php?id=cbus:cbus-headers). Note: You must be a MERG member to access this age.

# Process to update cbusdefs
Whenever a new version of cbusdefs is released then the respective changes in cbusdefs.csv can be made and the _generate.sh_ script used to regenerate the language specific files. Once the language specific files have been generated then all the changes can be pushed back to github with a commit comment referencing the MERG wiki's version number.

Users of the repo can pull a new copy and access the language specific files directly.

