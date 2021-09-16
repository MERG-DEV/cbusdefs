/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by D:\Projects\CBUS\merg\cbusdefs\generate.sh from cbusdefs.csv
 */ 

package uk.org.merg.cbus;

// ,,,,,,,
// Copyright (C) Pete Brownlow 2011-2020   software@upsys.co.uk,,,,,,,
// Originally derived from opcodes.h (c) Andrew Crosland.,,,,,,,
// CSV version by Ian Hogg inspired by David W Radcliffe,,,,,,,
// ,,,,,,,
// Ver 8t,,,,,,,
// ,,,,,,,
//   This work is licensed under the:,,,,,,,
//       Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.,,,,,,,
//   To view a copy of this license, visit:,,,,,,
//       http://creativecommons.org/licenses/by-nc-sa/4.0/,,,,,,,
//   or send a letter to Creative Commons, PO Box 1866, Mountain View, CA 94042, USA.,,,
// ,,,,,,,
//   License summary:,,,,,,,
//     You are free to:,,,,,,,
//       Share, copy and redistribute the material in any medium or format,,,,,,
//       Adapt, remix, transform, and build upon the material,,,,
// ,,,,,,,
//     The licensor cannot revoke these freedoms as long as you follow the license terms.,,,,,,,
// ,,,,,,,
//     Attribution : You must give appropriate credit, provide a link to the license,,,,,,
//                    and indicate if changes were made. You may do so in any reasonable manner,,,,,,,
//                    but not in any way that suggests the licensor endorses you or your use.,,,,,,,
// ,,,,,,,
//     NonCommercial : You may not use the material for commercial purposes. **(see note below),,,,,,,
// ,,,,,,,
//     ShareAlike : If you remix, transform, or build upon the material, you must distribute,,,,
//                   your contributions under the same license as the original.,,,,,,,
// ,,,,,,,
//     No additional restrictions : You may not apply legal terms or technological measures that,,,,,,,
//                                   legally restrict others from doing anything the license permits.,,,,,,,
// ,,,,,,,
//    ** For commercial use, please contact the original copyright holder(s) to agree licensing terms,,,,,,
// ,,,,,,,
//     This software is distributed in the hope that it will be useful, but WITHOUT ANY,,,,,,
//     WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE,,,,,,,
// ,,,,,,,
// Version history:,,,,,,,
// Pete Brownlow,06/04/2011,Original from spec version 7e,,,,,
// Roger Healey,06/04/2011,Add OPC_CMDERR response codes,,,,,
// Pete Brownlow,07/06/2011,Updated to spec ver 7f and add new module ids,,,,,
// Pete Brownlow,04/07/2011,Updated to spec ver 7g,,,,,
// Pete Brownlow,14/08/2011,Updated to spec ver 7h,,,,,
// Pete Brownlow,18/02/2012,Updated to spec ver 8a, Rocrail and animated modeller module types added,,,,
// Pete Brownlow,10/04/2012,Updated to spec ver 8b, extended parameter bytes,,,,
// Pete Brownlow,17/04/2012,Updated parameter block definitions, added processor type definitions.,,,,
// Roger Healey,13/07/2012,Add CANTOTI,,,,,
// Pete Brownlow,15/09/2012,Updated to spec ver 8c, added 0x5D ENUM and 0x75 CANID,,,,
// Pete Brownlow,04/01/2013,Ver 8d New module types, added 0x5E  NNRST,,,,
// Roger Healey,15/02/2013,Now at version d. Added new Module Ids (as per ModuleIds Issue 9) and,,,,,
//          Align Processor Ids with constants.inc,,,,,,,
//          Added .(fullstop) before each processor Id > 9,,,,,,,
//          Added OPC_NNRST,,,,,,,
// Roger Healey,27/04/2013,Added CANSIG8 and CANSIG64,,,,,
// Roger Healey,06/08/2013,Added CANCOND8C,,,,,
// Roger Healey,22/01/2014,Added CANPAN, CANACE3C, CANPanel and CANMIO,,,
// Pete Brownlow,22/01/2014,Ver 8g New module types, OPC_NNRST & OPC_NNRSM, catch up with .inc file,,,
//          Added parameter definitions for manufacturer's CPU id,,,,,,,
//          Added extern C so can be included by c++ code,,,,,,,
//          Fixed CANGC1e type definition,,,,,,,
// Phil Wheeler,01/02/2014,Corrected some typos. Added PRM_BETA, dotted some more decimal numbers,,,,
// Phil Wheeler,09/03/2014,Corrected CANSIG MTYP definitions,,,,,
// Pete Brownlow,19/04/2014,Ver 8h Added module type defs for CANTOTIMIO, CANACE8MIO, CANBIP, CANSOL,,
// Pete Brownlow,06/07/2015,Ver 8j Add new module types as per modules definitions v17 : CANCDU, CANACC4CDU, CANWiBase, WiCAB, CANWiFi, CANFTT
//          Add new opcode ALOC, added CPU manufacturer code CPUM_ATMEL,,,,,,
// Mike Bolton,02/03/2016,Ver 8k    Add module type CANRFID8,,,,,
// Pete Brownlow,02/07/2016,Ver 8m Add new module types CANHNDST, CANTCHNDST, CANmchRFID and CANPiWi,,,
//          Add processor codes for ARM chips used in Raspberry Pi's,,,,,,,
// Pete Brownlow,16/02/2017,Ver 8n Add module ids to bring it up to module ids document ver 25,,,,,
// Pete Brownlow,29/07/2017,Ver 8p Add new module ids and new cab signalling opcode,,,,,
// Pete Brownlow,09/01/2018,Ver 8q Add new parameter flag for module can consume its own events,,,,,
// Ian Hogg,11/09/2018,Ver 8r Added CANACE16CMIO, CANPiNODE, CANDISP, CANCOMPUTE,,
// Richard Crawshaw,29/02/2020,Fixed order of columns in CbusCabSigAspect2.,,,,,
// Pete Brownlow,01/09/2020,Ver 8s for additional module ids defined in the ModuleIds file ver 33.,,,,,
//                        Updated descriptive comments for some module types,,,,,,,
//                        Updated CABDAT opcode to match RFC0004,,,,,,,
// Pete Brownlow,06/09/2020,Ver 8t Added module type for CANRCOM. Fixed: Opcode for CABDAT, names for CANRC522 and CANMAG,,,,
// ,,,,,,,

public enum CbusSpectrumModuleTypes {
// ,,,,,,,
// Spectrum Engineering Animated Modeller module types,,,,,,,
// ,,,,,,,
	MTYP_AMCTRLR(1),	//Animation controller (firmware derived from cancmd),,,,,,,
	MTYP_DUALCAB(2);	//Dual cab based on cancab,,,,,,,

	private final int v;

	private CbusSpectrumModuleTypes(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
