// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/PokemonId.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonId.proto</summary>
  public static partial class PokemonIdReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/PokemonId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90bxIQUE9HT1Byb3Rv",
            "cy5FbnVtcyqnGwoJUG9rZW1vbklkEg0KCU1JU1NJTkdOTxAAEg0KCUJVTEJB",
            "U0FVUhABEgsKB0lWWVNBVVIQAhIMCghWRU5VU0FVUhADEg4KCkNIQVJNQU5E",
            "RVIQBBIOCgpDSEFSTUVMRU9OEAUSDQoJQ0hBUklaQVJEEAYSDAoIU1FVSVJU",
            "TEUQBxINCglXQVJUT1JUTEUQCBINCglCTEFTVE9JU0UQCRIMCghDQVRFUlBJ",
            "RRAKEgsKB01FVEFQT0QQCxIOCgpCVVRURVJGUkVFEAwSCgoGV0VFRExFEA0S",
            "CgoGS0FLVU5BEA4SDAoIQkVFRFJJTEwQDxIKCgZQSURHRVkQEBINCglQSURH",
            "RU9UVE8QERILCgdQSURHRU9UEBISCwoHUkFUVEFUQRATEgwKCFJBVElDQVRF",
            "EBQSCwoHU1BFQVJPVxAVEgoKBkZFQVJPVxAWEgkKBUVLQU5TEBcSCQoFQVJC",
            "T0sQGBILCgdQSUtBQ0hVEBkSCgoGUkFJQ0hVEBoSDQoJU0FORFNIUkVXEBsS",
            "DQoJU0FORFNMQVNIEBwSEgoOTklET1JBTl9GRU1BTEUQHRIMCghOSURPUklO",
            "QRAeEg0KCU5JRE9RVUVFThAfEhAKDE5JRE9SQU5fTUFMRRAgEgwKCE5JRE9S",
            "SU5PECESDAoITklET0tJTkcQIhIMCghDTEVGQUlSWRAjEgwKCENMRUZBQkxF",
            "ECQSCgoGVlVMUElYECUSDQoJTklORVRBTEVTECYSDgoKSklHR0xZUFVGRhAn",
            "Eg4KCldJR0dMWVRVRkYQKBIJCgVaVUJBVBApEgoKBkdPTEJBVBAqEgoKBk9E",
            "RElTSBArEgkKBUdMT09NECwSDQoJVklMRVBMVU1FEC0SCQoFUEFSQVMQLhIM",
            "CghQQVJBU0VDVBAvEgsKB1ZFTk9OQVQQMBIMCghWRU5PTU9USBAxEgsKB0RJ",
            "R0xFVFQQMhILCgdEVUdUUklPEDMSCgoGTUVPV1RIEDQSCwoHUEVSU0lBThA1",
            "EgsKB1BTWURVQ0sQNhILCgdHT0xEVUNLEDcSCgoGTUFOS0VZEDgSDAoIUFJJ",
            "TUVBUEUQORINCglHUk9XTElUSEUQOhIMCghBUkNBTklORRA7EgsKB1BPTElX",
            "QUcQPBINCglQT0xJV0hJUkwQPRINCglQT0xJV1JBVEgQPhIICgRBQlJBED8S",
            "CwoHS0FEQUJSQRBAEgwKCEFMQUtBWkFNEEESCgoGTUFDSE9QEEISCwoHTUFD",
            "SE9LRRBDEgsKB01BQ0hBTVAQRBIOCgpCRUxMU1BST1VUEEUSDgoKV0VFUElO",
            "QkVMTBBGEg4KClZJQ1RSRUVCRUwQRxINCglURU5UQUNPT0wQSBIOCgpURU5U",
            "QUNSVUVMEEkSCwoHR0VPRFVERRBKEgwKCEdSQVZFTEVSEEsSCQoFR09MRU0Q",
            "TBIKCgZQT05ZVEEQTRIMCghSQVBJREFTSBBOEgwKCFNMT1dQT0tFEE8SCwoH",
            "U0xPV0JSTxBQEg0KCU1BR05FTUlURRBREgwKCE1BR05FVE9OEFISDQoJRkFS",
            "RkVUQ0hEEFMSCQoFRE9EVU8QVBIKCgZET0RSSU8QVRIICgRTRUVMEFYSCwoH",
            "REVXR09ORxBXEgoKBkdSSU1FUhBYEgcKA01VSxBZEgwKCFNIRUxMREVSEFoS",
            "DAoIQ0xPWVNURVIQWxIKCgZHQVNUTFkQXBILCgdIQVVOVEVSEF0SCgoGR0VO",
            "R0FSEF4SCAoET05JWBBfEgsKB0RST1daRUUQYBIJCgVIWVBOTxBhEgoKBktS",
            "QUJCWRBiEgsKB0tJTkdMRVIQYxILCgdWT0xUT1JCEGQSDQoJRUxFQ1RST0RF",
            "EGUSDQoJRVhFR0dDVVRFEGYSDQoJRVhFR0dVVE9SEGcSCgoGQ1VCT05FEGgS",
            "CwoHTUFST1dBSxBpEg0KCUhJVE1PTkxFRRBqEg4KCkhJVE1PTkNIQU4QaxIN",
            "CglMSUNLSVRVTkcQbBILCgdLT0ZGSU5HEG0SCwoHV0VFWklORxBuEgsKB1JI",
            "WUhPUk4QbxIKCgZSSFlET04QcBILCgdDSEFOU0VZEHESCwoHVEFOR0VMQRBy",
            "Eg4KCktBTkdBU0tIQU4QcxIKCgZIT1JTRUEQdBIKCgZTRUFEUkEQdRILCgdH",
            "T0xERUVOEHYSCwoHU0VBS0lORxB3EgoKBlNUQVJZVRB4EgsKB1NUQVJNSUUQ",
            "eRILCgdNUl9NSU1FEHoSCwoHU0NZVEhFUhB7EggKBEpZTlgQfBIOCgpFTEVD",
            "VEFCVVpaEH0SCgoGTUFHTUFSEH4SCgoGUElOU0lSEH8SCwoGVEFVUk9TEIAB",
            "Eg0KCE1BR0lLQVJQEIEBEg0KCEdZQVJBRE9TEIIBEgsKBkxBUFJBUxCDARIK",
            "CgVESVRUTxCEARIKCgVFRVZFRRCFARINCghWQVBPUkVPThCGARIMCgdKT0xU",
            "RU9OEIcBEgwKB0ZMQVJFT04QiAESDAoHUE9SWUdPThCJARIMCgdPTUFOWVRF",
            "EIoBEgwKB09NQVNUQVIQiwESCwoGS0FCVVRPEIwBEg0KCEtBQlVUT1BTEI0B",
            "Eg8KCkFFUk9EQUNUWUwQjgESDAoHU05PUkxBWBCPARINCghBUlRJQ1VOTxCQ",
            "ARILCgZaQVBET1MQkQESDAoHTU9MVFJFUxCSARIMCgdEUkFUSU5JEJMBEg4K",
            "CURSQUdPTkFJUhCUARIOCglEUkFHT05JVEUQlQESCwoGTUVXVFdPEJYBEggK",
            "A01FVxCXARIOCglDSElLT1JJVEEQmAESDAoHQkFZTEVFRhCZARINCghNRUdB",
            "TklVTRCaARIOCglDWU5EQVFVSUwQmwESDAoHUVVJTEFWQRCcARIPCgpUWVBI",
            "TE9TSU9OEJ0BEg0KCFRPVE9ESUxFEJ4BEg0KCENST0NPTkFXEJ8BEg8KCkZF",
            "UkFMSUdBVFIQoAESDAoHU0VOVFJFVBChARILCgZGVVJSRVQQogESDQoISE9P",
            "VEhPT1QQowESDAoHTk9DVE9XTBCkARILCgZMRURZQkEQpQESCwoGTEVESUFO",
            "EKYBEg0KCFNQSU5BUkFLEKcBEgwKB0FSSUFET1MQqAESCwoGQ1JPQkFUEKkB",
            "Eg0KCENISU5DSE9VEKoBEgwKB0xBTlRVUk4QqwESCgoFUElDSFUQrAESCwoG",
            "Q0xFRkZBEK0BEg4KCUlHR0xZQlVGRhCuARILCgZUT0dFUEkQrwESDAoHVE9H",
            "RVRJQxCwARIJCgROQVRVELEBEgkKBFhBVFUQsgESCwoGTUFSRUVQELMBEgwK",
            "B0ZMQUFGRlkQtAESDQoIQU1QSEFST1MQtQESDgoJQkVMTE9TU09NELYBEgsK",
            "Bk1BUklMTBC3ARIOCglBWlVNQVJJTEwQuAESDgoJU1VET1dPT0RPELkBEg0K",
            "CFBPTElUT0VEELoBEgsKBkhPUFBJUBC7ARINCghTS0lQTE9PTRC8ARINCghK",
            "VU1QTFVGRhC9ARIKCgVBSVBPTRC+ARIMCgdTVU5LRVJOEL8BEg0KCFNVTkZM",
            "T1JBEMABEgoKBVlBTk1BEMEBEgsKBldPT1BFUhDCARINCghRVUFHU0lSRRDD",
            "ARILCgZFU1BFT04QxAESDAoHVU1CUkVPThDFARIMCgdNVVJLUk9XEMYBEg0K",
            "CFNMT1dLSU5HEMcBEg8KCk1JU0RSRUFWVVMQyAESCgoFVU5PV04QyQESDgoJ",
            "V09CQlVGRkVUEMoBEg4KCUdJUkFGQVJJRxDLARILCgZQSU5FQ08QzAESDwoK",
            "Rk9SUkVUUkVTUxDNARIOCglEVU5TUEFSQ0UQzgESCwoGR0xJR0FSEM8BEgwK",
            "B1NURUVMSVgQ0AESDQoIU05VQkJVTEwQ0QESDQoIR1JBTkJVTEwQ0gESDQoI",
            "UVdJTEZJU0gQ0wESCwoGU0NJWk9SENQBEgwKB1NIVUNLTEUQ1QESDgoJSEVS",
            "QUNST1NTENYBEgwKB1NORUFTRUwQ1wESDgoJVEVERElVUlNBENgBEg0KCFVS",
            "U0FSSU5HENkBEgsKBlNMVUdNQRDaARINCghNQUdDQVJHTxDbARILCgZTV0lO",
            "VUIQ3AESDgoJUElMT1NXSU5FEN0BEgwKB0NPUlNPTEEQ3gESDQoIUkVNT1JB",
            "SUQQ3wESDgoJT0NUSUxMRVJZEOABEg0KCERFTElCSVJEEOEBEgwKB01BTlRJ",
            "TkUQ4gESDQoIU0tBUk1PUlkQ4wESDQoISE9VTkRPVVIQ5AESDQoISE9VTkRP",
            "T00Q5QESDAoHS0lOR0RSQRDmARILCgZQSEFOUFkQ5wESDAoHRE9OUEhBThDo",
            "ARINCghQT1JZR09OMhDpARINCghTVEFOVExFUhDqARINCghTTUVBUkdMRRDr",
            "ARIMCgdUWVJPR1VFEOwBEg4KCUhJVE1PTlRPUBDtARINCghTTU9PQ0hVTRDu",
            "ARILCgZFTEVLSUQQ7wESCgoFTUFHQlkQ8AESDAoHTUlMVEFOSxDxARIMCgdC",
            "TElTU0VZEPIBEgsKBlJBSUtPVRDzARIKCgVFTlRFSRD0ARIMCgdTVUlDVU5F",
            "EPUBEg0KCExBUlZJVEFSEPYBEgwKB1BVUElUQVIQ9wESDgoJVFlSQU5JVEFS",
            "EPgBEgoKBUxVR0lBEPkBEgoKBUhPX09IEPoBEgsKBkNFTEVCSRD7AWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PokemonId), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonId {
    [pbr::OriginalName("MISSINGNO")] Missingno = 0,
    [pbr::OriginalName("BULBASAUR")] Bulbasaur = 1,
    [pbr::OriginalName("IVYSAUR")] Ivysaur = 2,
    [pbr::OriginalName("VENUSAUR")] Venusaur = 3,
    [pbr::OriginalName("CHARMANDER")] Charmander = 4,
    [pbr::OriginalName("CHARMELEON")] Charmeleon = 5,
    [pbr::OriginalName("CHARIZARD")] Charizard = 6,
    [pbr::OriginalName("SQUIRTLE")] Squirtle = 7,
    [pbr::OriginalName("WARTORTLE")] Wartortle = 8,
    [pbr::OriginalName("BLASTOISE")] Blastoise = 9,
    [pbr::OriginalName("CATERPIE")] Caterpie = 10,
    [pbr::OriginalName("METAPOD")] Metapod = 11,
    [pbr::OriginalName("BUTTERFREE")] Butterfree = 12,
    [pbr::OriginalName("WEEDLE")] Weedle = 13,
    [pbr::OriginalName("KAKUNA")] Kakuna = 14,
    [pbr::OriginalName("BEEDRILL")] Beedrill = 15,
    [pbr::OriginalName("PIDGEY")] Pidgey = 16,
    [pbr::OriginalName("PIDGEOTTO")] Pidgeotto = 17,
    [pbr::OriginalName("PIDGEOT")] Pidgeot = 18,
    [pbr::OriginalName("RATTATA")] Rattata = 19,
    [pbr::OriginalName("RATICATE")] Raticate = 20,
    [pbr::OriginalName("SPEAROW")] Spearow = 21,
    [pbr::OriginalName("FEAROW")] Fearow = 22,
    [pbr::OriginalName("EKANS")] Ekans = 23,
    [pbr::OriginalName("ARBOK")] Arbok = 24,
    [pbr::OriginalName("PIKACHU")] Pikachu = 25,
    [pbr::OriginalName("RAICHU")] Raichu = 26,
    [pbr::OriginalName("SANDSHREW")] Sandshrew = 27,
    [pbr::OriginalName("SANDSLASH")] Sandslash = 28,
    [pbr::OriginalName("NIDORAN_FEMALE")] NidoranFemale = 29,
    [pbr::OriginalName("NIDORINA")] Nidorina = 30,
    [pbr::OriginalName("NIDOQUEEN")] Nidoqueen = 31,
    [pbr::OriginalName("NIDORAN_MALE")] NidoranMale = 32,
    [pbr::OriginalName("NIDORINO")] Nidorino = 33,
    [pbr::OriginalName("NIDOKING")] Nidoking = 34,
    [pbr::OriginalName("CLEFAIRY")] Clefairy = 35,
    [pbr::OriginalName("CLEFABLE")] Clefable = 36,
    [pbr::OriginalName("VULPIX")] Vulpix = 37,
    [pbr::OriginalName("NINETALES")] Ninetales = 38,
    [pbr::OriginalName("JIGGLYPUFF")] Jigglypuff = 39,
    [pbr::OriginalName("WIGGLYTUFF")] Wigglytuff = 40,
    [pbr::OriginalName("ZUBAT")] Zubat = 41,
    [pbr::OriginalName("GOLBAT")] Golbat = 42,
    [pbr::OriginalName("ODDISH")] Oddish = 43,
    [pbr::OriginalName("GLOOM")] Gloom = 44,
    [pbr::OriginalName("VILEPLUME")] Vileplume = 45,
    [pbr::OriginalName("PARAS")] Paras = 46,
    [pbr::OriginalName("PARASECT")] Parasect = 47,
    [pbr::OriginalName("VENONAT")] Venonat = 48,
    [pbr::OriginalName("VENOMOTH")] Venomoth = 49,
    [pbr::OriginalName("DIGLETT")] Diglett = 50,
    [pbr::OriginalName("DUGTRIO")] Dugtrio = 51,
    [pbr::OriginalName("MEOWTH")] Meowth = 52,
    [pbr::OriginalName("PERSIAN")] Persian = 53,
    [pbr::OriginalName("PSYDUCK")] Psyduck = 54,
    [pbr::OriginalName("GOLDUCK")] Golduck = 55,
    [pbr::OriginalName("MANKEY")] Mankey = 56,
    [pbr::OriginalName("PRIMEAPE")] Primeape = 57,
    [pbr::OriginalName("GROWLITHE")] Growlithe = 58,
    [pbr::OriginalName("ARCANINE")] Arcanine = 59,
    [pbr::OriginalName("POLIWAG")] Poliwag = 60,
    [pbr::OriginalName("POLIWHIRL")] Poliwhirl = 61,
    [pbr::OriginalName("POLIWRATH")] Poliwrath = 62,
    [pbr::OriginalName("ABRA")] Abra = 63,
    [pbr::OriginalName("KADABRA")] Kadabra = 64,
    [pbr::OriginalName("ALAKAZAM")] Alakazam = 65,
    [pbr::OriginalName("MACHOP")] Machop = 66,
    [pbr::OriginalName("MACHOKE")] Machoke = 67,
    [pbr::OriginalName("MACHAMP")] Machamp = 68,
    [pbr::OriginalName("BELLSPROUT")] Bellsprout = 69,
    [pbr::OriginalName("WEEPINBELL")] Weepinbell = 70,
    [pbr::OriginalName("VICTREEBEL")] Victreebel = 71,
    [pbr::OriginalName("TENTACOOL")] Tentacool = 72,
    [pbr::OriginalName("TENTACRUEL")] Tentacruel = 73,
    [pbr::OriginalName("GEODUDE")] Geodude = 74,
    [pbr::OriginalName("GRAVELER")] Graveler = 75,
    [pbr::OriginalName("GOLEM")] Golem = 76,
    [pbr::OriginalName("PONYTA")] Ponyta = 77,
    [pbr::OriginalName("RAPIDASH")] Rapidash = 78,
    [pbr::OriginalName("SLOWPOKE")] Slowpoke = 79,
    [pbr::OriginalName("SLOWBRO")] Slowbro = 80,
    [pbr::OriginalName("MAGNEMITE")] Magnemite = 81,
    [pbr::OriginalName("MAGNETON")] Magneton = 82,
    [pbr::OriginalName("FARFETCHD")] Farfetchd = 83,
    [pbr::OriginalName("DODUO")] Doduo = 84,
    [pbr::OriginalName("DODRIO")] Dodrio = 85,
    [pbr::OriginalName("SEEL")] Seel = 86,
    [pbr::OriginalName("DEWGONG")] Dewgong = 87,
    [pbr::OriginalName("GRIMER")] Grimer = 88,
    [pbr::OriginalName("MUK")] Muk = 89,
    [pbr::OriginalName("SHELLDER")] Shellder = 90,
    [pbr::OriginalName("CLOYSTER")] Cloyster = 91,
    [pbr::OriginalName("GASTLY")] Gastly = 92,
    [pbr::OriginalName("HAUNTER")] Haunter = 93,
    [pbr::OriginalName("GENGAR")] Gengar = 94,
    [pbr::OriginalName("ONIX")] Onix = 95,
    [pbr::OriginalName("DROWZEE")] Drowzee = 96,
    [pbr::OriginalName("HYPNO")] Hypno = 97,
    [pbr::OriginalName("KRABBY")] Krabby = 98,
    [pbr::OriginalName("KINGLER")] Kingler = 99,
    [pbr::OriginalName("VOLTORB")] Voltorb = 100,
    [pbr::OriginalName("ELECTRODE")] Electrode = 101,
    [pbr::OriginalName("EXEGGCUTE")] Exeggcute = 102,
    [pbr::OriginalName("EXEGGUTOR")] Exeggutor = 103,
    [pbr::OriginalName("CUBONE")] Cubone = 104,
    [pbr::OriginalName("MAROWAK")] Marowak = 105,
    [pbr::OriginalName("HITMONLEE")] Hitmonlee = 106,
    [pbr::OriginalName("HITMONCHAN")] Hitmonchan = 107,
    [pbr::OriginalName("LICKITUNG")] Lickitung = 108,
    [pbr::OriginalName("KOFFING")] Koffing = 109,
    [pbr::OriginalName("WEEZING")] Weezing = 110,
    [pbr::OriginalName("RHYHORN")] Rhyhorn = 111,
    [pbr::OriginalName("RHYDON")] Rhydon = 112,
    [pbr::OriginalName("CHANSEY")] Chansey = 113,
    [pbr::OriginalName("TANGELA")] Tangela = 114,
    [pbr::OriginalName("KANGASKHAN")] Kangaskhan = 115,
    [pbr::OriginalName("HORSEA")] Horsea = 116,
    [pbr::OriginalName("SEADRA")] Seadra = 117,
    [pbr::OriginalName("GOLDEEN")] Goldeen = 118,
    [pbr::OriginalName("SEAKING")] Seaking = 119,
    [pbr::OriginalName("STARYU")] Staryu = 120,
    [pbr::OriginalName("STARMIE")] Starmie = 121,
    [pbr::OriginalName("MR_MIME")] MrMime = 122,
    [pbr::OriginalName("SCYTHER")] Scyther = 123,
    [pbr::OriginalName("JYNX")] Jynx = 124,
    [pbr::OriginalName("ELECTABUZZ")] Electabuzz = 125,
    [pbr::OriginalName("MAGMAR")] Magmar = 126,
    [pbr::OriginalName("PINSIR")] Pinsir = 127,
    [pbr::OriginalName("TAUROS")] Tauros = 128,
    [pbr::OriginalName("MAGIKARP")] Magikarp = 129,
    [pbr::OriginalName("GYARADOS")] Gyarados = 130,
    [pbr::OriginalName("LAPRAS")] Lapras = 131,
    [pbr::OriginalName("DITTO")] Ditto = 132,
    [pbr::OriginalName("EEVEE")] Eevee = 133,
    [pbr::OriginalName("VAPOREON")] Vaporeon = 134,
    [pbr::OriginalName("JOLTEON")] Jolteon = 135,
    [pbr::OriginalName("FLAREON")] Flareon = 136,
    [pbr::OriginalName("PORYGON")] Porygon = 137,
    [pbr::OriginalName("OMANYTE")] Omanyte = 138,
    [pbr::OriginalName("OMASTAR")] Omastar = 139,
    [pbr::OriginalName("KABUTO")] Kabuto = 140,
    [pbr::OriginalName("KABUTOPS")] Kabutops = 141,
    [pbr::OriginalName("AERODACTYL")] Aerodactyl = 142,
    [pbr::OriginalName("SNORLAX")] Snorlax = 143,
    [pbr::OriginalName("ARTICUNO")] Articuno = 144,
    [pbr::OriginalName("ZAPDOS")] Zapdos = 145,
    [pbr::OriginalName("MOLTRES")] Moltres = 146,
    [pbr::OriginalName("DRATINI")] Dratini = 147,
    [pbr::OriginalName("DRAGONAIR")] Dragonair = 148,
    [pbr::OriginalName("DRAGONITE")] Dragonite = 149,
    [pbr::OriginalName("MEWTWO")] Mewtwo = 150,
    [pbr::OriginalName("MEW")] Mew = 151,
    [pbr::OriginalName("CHIKORITA")] Chikorita = 152,
    [pbr::OriginalName("BAYLEEF")] Bayleef = 153,
    [pbr::OriginalName("MEGANIUM")] Meganium = 154,
    [pbr::OriginalName("CYNDAQUIL")] Cyndaquil = 155,
    [pbr::OriginalName("QUILAVA")] Quilava = 156,
    [pbr::OriginalName("TYPHLOSION")] Typhlosion = 157,
    [pbr::OriginalName("TOTODILE")] Totodile = 158,
    [pbr::OriginalName("CROCONAW")] Croconaw = 159,
    [pbr::OriginalName("FERALIGATR")] Feraligatr = 160,
    [pbr::OriginalName("SENTRET")] Sentret = 161,
    [pbr::OriginalName("FURRET")] Furret = 162,
    [pbr::OriginalName("HOOTHOOT")] Hoothoot = 163,
    [pbr::OriginalName("NOCTOWL")] Noctowl = 164,
    [pbr::OriginalName("LEDYBA")] Ledyba = 165,
    [pbr::OriginalName("LEDIAN")] Ledian = 166,
    [pbr::OriginalName("SPINARAK")] Spinarak = 167,
    [pbr::OriginalName("ARIADOS")] Ariados = 168,
    [pbr::OriginalName("CROBAT")] Crobat = 169,
    [pbr::OriginalName("CHINCHOU")] Chinchou = 170,
    [pbr::OriginalName("LANTURN")] Lanturn = 171,
    [pbr::OriginalName("PICHU")] Pichu = 172,
    [pbr::OriginalName("CLEFFA")] Cleffa = 173,
    [pbr::OriginalName("IGGLYBUFF")] Igglybuff = 174,
    [pbr::OriginalName("TOGEPI")] Togepi = 175,
    [pbr::OriginalName("TOGETIC")] Togetic = 176,
    [pbr::OriginalName("NATU")] Natu = 177,
    [pbr::OriginalName("XATU")] Xatu = 178,
    [pbr::OriginalName("MAREEP")] Mareep = 179,
    [pbr::OriginalName("FLAAFFY")] Flaaffy = 180,
    [pbr::OriginalName("AMPHAROS")] Ampharos = 181,
    [pbr::OriginalName("BELLOSSOM")] Bellossom = 182,
    [pbr::OriginalName("MARILL")] Marill = 183,
    [pbr::OriginalName("AZUMARILL")] Azumarill = 184,
    [pbr::OriginalName("SUDOWOODO")] Sudowoodo = 185,
    [pbr::OriginalName("POLITOED")] Politoed = 186,
    [pbr::OriginalName("HOPPIP")] Hoppip = 187,
    [pbr::OriginalName("SKIPLOOM")] Skiploom = 188,
    [pbr::OriginalName("JUMPLUFF")] Jumpluff = 189,
    [pbr::OriginalName("AIPOM")] Aipom = 190,
    [pbr::OriginalName("SUNKERN")] Sunkern = 191,
    [pbr::OriginalName("SUNFLORA")] Sunflora = 192,
    [pbr::OriginalName("YANMA")] Yanma = 193,
    [pbr::OriginalName("WOOPER")] Wooper = 194,
    [pbr::OriginalName("QUAGSIRE")] Quagsire = 195,
    [pbr::OriginalName("ESPEON")] Espeon = 196,
    [pbr::OriginalName("UMBREON")] Umbreon = 197,
    [pbr::OriginalName("MURKROW")] Murkrow = 198,
    [pbr::OriginalName("SLOWKING")] Slowking = 199,
    [pbr::OriginalName("MISDREAVUS")] Misdreavus = 200,
    [pbr::OriginalName("UNOWN")] Unown = 201,
    [pbr::OriginalName("WOBBUFFET")] Wobbuffet = 202,
    [pbr::OriginalName("GIRAFARIG")] Girafarig = 203,
    [pbr::OriginalName("PINECO")] Pineco = 204,
    [pbr::OriginalName("FORRETRESS")] Forretress = 205,
    [pbr::OriginalName("DUNSPARCE")] Dunsparce = 206,
    [pbr::OriginalName("GLIGAR")] Gligar = 207,
    [pbr::OriginalName("STEELIX")] Steelix = 208,
    [pbr::OriginalName("SNUBBULL")] Snubbull = 209,
    [pbr::OriginalName("GRANBULL")] Granbull = 210,
    [pbr::OriginalName("QWILFISH")] Qwilfish = 211,
    [pbr::OriginalName("SCIZOR")] Scizor = 212,
    [pbr::OriginalName("SHUCKLE")] Shuckle = 213,
    [pbr::OriginalName("HERACROSS")] Heracross = 214,
    [pbr::OriginalName("SNEASEL")] Sneasel = 215,
    [pbr::OriginalName("TEDDIURSA")] Teddiursa = 216,
    [pbr::OriginalName("URSARING")] Ursaring = 217,
    [pbr::OriginalName("SLUGMA")] Slugma = 218,
    [pbr::OriginalName("MAGCARGO")] Magcargo = 219,
    [pbr::OriginalName("SWINUB")] Swinub = 220,
    [pbr::OriginalName("PILOSWINE")] Piloswine = 221,
    [pbr::OriginalName("CORSOLA")] Corsola = 222,
    [pbr::OriginalName("REMORAID")] Remoraid = 223,
    [pbr::OriginalName("OCTILLERY")] Octillery = 224,
    [pbr::OriginalName("DELIBIRD")] Delibird = 225,
    [pbr::OriginalName("MANTINE")] Mantine = 226,
    [pbr::OriginalName("SKARMORY")] Skarmory = 227,
    [pbr::OriginalName("HOUNDOUR")] Houndour = 228,
    [pbr::OriginalName("HOUNDOOM")] Houndoom = 229,
    [pbr::OriginalName("KINGDRA")] Kingdra = 230,
    [pbr::OriginalName("PHANPY")] Phanpy = 231,
    [pbr::OriginalName("DONPHAN")] Donphan = 232,
    [pbr::OriginalName("PORYGON2")] Porygon2 = 233,
    [pbr::OriginalName("STANTLER")] Stantler = 234,
    [pbr::OriginalName("SMEARGLE")] Smeargle = 235,
    [pbr::OriginalName("TYROGUE")] Tyrogue = 236,
    [pbr::OriginalName("HITMONTOP")] Hitmontop = 237,
    [pbr::OriginalName("SMOOCHUM")] Smoochum = 238,
    [pbr::OriginalName("ELEKID")] Elekid = 239,
    [pbr::OriginalName("MAGBY")] Magby = 240,
    [pbr::OriginalName("MILTANK")] Miltank = 241,
    [pbr::OriginalName("BLISSEY")] Blissey = 242,
    [pbr::OriginalName("RAIKOU")] Raikou = 243,
    [pbr::OriginalName("ENTEI")] Entei = 244,
    [pbr::OriginalName("SUICUNE")] Suicune = 245,
    [pbr::OriginalName("LARVITAR")] Larvitar = 246,
    [pbr::OriginalName("PUPITAR")] Pupitar = 247,
    [pbr::OriginalName("TYRANITAR")] Tyranitar = 248,
    [pbr::OriginalName("LUGIA")] Lugia = 249,
    [pbr::OriginalName("HO_OH")] HoOh = 250,
    [pbr::OriginalName("CELEBI")] Celebi = 251,
  }

  #endregion

}

#endregion Designer generated code
