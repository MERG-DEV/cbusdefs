#ifndef __CBUSXDEFS_H
#define __CBUSXDEFS_H

/*

        Copyright (C) 2011-2017 Pete Brownlow  merg@upsys.co.uk

 * CBUS extended opcodes definitions for use with C18 compiler
 * These definitions are currently proposed and do not yet form part of the CBUS spec

 * Pete Brownlow  1/9/11


 This work is licensed under the:
      Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
   To view a copy of this license, visit:
      http://creativecommons.org/licenses/by-nc-sa/4.0/
   or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.

   License summary:
    You are free to:
      Share, copy and redistribute the material in any medium or format
      Adapt, remix, transform, and build upon the material

    The licensor cannot revoke these freedoms as long as you follow the license terms.

    Attribution : You must give appropriate credit, provide a link to the license,
                   and indicate if changes were made. You may do so in any reasonable manner,
                   but not in any way that suggests the licensor endorses you or your use.

    NonCommercial : You may not use the material for commercial purposes. **(see note below)

    ShareAlike : If you remix, transform, or build upon the material, you must distribute
                  your contributions under the same license as the original.

    No additional restrictions : You may not apply legal terms or technological measures that
                                  legally restrict others from doing anything the license permits.

   ** For commercial use, please contact the original copyright holder(s) to agree licensing terms

    This software is distributed in the hope that it will be useful, but WITHOUT ANY
    WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE

**************************************************************************************************************
  Note:   This source code has been written using a tab stop and indentation setting
          of 4 characters. To see everything lined up correctly, please set your
          IDE or text editor to the same settings.
******************************************************************************************************
	
 For version number and revision history see CANCMD.c
 
*/ 


// 1 data Byte extended sub-opcodes (used with OPC_EXTC1 (0x5F) - additional byte is cmd station number

#define SUBOPC_XARST   0x00	//	0x5F00    // Command station reset		<nnhi><nnlo><cmd#>
#define SUBOPC_XTOF    0x04	// 	0x5F04    // Track off				<cmd#>
#define SUBOPC_XTON    0x05	//	0x5F05    // Track on				<cmd#>
#define SUBOPC_XESTOP  0x06	//	0x5F06    // Track stopped			<cmd#>
#define SUBOPC_XRTOF   0x08	//	0x5F08    // Request track off			<cmd#>
#define SUBOPC_XRTON   0x09	//	0x5F09    // Request track on			<cmd#>
#define SUBOPC_XRESTP  0x0a	//	0x5F0a    // Request emergency stop all         <cmd#>

// 2 data byte extended sub-opcodes (used with OPC_EXTC2 (0x7F)

#define SUBOPC_XQLOC   0x02	//	0x7F02    // query engine by handle             <cmd#><session>
#define SUBOPC_XDKEEP  0x03	//	0x7F03    // Keep alive for cab                 <cmd#><session>

// 3 data byte extended sub-opcodes (used with OPC_EXTC3 (0x9F)

#define SUBOPC_XQCON   0x01	//	0x9F01    // Query consist			<cmd#><conid><index>
#define SUBOPC_XSTMOD  0x04	//	0x9F04    // Set Throttlle mode                 <cmd#><session><mode>
#define SUBOPC_XPCON   0x05	//	0x9F05    // Consist loco			<cmd#><session><conid>
#define SUBOPC_XKCON   0x06	//	0x9F06    // De-consist loco                    <cmd#><session><conid>
#define SUBOPC_XDSPD   0x07	//	0x9F07    // Loco speed/dir			<cmd#><session><speed/dir>
#define SUBOPC_XDFLG   0x08	//	0x9F08    // Set engine flags                   <cmd#><session><flags>
#define	SUBOPC_XDFNON  0x09	//	0x9F09	  // Loco function on                   <cmd#><session><fnum>
#define SUBOPC_XDFNOF  0x0a	//	0x9F0A	  // Loco function off                  <cmd#><session><fnum>
#define SUBOPC_XSSTAT  0x0c	//	0x9F0C    // Service mode status                <cmd#><session><status>

// 4 data byte extended sub-opcodes (used with OPC_EXTC4 (0xBF)

#define SUBOPC_XDFUN   0x00	//	0xBF00	  // Extended DFUN                      <cmd#><session><fn1><fn2>
#define SUBOPC_XKLOC   0x01	//	0xBF01    // Release loco by handle             <cmd#><session><data><flags>   flags bit 7 set, data is the autoshuttle id  bit 6 set, requst handover, data is new cmd#
#define SUBOPC_XDCCERR 0x03	//	0xBF03	  // Extended DCC ERR                   <cmd#><addrh><addrl><err>
#define SUBOPC_XSTAT   0x0f	//	0xBF0F    // Command station status report	<nnhi><nnlo><cmd#><status>

// 5 data byte extended sub-opcodes (used with OPC_EXTC5 (0xDF)


#define SUBOPC_XWCVO	0x02	//	0xDF02	  // Extended WCVB                      <cmd#><session><cvh><cvl><val>
#define SUBOPC_XWCVB	0x03	//	0xDF03	  // Extended WCVB                      <cmd#><session><cvh><cvl><val>
#define SUBOPC_XQCVS	0x04	//	0xDF04	  // Extended QCVS                      <cmd#><session><cvh><cvl><mode>
#define	SUBOPC_XPCVS	0x05	//	0xDF05	  // Extended PCVS                      <cmd#><session><cvh><cvl><val>

// 6 data byte extended sub-opcodes (used with OPC_EXTC6 (0xFF)

#define SUBOPC_XGLOC	0x00	//      0xFF00    // Extended Request session for loco	<nnhi><nnlo><cmd#><addrh><addrl><flags>   Flags bit 0 set for steal, bit 1 for share.
#define SUBOPC_XPLOC	0x01	//	0xFF01	  // Extended PLOC                      <nnlo><cmd#><session><addrh><addrl><speeddir | consist#>
#define	SUBOPC_XWCVS	0x02	//	0xFF02	  // Extended WCVO                      <cmd#><session><cvh><cvl><mode><val>   - session may be optional depending on CS - but keep in spec
#define SUBOPC_XWCVOA	0x03	//	0xFF03 	  // Extended WCVOA                     <cmd#><addrh><addrl><cvh><cvl><mode><vAL>  - one too many bytes!!!  - is mode required for ops mode programming??

#endif



