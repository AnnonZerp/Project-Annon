using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRPC_Client;
using XDevkit;
namespace Project_Annon_V1
{
  internal class Hax
    {
        public class AW
        {
            public static uint AdvancedUAV = 0x826352a8;
            public static uint BlindEyeCheck = 0x825cd690;
            public static uint Bodies = 0x8260659c;
            public static uint Camos = 0x6f75;
            public static uint CrossHairs1 = 0x826476a0;
            public static uint CrossHairs2 = (CrossHairs1 + 4);
            public static uint ESP1 = 0x8262df68;
            public static uint ESP2 = 0x8262e640;
            public static uint ESP3 = 0x826347c0;
            public static uint g_Entity = 0x838ad900;
            public static uint GreenBodies = 0x8228c343;
            public static uint GreenBodiesCheck = 0x822a39db;
            public static uint GTEditor = 0x843decb4;
            public static uint NoRecoil1 = 0x82648cec;
            public static uint NoRecoil2 = (NoRecoil1 + 4);
            public static uint NoSpread = 0x8264769c;
            public static uint NoSway = 0x82640418;
            public static uint NoSway1 = 0x826404d0;
            public static uint Playerstate = 0x83807f80;
            public static uint Redboxes = 0x8262fb0c;
            public static uint StatEntry = 0x83a6c144;
            public static uint SV_GSSC = 0x823e5bf8;
        }

        public class AWBytes
        {
            public static byte[] AdvancedUAVOff = new byte[] { 0x55, 0x19, 0xef, 0xfe };
            public static byte[] AdvancedUAVOn = new byte[] { 0x39, 0x40, 0, 1 };
            public static byte[] BlindEyeCheckOff;
            public static byte[] BodiesOff;
            public static byte[] BodiesOn;
            public static byte[] CrossHairs1Off;
            public static byte[] CrossHairs2Off;
            public static byte[] CrossHairs2On;
            public static byte[] ESP1Off;
            public static byte[] ESP2Off;
            public static byte[] ESP3Off;
            public static byte[] NoRecoil1Off;
            public static byte[] NoRecoil1On;
            public static byte[] NoRecoil2Off;
            public static byte[] NoRecoil2On;
            public static byte[] RedboxesOff;

            static AWBytes()
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                NoRecoil1On = buffer;
                NoRecoil1Off = new byte[] { 0x41, 130, 0, 0x20 };
                byte[] buffer1 = new byte[4];
                buffer1[0] = 0x39;
                buffer1[1] = 0x20;
                NoRecoil2On = buffer1;
                NoRecoil2Off = new byte[] { 0x89, 0x5b, 0x18, 0x69 };
                BodiesOff = new byte[] { 0x7f, 0xc6, 0xf3, 120 };
                RedboxesOff = new byte[] { 0x41, 130, 0, 0x1c };
                BlindEyeCheckOff = new byte[] { 0x40, 130, 1, 0x94 };
                BodiesOn = new byte[] { 0x38, 0xc0, 0xff, 0xff };
                ESP1Off = new byte[] { 0x41, 130, 0, 40 };
                ESP2Off = new byte[] { 0x41, 0x9a, 0, 8 };
                ESP3Off = new byte[] { 0x41, 0x98, 0, 0xe4 };
                byte[] buffer2 = new byte[4];
                buffer2[0] = 0x39;
                buffer2[1] = 0x60;
                CrossHairs2On = buffer2;
                CrossHairs2Off = new byte[] { 0xe9, 0x7f, 5, 0xc2 };
                CrossHairs1Off = new byte[] { 0x40, 0x9a, 0, 0x20 };
            }
        }

        public class BO1
        {
            public static uint Bodies = 0x821dfef8;
        }

        public class BO1Bytes
        {
            public static byte[] BodiesOff = new byte[] { 0x7f, 0xa6, 0xeb, 120 };
            public static byte[] BodiesOn = new byte[] { 0x38, 0xc0, 0xff, 3 };
        }

        public class BO2
        {
            public static uint Bodies = 0x821fc04c;
            public static uint ClanTagCheck = 0x82283ca0;
            public static uint ClassCheck = 0x82283c6c;
            public static uint PerkCheck = 0x821f608c;
            public static uint Playerstate = 0x83556ebc;
            public static uint RedBoxes = 0x821f5b7f;
            public static uint Stats = 0x843489c8;
            public static uint Vsat = 0x821b8fd3;
        }

        public class BO2Bytes
        {
            public static byte[] BodiesOff = new byte[] { 0x7f, 0xa6, 0xeb, 120 };
            public static byte[] BodiesOn = new byte[] { 0x34, 0xc0, 0xff, 0xff };
            public static byte[] PerkCheckOff = new byte[] { 0x41, 0x99, 0, 200 };
            public static byte[] RedboxesOff = new byte[1];
            public static byte[] RedBoxesOn = new byte[] { 1 };
            public static byte[] VsatOff = new byte[1];
            public static byte[] VsatON = new byte[] { 1 };
        }

        public class Functions
        {
            public static byte[] B;
            public static byte[] Nop;

