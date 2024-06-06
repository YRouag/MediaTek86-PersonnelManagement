using System;
using System.Data;
using System.Windows.Forms;
using MediaTek86.Controllers;

namespace MediaTek86.Views
{
    public partial class SupprimerAbsenceForm : Form
    {
        private AbsenceController absenceController;

        public SupprimerAbsenceForm()
        {
            InitializeComponent();
            absenceController = new AbsenceController();
            LoadAbsenceList();
        }

        private void InitializeComponent()
        {
            this.listBoxAbsences = new System.Windows.Forms.ListBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAbsences
            // 
            this.listBoxAbsences.FormattingEnabled = true;
            this.listBoxAbsences.Location = new System.Drawing.Point(12, 12);
            this.listBoxAbsences.Name = "listBoxAbsences";
            this.listBoxAbsences.Size = new System.Drawing.Size(260, 199);
            this.listBoxAbsences.TabIndex = 0;
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
            // SupprimerAbsenceForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.listBoxAbsences);
            this.Name = "SupprimerAbsenceForm";
            this.Text = "Supprimer Absence";
            this.ResumeLayout(false);
        }

        private void LoadAbsenceList()
        {
            DataTable absencesTable = absenceController.GetAllAbsences();
            listBoxAbsences.DataSource = absencesTable;
            listBoxAbsences.DisplayMember = "nom"; // Afficher le nom dans la liste
            listBoxAbsences.ValueMember = "idpersonnel"; // Utiliser l'id comme valeur
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxAbsences.SelectedItem != null)
            {
                int selectedPersonnelId = (int)listBoxAbsences.SelectedValue;
                DateTime selectedDateDebut = (DateTime)listBoxAbsences.SelectedValue;
                absenceController.DeleteAbsence(selectedPersonnelId, selectedDateDebut);

                MessageBox.Show("Absence supprimée avec succès !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.");
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.ListBox listBoxAbsences;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRetour;
    }
}
