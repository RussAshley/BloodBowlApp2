using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBowlApp
{
    class Teams
    {
        private int ID;
        private String TeamName;
        private String Examples;
        private String STYLE;
        private int ReRoll;
        private Boolean Appo;
        private String SpecialRules;
        private int Tier;

        public Teams(int iD, string teamName, string examples, string sTYLE, int reRoll, bool appo, string specialRules, int tier)
        {
            ID1 = iD;
            TeamName1 = teamName;
            Examples1 = examples;
            STYLE1 = sTYLE;
            ReRoll1 = reRoll;
            Appo1 = appo;
            SpecialRules1 = specialRules;
            Tier1 = tier;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string TeamName1 { get => TeamName; set => TeamName = value; }
        public string Examples1 { get => Examples; set => Examples = value; }
        public string STYLE1 { get => STYLE; set => STYLE = value; }
        public int ReRoll1 { get => ReRoll; set => ReRoll = value; }
        public bool Appo1 { get => Appo; set => Appo = value; }
        public string SpecialRules1 { get => SpecialRules; set => SpecialRules = value; }
        public int Tier1 { get => Tier; set => Tier = value; }
    }


}
