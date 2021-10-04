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
        Teams[] teamArray;
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
        }

        private void TeamDetailsForm_Load(object sender, EventArgs e)
        {

        }


    }
}
