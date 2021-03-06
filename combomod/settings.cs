﻿using System;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using Modding;
using UnityEngine;

namespace combomod
{
    public static class globals
    {
        public const int SETTINGS_VER = 1;
        public const string MOD_VERSION_STRING = "1.0";
        public const string SETTINGS_FILE_APPEND = "combos.settings.json";
        public const string MOD_NAME_FULL = "Glorious Combos";
        public const int LOAD_PRIORITY = 130;
        
        // For other mods...
        public static readonly int MOD_VERSION_INT = 5;

        public const string DO_NOT_MODIFY =
            "DO NOT MODIFY ANY STRING VALUES. THEY ARE USED TO STORE COMPLETION. YOU MAY LOSE YOUR RECORDS.";

        public static settings fileSettings;

        public enum bestclear
        {
            None,
            ThreeStar,
            FourStar,
            FiveStar,
            FullCombo
        }

        public enum numbindings
        {
            None,
            One,
            Two,
            Three,
            Four
        }

        public struct gm_challenge_results
        {
            public bestclear bestClear;
            public numbindings numBind;
        }
        
        public static readonly gm_challenge_results[] ALL_RESULTS = new gm_challenge_results[5];
        
        
        public enum gm1_bestclear
        {
            None = 'h',
            ThreeStar = 'A',
            FourStar = 'B',
            FiveStar = 'C',
            FullCombo = 'D'
        }
        
        public enum gm1_numbindings
        {
            None = 'h',
            One = 'o',
            Two = 'p',
            Three = 'q',
            Four = 'r'
        }
        
        public enum gm2_bestclear
        {
            None = 'h',
            ThreeStar = 'x',
            FourStar = 'y',
            FiveStar = 'z',
            FullCombo = 'a'
        }
        
        public enum gm2_numbindings
        {
            None = 'h',
            One = 'd',
            Two = 'e',
            Three = 'f',
            Four = 'g'
        }
        
        public enum gm3_bestclear
        {
            None = 'h',
            ThreeStar = 'l',
            FourStar = 'm',
            FiveStar = 'n',
            FullCombo = 'o'
        }
        
        public enum gm3_numbindings
        {
            None = 'h',
            One = 'k',
            Two = 'l',
            Three = 'm',
            Four = 'n'
        }
        
        public enum gm4_bestclear
        {
            None = 'h',
            ThreeStar = 'c',
            FourStar = 'd',
            FiveStar = 'e',
            FullCombo = 'f'
        }
        
        public enum gm4_numbindings
        {
            None = 'h',
            One = 'l',
            Two = 'm',
            Three = 'n',
            Four = 'o'
        }
        
        public enum gm5_bestclear
        {
            None = 'h',
            ThreeStar = 'o',
            FourStar = 'p',
            FiveStar = 'q',
            FullCombo = 'r'
        }
        
        public enum gm5_numbindings
        {
            None = 'h',
            One = 'z',
            Two = 'a',
            Three = 'b',
            Four = 'c'
        }
    }
    
    public class settings : IModSettings
    {
        public void reset()
        {
            BoolValues.Clear();
            IntValues.Clear();
            FloatValues.Clear();
            StringValues.Clear();

            settingsVersion = globals.SETTINGS_VER;

            onlyEnableInGodmaster = false;
            comboAffectsPlayerDamage = true;
            comboLossOnHit = true;

            comboDrainRate = 1.0f;
            damageModifier = 0.4f;

            comboIncrementHits = 8;
            tenXcomboIncrementHits = 35;

            doNotModifyAnyStringValues = globals.DO_NOT_MODIFY;
            string unset = char.ToString((char) globals.gm1_bestclear.None) +
                           char.ToString((char) globals.gm1_numbindings.None);
            unset = char.ToString(cheat_detect.checksumString(unset)) + unset;
            soulless1 = unset;
            soulless2 = unset;
            soulless3 = unset;
            soulless4 = unset;
            soulless5 = unset;
        }
        
        
        public int settingsVersion { get => GetInt();
            private set => SetInt(value); }
        
        public int comboIncrementHits { get => GetInt(); private set => SetInt(value); }
        public int tenXcomboIncrementHits { get => GetInt(); private set => SetInt(value); }
        
        
        public bool onlyEnableInGodmaster { get => GetBool(); private set => SetBool(value); }
        public bool comboAffectsPlayerDamage { get => GetBool(); private set => SetBool(value); }
        public bool comboLossOnHit { get => GetBool(); private set => SetBool(value); }
        
        public float comboDrainRate { get => GetFloat(); private set => SetFloat(value); }
        public float damageModifier { get => GetFloat(); private set => SetFloat(value); }
        
        public string doNotModifyAnyStringValues { get => GetString(); private set => SetString(value); }
        public string soulless1 { get => GetString(); set => SetString(value); }
        public string soulless2 { get => GetString(); set => SetString(value); }
        public string soulless3 { get => GetString(); set => SetString(value); }
        public string soulless4 { get => GetString(); set => SetString(value); }
        public string soulless5 { get => GetString(); set => SetString(value); }

    }
}