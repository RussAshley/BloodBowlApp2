using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBowlApp
{
    class Positions
    {
        private int ID;
        private int teamdetailsID;
        private int qty;
        private String position;
        private int cost;
        private int Ma;
        private int st;
        private int ag;
        private int pa;
        private int av;
        private String skills;
        private String primary;
        private String secondary;

        public Positions(int iD, int teamdetailsID, int qty, string position, int cost, int ma, int st, int ag, int pa, int av, string skills, string primary, string secondary)
        {
            ID1 = iD;
            this.TeamdetailsID = teamdetailsID;
            this.Qty = qty;
            this.Position = position;
            this.Cost = cost;
            Ma1 = ma;
            this.St = st;
            this.Ag = ag;
            this.Pa = pa;
            this.Av = av;
            this.Skills = skills;
            this.Primary = primary;
            this.Secondary = secondary;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int TeamdetailsID { get => teamdetailsID; set => teamdetailsID = value; }
        public int Qty { get => qty; set => qty = value; }
        public string Position { get => position; set => position = value; }
        public int Cost { get => cost; set => cost = value; }
        public int Ma1 { get => Ma; set => Ma = value; }
        public int St { get => st; set => st = value; }
        public int Ag { get => ag; set => ag = value; }
        public int Pa { get => pa; set => pa = value; }
        public int Av { get => av; set => av = value; }
        public string Skills { get => skills; set => skills = value; }
        public string Primary { get => primary; set => primary = value; }
        public string Secondary { get => secondary; set => secondary = value; }


        public string DisplayAsAString()
        {
            return $"{qty} {position}";
        }
    }


}
