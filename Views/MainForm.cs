using System;
using System.Data;
using System.Windows.Forms;
using MediaTek86.Controllers;
using MediaTek86.Modele;

namespace MediaTek86.Views
{
    public partial class MainForm : Form
    {
        private PersonnelController personnelController;

        public MainForm()
        {
            InitializeComponent();
            personnelController = new PersonnelController();
            LoadPersonnelData();
        }

        private void InitializeComponent()
        {
            this.btnAfficherPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnAfficherAbsences = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficherPersonnel
            // 
            this.btnAfficherPersonnel.Location = new System.Drawing.Point(50, 30);
            this.btnAfficherPersonnel.Name = "btnAfficherPersonnel";
            this.btnAfficherPersonnel.Size = new System.Drawing.Size(200, 30);
            this.btnAfficherPersonnel.TabIndex = 0;
            this.btnAfficherPersonnel.Text = "Afficher Personnel";
            this.btnAfficherPersonnel.UseVisualStyleBackColor = true;
            this.btnAfficherPersonnel.Click += new System.EventHandler(this.btnAfficherPersonnel_Click);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(50, 70);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(200, 30);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "Ajouter Personnel";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(50, 110);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(200, 30);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "Modifier Personnel";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(50, 150);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "Supprimer Personnel";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnAfficherAbsences
            // 
            this.btnAfficherAbsences.Location = new System.Drawing.Point(50, 190);
            this.btnAfficherAbsences.Name = "btnAfficherAbsences";
            this.btnAfficherAbsences.Size = new System.Drawing.Size(200, 30);
            this.btnAfficherAbsences.TabIndex = 4;
            this.btnAfficherAbsences.Text = "Afficher Absences";
            this.btnAfficherAbsences.UseVisualStyleBackColor = true;
            this.btnAfficherAbsences.Click += new System.EventHandler(this.btnAfficherAbsences_Click);
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(50, 230);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(200, 30);
            this.btnAjouterAbsence.TabIndex = 5;
            this.btnAjouterAbsence.Text = "Ajouter Absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            this.btnAjouterAbsence.Click += new System.EventHandler(this.btnAjouterAbsence_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(50, 270);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(200, 30);
            this.btnModifierAbsence.TabIndex = 6;
            this.btnModifierAbsence.Text = "Modifier Absence";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(50, 310);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimerAbsence.TabIndex = 7;
            this.btnSupprimerAbsence.Text = "Supprimer Absence";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(50, 350);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(200, 30);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour à la Connexion";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(270, 30);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(500, 350);
            this.dataGridViewPersonnel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.btnAfficherAbsences);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.btnAfficherPersonnel);
            this.Name = "MainForm";
            this.Text = "MediaTek86 - Gestion du Personnel et des Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);
        }

        private void LoadPersonnelData()
        {
            DataTable personnelTable = personnelController.GetAllPersonnel();
            dataGridViewPersonnel.DataSource = personnelTable;
            dataGridViewPersonnel.Columns["idpersonnel"].Visible = false; // Masquer la colonne ID
        }

        private void btnAfficherPersonnel_Click(object sender, EventArgs e)
        {
            LoadPersonnelData();
        }

        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            AjouterPersonnelForm ajouterPersonnelForm = new AjouterPersonnelForm();
            ajouterPersonnelForm.ShowDialog();
            LoadPersonnelData();
        }

        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonnel.SelectedRows.Count > 0)
            {
                int selectedPersonnelId = (int)dataGridViewPersonnel.SelectedRows[0].Cells["idpersonnel"].Value;
                string nom = dataGridViewPersonnel.SelectedRows[0].Cells["nom"].Value.ToString();
                string prenom = dataGridViewPersonnel.SelectedRows[0].Cells["prenom"].Value.ToString();
                string tel = dataGridViewPersonnel.SelectedRows[0].Cells["tel"].Value.ToString();
                string mail = dataGridViewPersonnel.SelectedRows[0].Cells["mail"].Value.ToString();
                int idService = (int)dataGridViewPersonnel.SelectedRows[0].Cells["idservice"].Value;

                Personnel selectedPersonnel = new Personnel(selectedPersonnelId, nom, prenom, tel, mail, idService);
                ModifierPersonnelForm modifierPersonnelForm = new ModifierPersonnelForm(selectedPersonnel);
                modifierPersonnelForm.ShowDialog();
                LoadPersonnelData();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.");
            }
        }

        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            SupprimerPersonnelForm supprimerPersonnelForm = new SupprimerPersonnelForm();
            supprimerPersonnelForm.ShowDialog();
            LoadPersonnelData();
        }

        private void btnAfficherAbsences_Click(object sender, EventArgs e)
        {
            AfficherAbsenceForm afficherAbsenceForm = new AfficherAbsenceForm();
            afficherAbsenceForm.ShowDialog();
        }

        private void btnAjouterAbsence_Click(object sender, EventArgs e)
        {
            AjouterAbsenceForm ajouterAbsenceForm = new AjouterAbsenceForm();
            ajouterAbsenceForm.ShowDialog();
        }

        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            ModifierAbsenceForm modifierAbsenceForm = new ModifierAbsenceForm();
            modifierAbsenceForm.ShowDialog();
        }

        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            SupprimerAbsenceForm supprimerAbsenceForm = new SupprimerAbsenceForm();
            supprimerAbsenceForm.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.Button btnAfficherPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnAfficherAbsences;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
    }
}
