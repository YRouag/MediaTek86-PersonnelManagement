using System;
using System.Data;
using System.Windows.Forms;
using MediaTek86.Controllers;

namespace MediaTek86.Views
{
    public partial class SupprimerPersonnelForm : Form
    {
        private PersonnelController personnelController;

        public SupprimerPersonnelForm()
        {
            InitializeComponent();
            personnelController = new PersonnelController();
            LoadPersonnelList();
        }

        private void InitializeComponent()
        {
            this.listBoxPersonnel = new System.Windows.Forms.ListBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPersonnel
            // 
            this.listBoxPersonnel.FormattingEnabled = true;
            this.listBoxPersonnel.Location = new System.Drawing.Point(12, 12);
            this.listBoxPersonnel.Name = "listBoxPersonnel";
            this.listBoxPersonnel.Size = new System.Drawing.Size(260, 199);
            this.listBoxPersonnel.TabIndex = 0;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(197, 217);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(116, 217);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 2;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // SupprimerPersonnelForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.listBoxPersonnel);
            this.Name = "SupprimerPersonnelForm";
            this.Text = "Supprimer Personnel";
            this.ResumeLayout(false);
        }

        private void LoadPersonnelList()
        {
            DataTable personnelTable = personnelController.GetAllPersonnel();
            listBoxPersonnel.DataSource = personnelTable;
            listBoxPersonnel.DisplayMember = "nom"; // Afficher le nom dans la liste
            listBoxPersonnel.ValueMember = "idpersonnel"; // Utiliser l'id comme valeur
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxPersonnel.SelectedItem != null)
            {
                int selectedPersonnelId = (int)listBoxPersonnel.SelectedValue;
                personnelController.DeletePersonnel(selectedPersonnelId);

                MessageBox.Show("Personnel supprimé avec succès !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.");
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.ListBox listBoxPersonnel;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRetour;
    }
}
