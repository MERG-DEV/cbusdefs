/* DO NOT EDIT THIS FILE.
 * This file is automatically generated by ./generate_cs.sh from cbusdefs.csv
 */ 

namespace merg.cbus
{

    // 
    // Copyright (C) Pete Brownlow 2011-2022   software@upsys.co.uk
    // Originally derived from opcodes.h (c) Andrew Crosland.
    // CSV version by Ian Hogg inspired by David W Radcliffe
    // 
    // Ver 8y 
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
    // Richard Crawshaw,29/02/2020,Fixed order of columns in CbusCabSigAspect2.
    // Pete Brownlow,01/09/20,Ver 8s for additional module ids defined in the ModuleIds file ver 33.
    //                        Updated descriptive comments for some module types
    //                        Updated CABDAT opcode to match RFC0004
    // Pete Brownlow,06/09/20,Ver 8t Added module type for CANRCOM. Fixed: Opcode for CABDAT, names for CANRC522 and CANMAG
    // Pete Brownlow,13/10/20,Ver 8u Added module types 67 to 74 including some Arduino projects
    //                               Added SPROG manufacturer code 44 and new SPROG CBUS module types
    //                               Additional error code for overload - now removed as not required after all
    //                               New bus type USB for modules with only USB and no CAN
    // Pete Brownlow,19/02/21,Ver 8u Added manufacturer code 13 for new development - who don't have a manufacturer id yet
    //                               Added proccessor identification codes for 18F25k83, 18F26k83 and 18F14K22.
    // Andrew Crosland,21/09/2021,Ver 8t Added PICs P18F14K22 P18F26K83 P18F27Q84 P18F47Q84 and P18F27Q83
    // Andrew Crosland,19/01/2022,Ver 8t, Added OPC_VCVS, Verify CV service mode - used for CV read hints, update SPROG modules types (PR#13)
    // Duncan Greenwood,07/10/2021,Ver 8t Added OPC_DTXC opcode (0xE9) for CBUS long messages - RFC 0005
    // Richard Crawshaw,11/10/2021,Ver 8t Fixed trailing comma in CbusCabSigAspect0
    // Pete Brownlow,28/07/2022,Ver 8v Resolve and merge changes in 8u branch with changes subsequently applied to master, now ver 8v in new branch,
    //   							Add requested module type ids 75 to 78
    //                               Resolve changes from PR #13,  move proposed and/or agreed opcodes not yet in the published spec to below the others
    // Pete Brownlow,5/08/2022, Ver 8w  Add module type 79 for CANBUFFER
    // Pete Brownlow,5/01/2023, Ver 8w  Add module type 80 for CANPMSense
    // Ian Hogg,14/08/2023, Ver 8x  Add manufacturer code for VLCB. This is a way to allocate a block of module Id to VLCB even though VLCB group is not a manufacturer per se. The VLCB module IDs will be defined in the VLCB repo
    // Pete Brownlow,2/11/23, Ver 8x  Add module id for CANLEVER (Tim Coombs)
    // Pete Brownlow,3/11/23, Ver 8x  Update SPROG module type ids (Andrew Crosland)
    // Pete Brownlow, 23/11/23, Ver 8y  Add CANSHIELD, CAN4IN4OUT, CANDEV

	public static class CbusDefs
	{
		public static class CbusArmProcessors
		{
			// 
			// ARM Processor type codes (identifies to FCU for bootload compatibility)
			// 
			public const int ARM1176JZF_S	=  1;	// As used in Raspberry Pi
			public const int ARMCortex_A7	=  2;	// As Used in Raspberry Pi 2
			public const int ARMCortex_A53	=  3;	// As used in Raspberry Pi 3
		}

		public static class CbusBusTypes
		{
			// 
			// BUS type that module is connected to
			// 
			public const int PB_CAN	=  1;	// 
			public const int PB_ETH	=  2;	// 
			public const int PB_MIWI	=  3;	// 
			public const int PB_USB	=  4;	// 
		}

		public static class CbusCabSigAspect0
		{
			// 
			// Sub opcodes for OPC_CABDAT
			// 
			public const int CDAT_CABSIG	=  1;	// 
		}

