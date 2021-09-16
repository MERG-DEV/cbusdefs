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

public enum CbusOpCodes {
// ,,,,,,,
// ,,,,,,,
// CBUS opcodes list,,,,,,,
// ,,,,,,,
// Packets with no data bytes,,,,,,,
// ,,,,,,,
	OPC_ACK(0x00),	//General ack,,,,,,,
	OPC_NAK(0x01),	//General nak,,,,,,,
	OPC_HLT(0x02),	//Bus Halt,,,,,,,
	OPC_BON(0x03),	//Bus on,,,,,,,
	OPC_TOF(0x04),	//Track off,,,,,,,
	OPC_TON(0x05),	//Track on,,,,,,,
	OPC_ESTOP(0x06),	//Track stopped,,,,,,,
	OPC_ARST(0x07),	//System reset,,,,,,,
	OPC_RTOF(0x08),	//Request track off,,,,,,,
	OPC_RTON(0x09),	//Request track on,,,,,,,
	OPC_RESTP(0x0a),	//Request emergency stop all,,,,,,,
	OPC_RSTAT(0x0c),	//Request node status,,,,,,,
	OPC_QNN(0x0d),	//Query nodes,,,,,,,
// ,,,,,,,
	OPC_RQNP(0x10),	//Read node parameters,,,,,,,
	OPC_RQMN(0x11),	//Request name of module type,,,,,,,
// ,,,,,,,
// Packets with 1 data byte,,,,,,,
// ,,,,,,,
	OPC_KLOC(0x21),	//Release engine by handle,,,,,,,
	OPC_QLOC(0x22),	//Query engine by handle,,,,,,,
	OPC_DKEEP(0x23),	//Keep alive for cab,,,,,,,
// ,,,,,,,
	OPC_DBG1(0x30),	//Debug message with 1 status byte,,,,,,,
	OPC_EXTC(0x3F),	//Extended opcode,,,,,,,
// ,,,,,,,
// Packets with 2 data bytes,,,,,,,
// ,,,,,,,
	OPC_RLOC(0x40),	//Request session for loco,,,,,,,
	OPC_QCON(0x41),	//Query consist,,,,,,,
	OPC_SNN(0x42),	//Set node number,,,,,,,
	OPC_ALOC(0X43),	//Allocate loco (used to allocate to a shuttle in cancmd),,,,,,,
// ,,,,,,,
	OPC_STMOD(0x44),	//Set Throttle mode,,,,,,,
	OPC_PCON(0x45),	//Consist loco,,,,,,,
	OPC_KCON(0x46),	//De-consist loco,,,,,,,
	OPC_DSPD(0x47),	//Loco speed/dir,,,,,,,
	OPC_DFLG(0x48),	//Set engine flags,,,,,,,
	OPC_DFNON(0x49),	//Loco function on,,,,,,,
	OPC_DFNOF(0x4A),	//Loco function off,,,,,,,
	OPC_SSTAT(0x4C),	//Service mode status,,,,,,,
	OPC_NNRSM(0x4F),	//Reset to manufacturer's defaults,,,,,,,
// ,,,,,,,
	OPC_RQNN(0x50),	//Request Node number in setup mode,,,,,,,
	OPC_NNREL(0x51),	//Node number release,,,,,,,
	OPC_NNACK(0x52),	//Node number acknowledge,,,,,,,
	OPC_NNLRN(0x53),	//Set learn mode,,,,,,,
	OPC_NNULN(0x54),	//Release learn mode,,,,,,,
	OPC_NNCLR(0x55),	//Clear all events,,,,,,,
	OPC_NNEVN(0x56),	//Read available event slots,,,,,,,
	OPC_NERD(0x57),	//Read all stored events,,,,,,,
	OPC_RQEVN(0x58),	//Read number of stored events,,,,,,,
	OPC_WRACK(0x59),	//Write acknowledge,,,,,,,
	OPC_RQDAT(0x5A),	//Request node data event,,,,,,,
	OPC_RQDDS(0x5B),	//Request short data frame,,,,,,,
	OPC_BOOT(0x5C),	//Put node into boot mode,,,,,,,
	OPC_ENUM(0x5D),	//Force can_id self enumeration,,,,,,,
	OPC_NNRST(0x5E),	//Reset node (as in restart),,,,,,,
	OPC_EXTC1(0x5F),	//Extended opcode with 1 data byte,,,,,,,
// ,,,,,,,
// Packets with 3 data bytes,,,,,,,
// ,,,,,,,
	OPC_DFUN(0x60),	//Set engine functions,,,,,,,
	OPC_GLOC(0x61),	//Get loco (with support for steal/share),,,,,,,
	OPC_ERR(0x63),	//Command station error,,,,,,,
	OPC_CMDERR(0x6F),	//Errors from nodes during config,,,,,,,
// ,,,,,,,
	OPC_EVNLF(0x70),	//Event slots left response,,,,,,,
	OPC_NVRD(0x71),	//Request read of node variable,,,,,,,
	OPC_NENRD(0x72),	//Request read stored event by index,,,,,,,
	OPC_RQNPN(0x73),	//Request read module parameters,,,,,,,
	OPC_NUMEV(0x74),	//Number of events stored response,,,,,,,
	OPC_CANID(0x75),	//Set canid,,,,,,,
	OPC_EXTC2(0x7F),	//Extended opcode with 2 data bytes,,,,,,,
// ,,,,,,,
// Packets with 4 data bytes,,,,,,,
// ,,,,,,,
	OPC_RDCC3(0x80),	//3 byte DCC packet,,,,,,,
	OPC_WCVO(0x82),	//Write CV byte Ops mode by handle,,,,,,,
	OPC_WCVB(0x83),	//Write CV bit Ops mode by handle,,,,,,,
	OPC_QCVS(0x84),	//Read CV,,,,,,,
	OPC_PCVS(0x85),	//Report CV,,,,,,,
// ,,,,,,,
	OPC_ACON(0x90),	//on event,,,,,,,
	OPC_ACOF(0x91),	//off event,,,,,,,
	OPC_AREQ(0x92),	//Accessory Request event,,,,,,,
	OPC_ARON(0x93),	//Accessory response event on,,,,,,,
	OPC_AROF(0x94),	//Accessory response event off,,,,,,,
	OPC_EVULN(0x95),	//Unlearn event,,,,,,,
	OPC_NVSET(0x96),	//Set a node variable,,,,,,,
	OPC_NVANS(0x97),	//Node variable value response,,,,,,,
	OPC_ASON(0x98),	//Short event on,,,,,,,
	OPC_ASOF(0x99),	//Short event off,,,,,,,
	OPC_ASRQ(0x9A),	//Short Request event,,,,,,,
	OPC_PARAN(0x9B),	//Single node parameter response,,,,,,,
	OPC_REVAL(0x9C),	//Request read of event variable,,,,,,,
	OPC_ARSON(0x9D),	//Accessory short response on event,,,,,,,
	OPC_ARSOF(0x9E),	//Accessory short response off event,,,,,,,
	OPC_EXTC3(0x9F),	//Extended opcode with 3 data bytes,,,,,,,
// ,,,,,,,
// Packets with 5 data bytes,,,,,,,
// ,,,,,,,
	OPC_RDCC4(0xA0),	//4 byte DCC packet,,,,,,,
	OPC_WCVS(0xA2),	//Write CV service mode,,,,,,,
// ,,,,,,,
	OPC_ACON1(0xB0),	//On event with one data byte,,,,,,,
	OPC_ACOF1(0xB1),	//Off event with one data byte,,,,,,,
	OPC_REQEV(0xB2),	//Read event variable in learn mode,,,,,,,
	OPC_ARON1(0xB3),	//Accessory on response (1 data byte),,,,,,,
	OPC_AROF1(0xB4),	//Accessory off response (1 data byte),,,,,,,
	OPC_NEVAL(0xB5),	//Event variable by index read response,,,,,,,
	OPC_PNN(0xB6),	//Response to QNN,,,,,,,
	OPC_ASON1(0xB8),	//Accessory short on with 1 data byte,,,,,,,
	OPC_ASOF1(0xB9),	//Accessory short off with 1 data byte,,,,,,,
	OPC_ARSON1(0xBD),	//Short response event on with one data byte,,,,,,,
	OPC_ARSOF1(0xBE),	//Short response event off with one data byte,,,,,,,
	OPC_EXTC4(0xBF),	//Extended opcode with 4 data bytes,,,,,,,
// ,,,,,,,
// Packets with 6 data bytes,,,,,,,
// ,,,,,,,
	OPC_RDCC5(0xC0),	//5 byte DCC packet,,,,,,,
	OPC_WCVOA(0xC1),	//Write CV ops mode by address,,,,,,,
	OPC_CABDAT(0xC2),	//Cab data (cab signalling),,,,,,,
	OPC_FCLK(0xCF),	//Fast clock,,,,,,,
// ,,,,,,,
	OPC_ACON2(0xD0),	//On event with two data bytes,,,,,,,
	OPC_ACOF2(0xD1),	//Off event with two data bytes,,,,,,,
	OPC_EVLRN(0xd2),	//Teach event,,,,,,,
	OPC_EVANS(0xd3),	//Event variable read response in learn mode,,,,,,,
	OPC_ARON2(0xD4),	//Accessory on response,,,,,,,
	OPC_AROF2(0xD5),	//Accessory off response,,,,,,,
	OPC_ASON2(0xD8),	//Accessory short on with 2 data bytes,,,,,,,
	OPC_ASOF2(0xD9),	//Accessory short off with 2 data bytes,,,,,,,
	OPC_ARSON2(0xDD),	//Short response event on with two data bytes,,,,,,,
	OPC_ARSOF2(0xDE),	//Short response event off with two data bytes,,,,,,,
	OPC_EXTC5(0xDF),	//Extended opcode with 5 data bytes,,,,,,,
// ,,,,,,,
// Packets with 7 data bytes,,,,,,,
// ,,,,,,,
	OPC_RDCC6(0xE0),	//6 byte DCC packets,,,,,,,
	OPC_PLOC(0xE1),	//Loco session report,,,,,,,
	OPC_NAME(0xE2),	//Module name response,,,,,,,
	OPC_STAT(0xE3),	//Command station status report,,,,,,,
	OPC_PARAMS(0xEF),	//Node parameters response,,,,,,,
// ,,,,,,,
	OPC_ACON3(0xF0),	//On event with 3 data bytes,,,,,,,
	OPC_ACOF3(0xF1),	//Off event with 3 data bytes,,,,,,,
	OPC_ENRSP(0xF2),	//Read node events response,,,,,,,
	OPC_ARON3(0xF3),	//Accessory on response,,,,,,,
	OPC_AROF3(0xF4),	//Accessory off response,,,,,,,
	OPC_EVLRNI(0xF5),	//Teach event using event indexing,,,,,,,
	OPC_ACDAT(0xF6),	//Accessory data event: 5 bytes of node data (eg: RFID),,,,,,,
	OPC_ARDAT(0xF7),	//Accessory data response,,,,,,,
	OPC_ASON3(0xF8),	//Accessory short on with 3 data bytes,,,,,,,
	OPC_ASOF3(0xF9),	//Accessory short off with 3 data bytes,,,,,,,
	OPC_DDES(0xFA),	//Short data frame aka device data event (device id plus 5 data bytes),,,,,,,
	OPC_DDRS(0xFB),	//Short data frame response aka device data response,,,,,,,
	OPC_DDWS(0xFC),	//Device Data Write Short,,,,,,,
	OPC_ARSON3(0xFD),	//Short response event on with 3 data bytes,,,,,,,
	OPC_ARSOF3(0xFE),	//Short response event off with 3 data bytes,,,,,,,
	OPC_EXTC6(0xFF);	//Extended opcode with 6 data byes,,,,,,,

	private final int v;

	private CbusOpCodes(int v) {
		this.v = v;
	}

	public int value() {
		return v;
	}
}
