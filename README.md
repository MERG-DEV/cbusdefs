# cbusdefs
This repo is for the control of MERG cbusdefs files. It allows a variety of language specific cbus definitions files from a single version controlled source CSV file.

The _generate.sh_ script is a bash that can be executed using "Git Bash" which is part of the git download (https://git-scm.com/downloads).

The current _generate.sh_ script produces the following output files from the cbusdefs.csv:
1.	cbusdefs.h   - C
2.	cbusdefs.inc - Assembler
3.	cbusdefs.pas - Object Pascal
4.  CbusDefs	 - C#.NET 5.0 (Core) solution that contains T4 templates to generate files for C#.
					The generated files should be suitable for .NET Framework projects.
5.	java/\*      - Java

# New versions of cbusdefs
MERG will occasionally update cbusdefs. This has historically be done as a zip file of named-versioned files such as cbusdefs8r.h, cbusdefs8r.inc, cbusdefs8r.pas. The ZIP has historically been put onto the MERG wiki (https://www.merg.org.uk/merg_wiki/doku.php?id=cbus:cbus-headers). Note: You must be a MERG member to access this page.

# Process to update cbusdefs
Whenever a new version of cbusdefs is released then the respective changes in cbusdefs.csv can be made and the _generate.sh_ script used to regenerate the language specific files. Once the language specific files have been generated then all the changes can be pushed back to github with a commit comment referencing the MERG wiki's version number.

Users of the repo can pull a new copy and access the language specific files directly.

A zip of the new generated files can also be uploaded onto the MERG Knowledgebase/Wiki for those who do not use GitHub.

For WIP working towards a new version, a branch can be created for that development and changes applied there.  This means that master will always reflect the latest released version.