		public static class CbusCabSigAspect1
		{
			// 
			// Aspect codes for CDAT_CABSIG
			// 
			// First aspect byte
			// 
			public const int SASP_DANGER	=  0;	// 
			public const int SASP_CAUTION	=  1;	// 
			public const int SASP_PRELIM_CAUTION	=  2;	// 
			public const int SASP_PROCEED	=  3;	// 
			public const int SASP_CALLON	=  4;	// Set bit 2 for call-on - main aspect will usually be at danger
			public const int SASP_THEATRE	=  8;	// Set bit 3 to 0 for upper nibble is feather lcoation, set 1 for upper nibble is theatre code
		}

		public static class CbusCabSigAspect2
		{
			// 
			// Aspect codes for CDAT_CABSIG
			// 
			// Second Aspect byte
			// 
			public const int SASP_LIT	=  0;	// Set bit 0 to indicate lit
			public const int SASP_LUNAR	=  1;	// Set bit 1 for lunar indication
			// 
			// Remaining bits in second aspect byte yet to be defined - can be used for other signalling systems
		}

		public static class CbusCmdErrs
		{
			// 
			// Error codes for OPC_CMDERR
			// 
			public const int CMDERR_INV_CMD	=  1;	// 
			public const int CMDERR_NOT_LRN	=  2;	// 
			public const int CMDERR_NOT_SETUP	=  3;	// 
			public const int CMDERR_TOO_MANY_EVENTS	=  4;	// 
			public const int CMDERR_NO_EV	=  5;	// 
			public const int CMDERR_INV_EV_IDX	=  6;	// 
			public const int CMDERR_INVALID_EVENT	=  7;	// 
			public const int CMDERR_INV_EN_IDX	=  8;	// now reserved
			public const int CMDERR_INV_PARAM_IDX	=  9;	// 
			public const int CMDERR_INV_NV_IDX	=  10;	// 
			public const int CMDERR_INV_EV_VALUE	=  11;	// 
			public const int CMDERR_INV_NV_VALUE	=  12;	// 
			// 
			// Additional error codes proposed and/or agreed but not yet in the current published specification
			// 
			public const int CMDERR_LRN_OTHER	=  13;	// Sent when module in learn mode sees NNLRN for different module (also exits learn mode) 
			// 
		}

		public static class CbusErrs
		{
			// 
			// Error codes for OPC_ERR
			// 
			public const int ERR_LOCO_STACK_FULL	=  1;	// 
			public const int ERR_LOCO_ADDR_TAKEN	=  2;	// 
			public const int ERR_SESSION_NOT_PRESENT	=  3;	// 
			public const int ERR_CONSIST_EMPTY	=  4;	// 
			public const int ERR_LOCO_NOT_FOUND	=  5;	// 
			public const int ERR_CMD_RX_BUF_OFLOW	=  6;	// 
			public const int ERR_INVALID_REQUEST	=  7;	// 
			public const int ERR_SESSION_CANCELLED	=  8;	// 
		}

		public static class CbusManufacturer
		{
			// CBUS Manufacturer definitions
			// Where the manufacturer already has an NMRA code, this is used
			// 
			public const int MANU_DEV	=  13;	// For new manufacturer development - who don't have a manufacturer id yet
			public const int MANU_MERG	=  165;	// https://www.merg.co.uk
			public const int MANU_SPROG	=  44;	// https://www.sprog-dcc.co.uk/
			public const int MANU_ROCRAIL	=  70;	// http://www.rocrail.net
			public const int MANU_SPECTRUM	=  80;	// http://animatedmodeler.com  (Spectrum Engineering)
			public const int MANU_VLCB	=  250;	// VLCB range of modules
			public const int MANU_SYSPIXIE	=  249;	// Konrad Orlowski
			public const int MANU_RME	=  248;	// http://rmeuk.com  (Railway Modelling Experts Limited)
		}