            static Functions()
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                Nop = buffer;
                byte[] buffer1 = new byte[2];
                buffer1[0] = 0x48;
                B = buffer1;
            }
        }

        public class Ghosts
        {
            public static uint AdvancedUAV1 = 0x8226539b;
            public static uint AdvancedUAV2 = 0x82265793;
            public static uint AdvancedUAV3 = 0x822657ff;
            public static uint BlindEyeCheck = 0x822c6370;
            public static uint Bodies = 0x82290494;
            public static uint cbuf_AddText = 0x8244c738;
            public static uint ClanTagCheck = 0x8253cbb8;
            public static uint ClassCheck = 0x8253cb44;
            public static uint g_entity = 0x8337b680;
            public static uint GhostStats = 0x835838cc;
            public static uint GTEditor = 0x83f0a35c;
            public static uint NoRecoil = 0x822c9344;
            public static uint PlayerState = 0x83301980;
            public static uint Redboxes = 0x8226d2b4;
            public static uint SV_GSSC = 0x824d95e8;
        }

        public class GhostsBytes
        {
            public static byte[] AdvancedUAVOff = new byte[1];
            public static byte[] AdvancedUAVOn = new byte[] { 1 };
            public static byte[] BodiesOff = new byte[] { 0x7f, 70, 0xd3, 120 };
            public static byte[] BodiesOn = new byte[] { 0x38, 0xc0, 0xff, 0xff };
            public static byte[] BoxesOff;
            public static byte[] Bypass;
            public static byte[] Bypass2;
            public static byte[] Nop;
            public static byte[] PerkOff;

            static GhostsBytes()
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                Nop = buffer;
                BoxesOff = new byte[] { 0x41, 0x9a, 0, 12 };
                PerkOff = new byte[] { 0x40, 0x9a, 0, 0x84 };
                byte[] buffer2 = new byte[4];
                buffer2[0] = 0x48;
                buffer2[3] = 0x20;
                Bypass = buffer2;
                byte[] buffer3 = new byte[4];
                buffer3[0] = 0x38;
                buffer3[1] = 160;
                Bypass2 = buffer3;
            }
        }

     

                public enum Stats : uint
                {
                    ACCURACY = 0x835838f5,
                    ASSISTS = 0x835838f9,
                    DEATHS = 0x83583929,
                    EX_KILLS = 0x8358b002,
                    EX_LEVEL_MAX = 0x8358afeb,
                    EX_MISSIONS_COMPLETED = 0x8358b00a,
                    EX_PRESTIGE = 0x8358aff2,
                    EX_REVIVES = 0x8358afe2,
                    EX_SCORE = 0x8358af4c,
                    EX_TEETH = 0x8358bbbe,
                    EX_XP = 0x8358afea,
                    GAMES_PLAYED = 0x83583941,
                    HEADSHOTS = 0x83583945,
                    HITS = 0x83583949,
                    KILLS = 0x83583951,
                    KILLS_DEATHS_RATIO = 0x8358394d,
                    KILLSTREAK = 0x83583955,
                    LOSSES = 0x83583959,
                    MISSES = 0x8358395e,
                    PRESTIGE = 0x835887f4,
                    RANK = 0x8358393e,
                    RANK_XP = 0x83583966,
                    SCORE = 0x8358397a,
                    SQUAD_MEMBER_LEVEL = 0x83583e3c,
                    SQUAD_MEMBER_XP = 0x83583bfa,
                    SQUAD_MEMBERS = 0x83584590,
                    SQUAD_POINTS = 0x835884fc,
                    STATS_DELTA = 0x835838cc,
                    SUICIDES = 0x8358397e,
                    TIES = 0x83583986,
                    TIME_PLAYED = 0x83583996,
                    TOTAL_SHOTS = 0x8358399a,
                    WIN_LOSS_RATIO = 0x8358399e,
                    WINS = 0x835839a2,
                    WINSTREAK = 0x83583925,
                    XP = 0x835848b2
                }
            }
        }

        public class MW2
        {
            public static uint g_Entity = 0x82f03600;
            public static uint Names1 = 0x820f2fa0;
            public static uint Names2 = 0x820f2fd4;
            public static uint Names3 = 0x820f3020;
            public static uint Playerstate = 0x830cbf80;
            public static uint statEntry = 0x831a05c0;
        }

        public class MW2Bytes
        {
            public static byte[] NamesOff1;
            public static byte[] NamesOff2;
            public static byte[] NamesOff3;
            public static byte[] Nop;

            static MW2Bytes()
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                Nop = buffer;
                NamesOff1 = new byte[] { 0x41, 0x9a, 1, 4 };
                NamesOff2 = new byte[] { 0x41, 0x9a, 0, 0xd0 };
                NamesOff3 = new byte[] { 0x41, 0x9a, 0, 0x20 };
            }
        }

        public class MW3sTATS
        {
            public static uint Accuracy = 0x3a994;
            public static uint Assits = 0x3a94c;
            public static uint Bodies1 = 0x821350f8;
            public static uint Bodies2 = 0x82135104;
            public static uint Boxes = 0x821154a4;
            public static uint Deaths = 0x3a944;
            public static uint Headshots = 0x3a950;
            public static uint Hits = 0x3a988;
            public static uint Kills = 0x3a93c;
            public static uint Killstreak = 0x3a940;
            public static uint Losses = 0x3a974;
            public static uint Misses = 0x3a98c;
            public static uint PerkCheck = 0x8215dbd0;
            public static uint Playerstate = 0x82f99580;
            public static uint Prestige = 0x3a90c;
            public static uint PrestigeTokens = 0x3c76b;
            public static uint Score = 0x3a914;
            public static uint StatEntry = 0x8306c460;
            public static uint Ties = 0x3a978;
            public static uint Time1 = 0x3a95e;
            public static uint Time2 = 0x3a966;
            public static uint Wins = 0x3a970;
            public static uint Winstreak = 0x3a97c;
            public static uint XP = 0x3ab2c;
            public static uint XPTime = 0x3c76b;
            public static uint XPWeapon = 0x3c7c9;
        }

        public class MW3Bytes
        {
            public static byte[] BodiesOff = new byte[] { 0x38, 0xc0, 1, 4 };
            public static byte[] BodiesOn = new byte[] { 0x38, 0xc0, 0, 7 };
        }
    


