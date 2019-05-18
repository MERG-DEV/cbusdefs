/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate.sh from cbusdefs.csv
 */ 

package uk.org.merg.cbus;

// 
// Copyright (C) Pete Brownlow 2011-2017   software@upsys.co.uk
// Originally derived from opcodes.h (c) Andrew Crosland.
// CSV version by Ian Hogg inspired by David W Radcliffe
// 
// 
// 
//   This work is licensed under the:
//       Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
//   To view a copy of this license, visit:
//       http://creativecommons.org/licenses/by-nc-sa/4.0/
//   or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.
// 
//   License summary:
//     You are free to:
//       Share, copy and redistribute the material in any medium or format
//       Adapt, remix, transform, and build upon the material
// 
//     The licensor cannot revoke these freedoms as long as you follow the license terms.
// 
//     Attribution : You must give appropriate credit, provide a link to the license,
//                    and indicate if changes were made. You may do so in any reasonable manner,
//                    but not in any way that suggests the licensor endorses you or your use.
// 
//     NonCommercial : You may not use the material for commercial purposes. **(see note below)
// 
//     ShareAlike : If you remix, transform, or build upon the material, you must distribute
//                   your contributions under the same license as the original.
// 
//     No additional restrictions : You may not apply legal terms or technological measures that
//                                   legally restrict others from doing anything the license permits.
// 
//    ** For commercial use, please contact the original copyright holder(s) to agree licensing terms
// 
//     This software is distributed in the hope that it will be useful, but WITHOUT ANY
//     WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE
// 
// Version history:
// Pete Brownlow,6/4/11,Original from spec version 7e
// Roger Healey,6/4/11,Add OPC_CMDERR response codes
// Pete Brownlow,7/6/11,Updated to spec ver 7f and add new module ids
// Pete Brownlow,4/7/11,Updated to spec ver 7g
// Pete Brownlow,14/8/11,Updated to spec ver 7h
// Pete Brownlow,18/2/12,Updated to spec ver 8a, Rocrail and animated modeller module types added
// Pete Brownlow,10/4/12,Updated to spec ver 8b, extended parameter bytes
// Pete Brownlow,17/4/12,Updated parameter block definitions, added processor type definitions.
// Roger Healey,13/7/12,Add CANTOTI
// Pete Brownlow,15/9/12,Updated to spec ver 8c, added 0x5D ENUM and 0x75 CANID
// Pete Brownlow,4/1/13,Ver 8d New module types, added 0x5E  NNRST
// Roger Healey,15/2/13,Now at version d. Added new Module Ids (as per ModuleIds Issue 9) and
//          Align Processor Ids with constants.inc
//          Added .(fullstop) before each processor Id > 9
//          Added OPC_NNRST
// Roger Healey,27/4/13,Added CANSIG8 and CANSIG64
// Roger Healey,6/8/13,Added CANCOND8C
// Roger Healey,22/1/14,Added CANPAN, CANACE3C, CANPanel and CANMIO
// Pete Brownlow,22/1/14,Ver 8g New module types, OPC_NNRST & OPC_NNRSM, catch up with .inc file
//          Added parameter definitions for manufacturer's CPU id
//          Added extern C so can be included by c++ code
//          Fixed CANGC1e type definition
// Phil Wheeler,1/2/14,Corrected some typos. Added PRM_BETA, dotted some more decimal numbers
// Phil Wheeler,9/3/14,Corrected CANSIG MTYP definitions
// Pete Brownlow,19/4/14,Ver 8h Added module type defs for CANTOTIMIO, CANACE8MIO, CANBIP, CANSOL
// Pete Brownlow,06/7/15,Ver 8j Add new module types as per modules definitions v17 : CANCDU, CANACC4CDU, CANWiBase, WiCAB, CANWiFi, CANFTT
//          Add new opcode ALOC, added CPU manufacturer code CPUM_ATMEL
// Mike Bolton,2/3/16,Ver 8k    Add module type CANRFID8
// Pete Brownlow,2/7/16,Ver 8m Add new module types CANHNDST, CANTCHNDST, CANmchRFID and CANPiWi
//          Add processor codes for ARM chips used in Raspberry Pi's
// Pete Brownlow,16/2/17,Ver 8n Add module ids to bring it up to module ids document ver 25
// Pete Brownlow,29/7/17,Ver 8p Add new module ids and new cab signalling opcode
// Pete Brownlow,09/1/18,Ver 8q Add new parameter flag for module can consume its own events
// Ian Hogg,11/9/18,Ver 8r Added CANACE16CMIO, CANPiNODE, CANDISP, CANCOMPUTE
// 
// 
// 

public enum CbusArmProcessors {
// 
// ARM Processor type codes (identifies to FCU for bootload compatiblity)
// 
	ARM1176JZF_S(1),	//As used in Raspberry Pi
	ARMCortex_A7(2),	//As Used in Raspberry Pi 2
	ARMCortex_A53(3);	//As used in Raspberry Pi 3

	private final int v;

	private CbusArmProcessors(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