		public static class CbusMergModuleTypes
		{
			// 
			// MODULE TYPES
			// 
			// Please note that the existence of a module type id does not necessarily mean that firmware has been implemented
			// 
			// MERG Module types
			// 
			public const int MTYP_SLIM	=  0;	// default for SLiM nodes
			public const int MTYP_CANACC4	=  1;	// Solenoid point driver
			public const int MTYP_CANACC5	=  2;	// Motorised point driver
			public const int MTYP_CANACC8	=  3;	// 8 digital outputs
			public const int MTYP_CANACE3	=  4;	// Control panel switch/button encoder
			public const int MTYP_CANACE8C	=  5;	// 8 digital inputs
			public const int MTYP_CANLED	=  6;	// 64 led driver
			public const int MTYP_CANLED64	=  7;	// 64 led driver (multi leds per event)
			public const int MTYP_CANACC4_2	=  8;	// 12v version of CANACC4
			public const int MTYP_CANCAB	=  9;	// CANCAB hand throttle
			public const int MTYP_CANCMD	=  10;	// CANCMD command station
			public const int MTYP_CANSERVO	=  11;	// 8 servo driver (on canacc8 or similar hardware)
			public const int MTYP_CANBC	=  12;	// BC1a command station
			public const int MTYP_CANRPI	=  13;	// RPI and RFID interface
			public const int MTYP_CANTTCA	=  14;	// Turntable controller (turntable end)
			public const int MTYP_CANTTCB	=  15;	// Turntable controller (control panel end)
			public const int MTYP_CANHS	=  16;	// Handset controller for old BC1a type handsets
			public const int MTYP_CANTOTI	=  17;	// Track occupancy detector
			public const int MTYP_CAN8I8O	=  18;	// 8 inputs 8 outputs
			public const int MTYP_CANSERVO8C	=  19;	// Canservo with servo position feedback
			public const int MTYP_CANRFID	=  20;	// RFID input
			public const int MTYP_CANTC4	=  21;	// 
			public const int MTYP_CANACE16C	=  22;	// 16 inputs
			public const int MTYP_CANIO8	=  23;	// 8 way I/O
			public const int MTYP_CANSNDX	=  24;	// ??
			public const int MTYP_CANEther	=  25;	// Ethernet interface
			public const int MTYP_CANSIG64	=  26;	// Multiple aspect signalling for CANLED module
			public const int MTYP_CANSIG8	=  27;	// Multiple aspect signalling for CANACC8 module
			public const int MTYP_CANCOND8C	=  28;	// Conditional event generation
			public const int MTYP_CANPAN	=  29;	// Control panel 32/32
			public const int MTYP_CANACE3C	=  30;	// Newer version of CANACE3 firmware
			public const int MTYP_CANPanel	=  31;	// Control panel 64/64
			public const int MTYP_CANMIO	=  32;	// Multiple I/O – Universal CANMIO firmware
			public const int MTYP_CANACE8MIO	=  33;	// Multiple IO module 16 inputs emulating CANACE8C on CANMIO hardware
			public const int MTYP_CANSOL	=  34;	// Solenoid driver module
			public const int MTYP_CANBIP	=  35;	// Universal CANBIP firmware - Bipolar IO module with additional 8 I/O pins (CANMIO family)
			public const int MTYP_CANCDU	=  36;	// Solenoid driver module with additional 6 I/O pins (CANMIO family)
			public const int MTYP_CANACC4CDU	=  37;	// CANACC4 firmware ported to CANCDU
			public const int MTYP_CANWiBase	=  38;	// CAN to MiWi base station
			public const int MTYP_WiCAB	=  39;	// Wireless cab using MiWi protocol
			public const int MTYP_CANWiFi	=  40;	// CAN to WiFi connection with Withrottle to CBUS protocol conversion
			public const int MTYP_CANFTT	=  41;	// Turntable controller configured using FLiM
			public const int MTYP_CANHNDST	=  42;	// Handset (alternative to CANCAB)
			public const int MTYP_CANTCHNDST	=  43;	// Touchscreen handset
			public const int MTYP_CANRFID8	=  44;	// multi-channel RFID reader
			public const int MTYP_CANmchRFID	=  45;	// either a 2ch or 8ch RFID reader
			public const int MTYP_CANPiWi	=  46;	// a Raspberry Pi based module for WiFi
			public const int MTYP_CAN4DC	=  47;	// DC train controller
			public const int MTYP_CANELEV	=  48;	// Nelevator controller
			public const int MTYP_CANSCAN	=  49;	// 128 switch inputs
			public const int MTYP_CANMIO_SVO	=  50;	// 16MHz 25k80 version of CANSERVO8c on CANMIO hardware
			public const int MTYP_CANMIO_INP	=  51;	// 16MHz 25k80 version of CANACE8MIO on CANMIO hardware
			public const int MTYP_CANMIO_OUT	=  52;	// 16MHz 25k80 version of CANACC8 on CANMIO hardware
			public const int MTYP_CANBIP_OUT	=  53;	// 16MHz 25k80 version of CANACC5 on CANBIP hardware
			public const int MTYP_CANASTOP	=  54;	// DCC stop generator
			public const int MTYP_CANCSB	=  55;	// CANCMD with on board 3A booster
			public const int MTYP_CANMAG	=  56;	// Magnet on Track detector
			public const int MTYP_CANACE16CMIO	=  57;	// 16 input equivaent to CANACE8C
			public const int MTYP_CANPiNODE	=  58;	// CBUS module based on Raspberry Pi
			public const int MTYP_CANDISP	=  59;	// 25K80 version of CANLED64 (IHart and MB)
			public const int MTYP_CANCOMPUTE	=  60;	// Compute Event processing engine
			public const int MTYP_CANRC522	=  61;	// Read/Write from/to RC522 RFID tags
			public const int MTYP_CANINP	=  62;	// 8 inputs module (2g version of CANACE8c) (Pete Brownlow)
			public const int MTYP_CANOUT	=  63;	// 8 outputs module (2g version of CANACC8) (Pete Brownlow)
			public const int MTYP_CANEMIO	=  64;	// Extended CANMIO (24 I/O ports) (Pete Brownlow)
			public const int MTYP_CANCABDC	=  65;	// DC cab
			public const int MTYP_CANRCOM	=  66;	// DC Railcom detector/reader
			public const int MTYP_CANMP3	=  67;	// MP3 sound player in response to events (eg: station announcements) (Duncan Greenwood)
			public const int MTYP_CANXMAS	=  68;	// Addressed RGB LED driver (Duncan Greenwood)
			public const int MTYP_CANSVOSET	=  69;	// Servo setting box (Duncan Greenwood)
			public const int MTYP_CANCMDDC	=  70;	// DC Command station
			public const int MTYP_CANTEXT	=  71;	// Text message display
			public const int MTYP_CANASIGNAL	=  72;	// Signal controller
			public const int MTYP_CANSLIDER	=  73;	// DCC cab with slider control (Dave Radcliffe)
			public const int MTYP_CANDCATC	=  74;	// DC ATC module (Dave Harris)
			public const int MTYP_CANGATE	=  75;	// Logic module using and/or gates (Phil Silver)
			public const int MTYP_CANSINP	=  76;	// Q series PIC input module (Ian Hart)
			public const int MTYP_CANSOUT	=  77;	// Q series PIC input module (Ian Hart)
			public const int MTYP_CANSBIP	=  78;	// Q series PIC input module (Ian Hart)
			public const int MTYP_CANBUFFER	=  79;	// Message buffer (Phil Silver)
			public const int MTYP_CANLEVER	=  80;	// Lever frame module (Tim Coombs)
			public const int MTYP_CANSHIELD	=  81;	// Kit 110 Arduino shield test firmware
			public const int MTYP_CAN4IN4OUT	=  82;	// 4 inputs 4 outputs (Arduino module)
			// 
			// At the time of writing the list of defined MERG module types is maintained by Pete Brownlow software@upsys.co.uk
			// Please liaise with Pete before adding new module types, 
			// and/or create your own GitHub branch, add your proposed new module type(s) and then create a Pull Request
			// 
			public const int MTYP_CAN_SW	=  0xFF;	// Software nodes
			public const int MTYP_EMPTY	=  0xFE;	// Empty module, bootloader only
			public const int MTYP_CANUSB	=  0xFD;	// USB interface
			public const int MTYP_CANDEV	=  0xFC;	// Module type for use by developers when developing something new
		}

