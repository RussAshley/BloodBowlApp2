using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBowlApp
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonBlackOrcs_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonBlackOrcs.Text);
            teamDetailsForm.Show();
            // need to index (?) Black orcs in db and pass onto next form??
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonChaosChosen_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonChaosChosen.Text);
            teamDetailsForm.Show();
        }

        private void Dwarfs_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(Dwarfs.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonChaosRenegades_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonChaosRenegades.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonLizardmen_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonLizardmen.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonNurgle_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonNurgle.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonOrc_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonOrc.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonUnderworldDenizens_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonUnderworldDenizens.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonDarkElves_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonDarkElves.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonElvenUnion_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonElvenUnion.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonSkaven_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonSkaven.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonWoodElves_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonWoodElves.Text);
            teamDetailsForm.Show();
        }

        

        private void radioButtonHumans_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonHumans.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonShamblingUndead_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonShamblingUndead.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonImperialNobility_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonImperialNobility.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonNecromaticHorrors_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonNecromaticHorrors.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonOldWorldAlliance_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonOldWorldAlliance.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonHalflings_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonHalflings.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonOgres_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonOgres.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonsnotlings_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonsnotlings.Text);
            teamDetailsForm.Show();
        }

        private void radioButtonGoblins_Click(object sender, EventArgs e)
        {
            TeamDetailsForm teamDetailsForm = new TeamDetailsForm(radioButtonGoblins.Text);
            teamDetailsForm.Show();
        }
    }
}
