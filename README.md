# cbusdefs
This repo is for the control of MERG cbusdefs files. It allows a variety of language specific cbus definitions files from a 
single version controlled source CSV file, cbusdefs.csv

Do NOT edit any of the language specific cbusdefs files, edit only cbusdefs.csv and generate the language files from that.

_generate.sh_ is a Bash script  that can be executed using "Git Bash" which is part of the git download (https://git-scm.com/downloads) or by 
any other suitable Bash shell.

The current _generate.sh_ script produces the following output files from the cbusdefs.csv:
1.	cbusdefs.h   - C
2.	cbusdefs.inc - Assembler
3.	cbusdefs.pas - Object Pascal (Delphi)
4.  CbusDefs.cs	 - C#.NET 5.0 (Core) solution that contains T4 templates to generate files for C#.
					The generated files should be suitable for .NET Framework projects.
5.	java/\*      - Java
6.  cbusdefs.py  - Python

# New versions of cbusdefs
cbusdefs will be updated from time to time, in line with changes to the CBUS spec or addition of new module types and/or manufacturer codes.

This has historically be done as a zip file of named-versioned files such as cbusdefs8r.h, cbusdefs8r.inc, cbusdefs8r.pas. 

However, now that cbusdefs is held in a Git repository, whilst the ZIP filename contains the version number, the individual fles do not.  A user may rename
their own copies of files, for their own use, to include the version number if they wish.

As well as being available to all CBUS users on GitHub, the zip for each new release is also uploaded to the MERG knowledgebase
(https://www.merg.org.uk/merg_wiki/doku.php?id=cbus:cbus-headers). Note: You must be a MERG member to access this page.

# Process to update cbusdefs
Whenever a new version of cbusdefs is released then the respective changes in cbusdefs.csv can be made and the _generate.sh_ script used to 
regenerate the language specific files. Once the language specific files have been generated then all the changes can be pushed back to github 
with a commit comment referencing the version number.

A new branch is created on GitHub for each new release, the GitHub release process is carried out on that branch, which is then merged back into master after
release.

Users of this repo can pull a new copy and access the language specific files directly.

A zip of the new generated files can also be uploaded onto the MERG Knowledgebase/Wiki for those who do not use GitHub.

For WIP working towards a new version, a branch can be created for that development and changes applied there.  This means that master will always reflect the latest released version.

Co-ordination of changes to CBUSDEFS is currently being managed by Pete Brownlow, merg@upsys.co.uk

Version 8x released 12/11/23  Added some module type ids and manufacturer id