		public static class CbusMicrochipProcessors
		{
			// 
			// Microchip Processor type codes (identifies to FCU for bootload compatibility)
			// 
			public const int P18F2480	=  1;	// 
			public const int P18F4480	=  2;	// 
			public const int P18F2580	=  3;	// 
			public const int P18F4580	=  4;	// 
			public const int P18F2585	=  5;	// 
			public const int P18F4585	=  6;	// 
			public const int P18F2680	=  7;	// 
			public const int P18F4680	=  8;	// 
			public const int P18F2682	=  9;	// 
			public const int P18F4682	=  10;	// 
			public const int P18F2685	=  11;	// 
			public const int P18F4685	=  12;	// 
			// 
			public const int P18F25K80	=  13;	// 
			public const int P18F45K80	=  14;	// 
			public const int P18F26K80	=  15;	// 
			public const int P18F46K80	=  16;	// 
			public const int P18F65K80	=  17;	// 
			public const int P18F66K80	=  18;	// 
			public const int P18F25K83	=  19;	// 
			public const int P18F26K83	=  20;	// 
			public const int P18F27Q84	=  21;	// 
			public const int P18F47Q84	=  22;	// 
			public const int P18F27Q83	=  23;	// 
			public const int P18F14K22	=  25;	// 
			// 
			public const int P32MX534F064	=  30;	// 
			public const int P32MX564F064	=  31;	// 
			public const int P32MX564F128	=  32;	// 
			public const int P32MX575F256	=  33;	// 
			public const int P32MX575F512	=  34;	// 
			public const int P32MX764F128	=  35;	// 
			public const int P32MX775F256	=  36;	// 
			public const int P32MX775F512	=  37;	// 
			public const int P32MX795F512	=  38;	// 
		}

