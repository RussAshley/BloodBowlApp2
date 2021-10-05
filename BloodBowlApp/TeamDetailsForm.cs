using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BloodBowlApp
{

    public partial class TeamDetailsForm : Form
    {
        static TeamDataAccess tda = new TeamDataAccess("Data Source=BloodBowlConcept.db");
        Teams team;
        int index = 0;
        string teamName;

        public TeamDetailsForm()
        {
            InitializeComponent();
        }

        public TeamDetailsForm(string teamName)
        {
            InitializeComponent();
            this.teamName = teamName;
           team = tda.ReadTeamData(teamName);
            textBoxTeamName.Text = team.TeamName1;
            textBox1FamousTeams.Text = team.Examples1;
            textBoxStyle.Text = team.STYLE1;
            textBoxReRoll.Text = team.ReRoll1.ToString();
            textBoxSpecialRules.Text = team.SpecialRules1;
            textBox4Appo.Text = team.Appo1;
            textBoxTier.Text = team.Tier1.ToString();

        }

        private void TeamDetailsForm_Load(object sender, EventArgs e)
        {

        }


    }
}
