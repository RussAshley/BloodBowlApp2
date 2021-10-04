
namespace BloodBowlApp
{
    partial class TeamDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(229, 22);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(334, 23);
            this.textBoxTeamName.TabIndex = 0;
            // 
            // TeamDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTeamName);
            this.Name = "TeamDetailsForm";
            this.Text = "TeamDetailsForm";
            this.Load += new System.EventHandler(this.TeamDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeamName;
    }
}