		public static class CbusOpCodes
		{
			// 
			// 
			// CBUS opcodes list
			// 
			// Packets with no data bytes
			// 
			public const int OPC_ACK	=  0x00;	// General ack
			public const int OPC_NAK	=  0x01;	// General nak
			public const int OPC_HLT	=  0x02;	// Bus Halt
			public const int OPC_BON	=  0x03;	// Bus on
			public const int OPC_TOF	=  0x04;	// Track off
			public const int OPC_TON	=  0x05;	// Track on
			public const int OPC_ESTOP	=  0x06;	// Track stopped
			public const int OPC_ARST	=  0x07;	// System reset
			public const int OPC_RTOF	=  0x08;	// Request track off
			public const int OPC_RTON	=  0x09;	// Request track on
			public const int OPC_RESTP	=  0x0a;	// Request emergency stop all
			public const int OPC_RSTAT	=  0x0c;	// Request node status
			public const int OPC_QNN	=  0x0d;	// Query nodes
			// 
			public const int OPC_RQNP	=  0x10;	// Read node parameters
			public const int OPC_RQMN	=  0x11;	// Request name of module type
			// 
			// Packets with 1 data byte
			// 
			public const int OPC_KLOC	=  0x21;	// Release engine by handle
			public const int OPC_QLOC	=  0x22;	// Query engine by handle
			public const int OPC_DKEEP	=  0x23;	// Keep alive for cab
			// 
			public const int OPC_DBG1	=  0x30;	// Debug message with 1 status byte
			public const int OPC_EXTC	=  0x3F;	// Extended opcode
			// 
			// Packets with 2 data bytes
			// 
			public const int OPC_RLOC	=  0x40;	// Request session for loco
			public const int OPC_QCON	=  0x41;	// Query consist
			public const int OPC_SNN	=  0x42;	// Set node number
			public const int OPC_ALOC	=  0X43;	// Allocate loco (used to allocate to a shuttle in cancmd)
			// 
			public const int OPC_STMOD	=  0x44;	// Set Throttle mode
			public const int OPC_PCON	=  0x45;	// Consist loco
			public const int OPC_KCON	=  0x46;	// De-consist loco
			public const int OPC_DSPD	=  0x47;	// Loco speed/dir
			public const int OPC_DFLG	=  0x48;	// Set engine flags
			public const int OPC_DFNON	=  0x49;	// Loco function on
			public const int OPC_DFNOF	=  0x4A;	// Loco function off
			public const int OPC_SSTAT	=  0x4C;	// Service mode status
			public const int OPC_NNRSM	=  0x4F;	// Reset to manufacturer's defaults
			// 
			public const int OPC_RQNN	=  0x50;	// Request Node number in setup mode
			public const int OPC_NNREL	=  0x51;	// Node number release
			public const int OPC_NNACK	=  0x52;	// Node number acknowledge
			public const int OPC_NNLRN	=  0x53;	// Set learn mode
			public const int OPC_NNULN	=  0x54;	// Release learn mode
			public const int OPC_NNCLR	=  0x55;	// Clear all events
			public const int OPC_NNEVN	=  0x56;	// Read available event slots
			public const int OPC_NERD	=  0x57;	// Read all stored events
			public const int OPC_RQEVN	=  0x58;	// Read number of stored events
			public const int OPC_WRACK	=  0x59;	// Write acknowledge
			public const int OPC_RQDAT	=  0x5A;	// Request node data event
			public const int OPC_RQDDS	=  0x5B;	// Request short data frame
			public const int OPC_BOOT	=  0x5C;	// Put node into boot mode
			public const int OPC_ENUM	=  0x5D;	// Force can_id self enumeration
			public const int OPC_NNRST	=  0x5E;	// Reset node (as in restart)
			public const int OPC_EXTC1	=  0x5F;	// Extended opcode with 1 data byte
			// 
			// Packets with 3 data bytes
			// 
			public const int OPC_DFUN	=  0x60;	// Set engine functions
			public const int OPC_GLOC	=  0x61;	// Get loco (with support for steal/share)
			public const int OPC_ERR	=  0x63;	// Command station error
			public const int OPC_CMDERR	=  0x6F;	// Errors from nodes during config
			// 
			public const int OPC_EVNLF	=  0x70;	// Event slots left response
			public const int OPC_NVRD	=  0x71;	// Request read of node variable
			public const int OPC_NENRD	=  0x72;	// Request read stored event by index
			public const int OPC_RQNPN	=  0x73;	// Request read module parameters
			public const int OPC_NUMEV	=  0x74;	// Number of events stored response
			public const int OPC_CANID	=  0x75;	// Set canid
			public const int OPC_EXTC2	=  0x7F;	// Extended opcode with 2 data bytes
			// 
			// Packets with 4 data bytes
			// 
			public const int OPC_RDCC3	=  0x80;	// 3 byte DCC packet
			public const int OPC_WCVO	=  0x82;	// Write CV byte Ops mode by handle
			public const int OPC_WCVB	=  0x83;	// Write CV bit Ops mode by handle
			public const int OPC_QCVS	=  0x84;	// Read CV
			public const int OPC_PCVS	=  0x85;	// Report CV
			// 
			public const int OPC_ACON	=  0x90;	// on event
			public const int OPC_ACOF	=  0x91;	// off event
			public const int OPC_AREQ	=  0x92;	// Accessory Request event
			public const int OPC_ARON	=  0x93;	// Accessory response event on
			public const int OPC_AROF	=  0x94;	// Accessory response event off
			public const int OPC_EVULN	=  0x95;	// Unlearn event
			public const int OPC_NVSET	=  0x96;	// Set a node variable
			public const int OPC_NVANS	=  0x97;	// Node variable value response
			public const int OPC_ASON	=  0x98;	// Short event on
			public const int OPC_ASOF	=  0x99;	// Short event off
			public const int OPC_ASRQ	=  0x9A;	// Short Request event
			public const int OPC_PARAN	=  0x9B;	// Single node parameter response
			public const int OPC_REVAL	=  0x9C;	// Request read of event variable
			public const int OPC_ARSON	=  0x9D;	// Accessory short response on event
			public const int OPC_ARSOF	=  0x9E;	// Accessory short response off event
			public const int OPC_EXTC3	=  0x9F;	// Extended opcode with 3 data bytes
			// 
			// Packets with 5 data bytes
			// 
			public const int OPC_RDCC4	=  0xA0;	// 4 byte DCC packet
			public const int OPC_WCVS	=  0xA2;	// Write CV service mode
			// 
			public const int OPC_ACON1	=  0xB0;	// On event with one data byte
			public const int OPC_ACOF1	=  0xB1;	// Off event with one data byte
			public const int OPC_REQEV	=  0xB2;	// Read event variable in learn mode
			public const int OPC_ARON1	=  0xB3;	// Accessory on response (1 data byte)
			public const int OPC_AROF1	=  0xB4;	// Accessory off response (1 data byte)
			public const int OPC_NEVAL	=  0xB5;	// Event variable by index read response
			public const int OPC_PNN	=  0xB6;	// Response to QNN
			public const int OPC_ASON1	=  0xB8;	// Accessory short on with 1 data byte
			public const int OPC_ASOF1	=  0xB9;	// Accessory short off with 1 data byte
			public const int OPC_ARSON1	=  0xBD;	// Short response event on with one data byte
			public const int OPC_ARSOF1	=  0xBE;	// Short response event off with one data byte
			public const int OPC_EXTC4	=  0xBF;	// Extended opcode with 4 data bytes
			// 
			// Packets with 6 data bytes
			// 
			public const int OPC_RDCC5	=  0xC0;	// 5 byte DCC packet
			public const int OPC_WCVOA	=  0xC1;	// Write CV ops mode by address
			public const int OPC_CABDAT	=  0xC2;	// Cab data (cab signalling)
			public const int OPC_FCLK	=  0xCF;	// Fast clock
			// 
			public const int OPC_ACON2	=  0xD0;	// On event with two data bytes
			public const int OPC_ACOF2	=  0xD1;	// Off event with two data bytes
			public const int OPC_EVLRN	=  0xd2;	// Teach event
			public const int OPC_EVANS	=  0xd3;	// Event variable read response in learn mode
			public const int OPC_ARON2	=  0xD4;	// Accessory on response
			public const int OPC_AROF2	=  0xD5;	// Accessory off response
			public const int OPC_ASON2	=  0xD8;	// Accessory short on with 2 data bytes
			public const int OPC_ASOF2	=  0xD9;	// Accessory short off with 2 data bytes
			public const int OPC_ARSON2	=  0xDD;	// Short response event on with two data bytes
			public const int OPC_ARSOF2	=  0xDE;	// Short response event off with two data bytes
			public const int OPC_EXTC5	=  0xDF;	// Extended opcode with 5 data bytes
			// 
			// Packets with 7 data bytes
			// 
			public const int OPC_RDCC6	=  0xE0;	// 6 byte DCC packets
			public const int OPC_PLOC	=  0xE1;	// Loco session report
			public const int OPC_NAME	=  0xE2;	// Module name response
			public const int OPC_STAT	=  0xE3;	// Command station status report
			public const int OPC_PARAMS	=  0xEF;	// Node parameters response
			// 
			public const int OPC_ACON3	=  0xF0;	// On event with 3 data bytes
			public const int OPC_ACOF3	=  0xF1;	// Off event with 3 data bytes
			public const int OPC_ENRSP	=  0xF2;	// Read node events response
			public const int OPC_ARON3	=  0xF3;	// Accessory on response
			public const int OPC_AROF3	=  0xF4;	// Accessory off response
			public const int OPC_EVLRNI	=  0xF5;	// Teach event using event indexing
			public const int OPC_ACDAT	=  0xF6;	// Accessory data event: 5 bytes of node data (eg: RFID)
			public const int OPC_ARDAT	=  0xF7;	// Accessory data response
			public const int OPC_ASON3	=  0xF8;	// Accessory short on with 3 data bytes
			public const int OPC_ASOF3	=  0xF9;	// Accessory short off with 3 data bytes
			public const int OPC_DDES	=  0xFA;	// Short data frame aka device data event (device id plus 5 data bytes)
			public const int OPC_DDRS	=  0xFB;	// Short data frame response aka device data response
			public const int OPC_DDWS	=  0xFC;	// Device Data Write Short
			public const int OPC_ARSON3	=  0xFD;	// Short response event on with 3 data bytes
			public const int OPC_ARSOF3	=  0xFE;	// Short response event off with 3 data bytes
			public const int OPC_EXTC6	=  0xFF;	// Extended opcode with 6 data byes
			// 
			// Opcodes that are proposed and/or agreed but not yet in the current published specification
			// 
			public const int OPC_VCVS	=  0xA4;	// Verify CV service mode - used for CV read hints
			public const int OPC_DTXC	=  0xE9;	// CBUS long message packet
		}

		public static class CbusParamFlags
		{
			// 
			// Flags in PAR_FLAGS
			// 
			public const int PF_NOEVENTS	=  0;	// Module doesn't support events
			public const int PF_CONSUMER	=  1;	// Module is a consumer of events
			public const int PF_PRODUCER	=  2;	// Module is a producer of events
			public const int PF_COMBI	=  3;	// Module is both a consumer and producer of events
			public const int PF_FLiM	=  4;	// Module is in FLiM
			public const int PF_BOOT	=  8;	// Module supports the FCU bootloader protocol
			public const int PF_COE	=  16;	// Module can consume its own events
			public const int PF_LRN	=  32;	// Module is in learn mode
		}

		public static class CbusParamOffsetsPic
		{
			// 
			// Offsets to other values stored at the top of the parameter block.
			// These are not returned by opcode PARAN, but are present in the hex
			// file for FCU.
			// 
			public const int PAR_COUNT	=  0x18;	// Number of parameters implemented
			public const int PAR_NAME	=  0x1A;	// 4 byte Address of Module type name, up to 8 characters null terminated
			public const int PAR_CKSUM	=  0x1E;	// Checksum word at end of parameters
		}

		public static class CbusParams
		{
			// 
			// 
			// Parameter index numbers (readable by OPC_RQNPN, returned in OPC_PARAN)
			// Index numbers count from 1, subtract 1 for offset into parameter block
			// Note that RQNPN with index 0 returns the parameter count
			// 
			public const int PAR_MANU	=  1;	// Manufacturer id
			public const int PAR_MINVER	=  2;	// Minor version letter
			public const int PAR_MTYP	=  3;	// Module type code
			public const int PAR_EVTNUM	=  4;	// Number of events supported
			public const int PAR_EVNUM	=  5;	// Event variables per event
			public const int PAR_NVNUM	=  6;	// Number of Node variables
			public const int PAR_MAJVER	=  7;	// Major version number
			public const int PAR_FLAGS	=  8;	// Node flags
			public const int PAR_CPUID	=  9;	// Processor type
			public const int PAR_BUSTYPE	=  10;	// Bus type
			public const int PAR_LOAD	=  11;	// load address, 4 bytes
			public const int PAR_CPUMID	=  15;	// CPU manufacturer's id as read from the chip config space, 4 bytes (note - read from cpu at runtime, so not included in checksum)
			public const int PAR_CPUMAN	=  19;	// CPU manufacturer code
			public const int PAR_BETA	=  20;	// Beta revision (numeric), or 0 if release
		}

		public static class CbusProcessorManufacturers
		{
			// 
			// Processor manufacturer codes
			// 
			public const int CPUM_MICROCHIP	=  1;	// 
			public const int CPUM_ATMEL	=  2;	// 
			public const int CPUM_ARM	=  3;	// 
		}

		public static class CbusRocRailModuleTypes
		{
			// 
			// Rocrail Module types
			// 
			public const int MTYP_CANGC1	=  1;	// RS232 PC interface
			public const int MTYP_CANGC2	=  2;	// 16 I/O
			public const int MTYP_CANGC3	=  3;	// Command station (derived from cancmd)
			public const int MTYP_CANGC4	=  4;	// 8 channel RFID reader
			public const int MTYP_CANGC5	=  5;	// Cab for fixed panels (derived from cancab)
			public const int MTYP_CANGC6	=  6;	// 4 channel servo controller
			public const int MTYP_CANGC7	=  7;	// Fast clock module
			public const int MTYP_CANGC1e	=  11;	// CAN<->Ethernet interface
		}

		public static class CbusSStats
		{
			// 
			// Status codes for OPC_SSTAT
			// 
			public const int SSTAT_NO_ACK	=  1;	// 
			public const int SSTAT_OVLD	=  2;	// 
			public const int SSTAT_WR_ACK	=  3;	// 
			public const int SSTAT_BUSY	=  4;	// 
			public const int SSTAT_CV_ERROR	=  5;	// 
		}

		public static class CbusSpectrumModuleTypes
		{
			// 
			// Spectrum Engineering Animated Modeller module types
			// 
			public const int MTYP_AMCTRLR	=  1;	// Animation controller (firmware derived from cancmd)
			public const int MTYP_DUALCAB	=  2;	// Dual cab based on cancab
		}

		public static class CbusSprogModuleTypes
		{
			// 
			// Sprog Module types
			// 
			public const int MTYP_CANPiSPRG3	=  1;	// Pi-SPROG 3 programmer/command station
			public const int MTYP_CANSPROG3P	=  2;	// SPROG 3 Plus programmer/command station
			public const int MTYP_CANSPROG	=  3;	// CAN SPROG programmer/command station
			public const int MTYP_CANSBOOST	=  4;	// System Booster
			public const int MTYP_CANPiSPRGP	=  5;	// Pi-SPROG 3 Plus programmer/command station
			public const int MTYP_CANSOLNOID 	=  8;	// 8-channel (4-pairs) Solenoid I/O module
			public const int MTYP_CANSERVOIO	=  50;	// 8-channel Servo I/O module
			public const int MTYP_CANISB	=  100;	// CAN ISB Isolated CAN USB Interface
			public const int MTYP_CANSOLIO 	=  101;	// 8-channel (4-pairs) Solenoid I/O module
		}

		public static class CbusStmodModes
		{
			// 
			// 
			// Modes for STMOD
			// 
			public const int TMOD_SPD_MASK	=  3;	// 
			public const int TMOD_SPD_128	=  0;	// 
			public const int TMOD_SPD_14	=  1;	// 
			public const int TMOD_SPD_28I	=  2;	// 
			public const int TMOD_SPD_28	=  3;	// 
		}

		public static class CbusSysPixieModuleTypes
		{
			// 
			// SysPixie Module types (Konrad Orlowski)
			// 
			public const int MTYP_CANPMSense	=  1;	// Motorised point motor driver with current sense
		}

	}
}
