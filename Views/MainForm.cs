using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherAbsencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAbsenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierAbsenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerAbsenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem,
            this.absencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterPersonnelToolStripMenuItem,
            this.modifierPersonnelToolStripMenuItem,
            this.supprimerPersonnelToolStripMenuItem});
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.personnelToolStripMenuItem.Text = "Personnel";
            // 
            // ajouterPersonnelToolStripMenuItem
            // 
            this.ajouterPersonnelToolStripMenuItem.Name = "ajouterPersonnelToolStripMenuItem";
            this.ajouterPersonnelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterPersonnelToolStripMenuItem.Text = "Ajouter";
            this.ajouterPersonnelToolStripMenuItem.Click += new System.EventHandler(this.ajouterPersonnelToolStripMenuItem_Click);
            // 
            // modifierPersonnelToolStripMenuItem
            // 
            this.modifierPersonnelToolStripMenuItem.Name = "modifierPersonnelToolStripMenuItem";
            this.modifierPersonnelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierPersonnelToolStripMenuItem.Text = "Modifier";
            this.modifierPersonnelToolStripMenuItem.Click += new System.EventHandler(this.modifierPersonnelToolStripMenuItem_Click);
            // 
            // supprimerPersonnelToolStripMenuItem
            // 
            this.supprimerPersonnelToolStripMenuItem.Name = "supprimerPersonnelToolStripMenuItem";
            this.supprimerPersonnelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerPersonnelToolStripMenuItem.Text = "Supprimer";
            this.supprimerPersonnelToolStripMenuItem.Click += new System.EventHandler(this.supprimerPersonnelToolStripMenuItem_Click);
            // 
            // absencesToolStripMenuItem
            // 
            this.absencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherAbsencesToolStripMenuItem,
            this.ajouterAbsenceToolStripMenuItem,
            this.modifierAbsenceToolStripMenuItem,
            this.supprimerAbsenceToolStripMenuItem});
            this.absencesToolStripMenuItem.Name = "absencesToolStripMenuItem";
            this.absencesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.absencesToolStripMenuItem.Text = "Absences";
            // 
            // afficherAbsencesToolStripMenuItem
            // 
            this.afficherAbsencesToolStripMenuItem.Name = "afficherAbsencesToolStripMenuItem";
            this.afficherAbsencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherAbsencesToolStripMenuItem.Text = "Afficher";
            this.afficherAbsencesToolStripMenuItem.Click += new System.EventHandler(this.afficherAbsencesToolStripMenuItem_Click);
            // 
            // ajouterAbsenceToolStripMenuItem
            // 
            this.ajouterAbsenceToolStripMenuItem.Name = "ajouterAbsenceToolStripMenuItem";
            this.ajouterAbsenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterAbsenceToolStripMenuItem.Text = "Ajouter";
            this.ajouterAbsenceToolStripMenuItem.Click += new System.EventHandler(this.ajouterAbsenceToolStripMenu
            // 
            // ajouterAbsenceToolStripMenuItem
            // 
            this.ajouterAbsenceToolStripMenuItem.Name = "ajouterAbsenceToolStripMenuItem";
            this.ajouterAbsenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterAbsenceToolStripMenuItem.Text = "Ajouter";
            this.ajouterAbsenceToolStripMenuItem.Click += new System.EventHandler(this.ajouterAbsenceToolStripMenuItem_Click);
            // 
            // modifierAbsenceToolStripMenuItem
            // 
            this.modifierAbsenceToolStripMenuItem.Name = "modifierAbsenceToolStripMenuItem";
            this.modifierAbsenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifierAbsenceToolStripMenuItem.Text = "Modifier";
            this.modifierAbsenceToolStripMenuItem.Click += new System.EventHandler(this.modifierAbsenceToolStripMenuItem_Click);
            // 
            // supprimerAbsenceToolStripMenuItem
            // 
            this.supprimerAbsenceToolStripMenuItem.Name = "supprimerAbsenceToolStripMenuItem";
            this.supprimerAbsenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerAbsenceToolStripMenuItem.Text = "Supprimer";
            this.supprimerAbsenceToolStripMenuItem.Click += new System.EventHandler(this.supprimerAbsenceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MediaTek86 - Gestion du Personnel et des Absences";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        private void ajouterPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire pour ajouter un personnel
            PersonnelForm personnelForm = new PersonnelForm();
            personnelForm.Text = "Ajouter Personnel";
            personnelForm.ShowDialog();
        }

        private void modifierPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire pour modifier un personnel
            // Pour la modification, il peut être nécessaire de passer des informations supplémentaires pour identifier le personnel
            PersonnelForm personnelForm = new PersonnelForm();
            personnelForm.Text = "Modifier Personnel";
            personnelForm.ShowDialog();
        }

        private void supprimerPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir un formulaire ou une boîte de dialogue pour supprimer un personnel
            SupprimerPersonnelForm supprimerPersonnelForm = new SupprimerPersonnelForm();
            supprimerPersonnelForm.ShowDialog();
        }

        private void afficherAbsencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire pour afficher les absences
            AbsenceForm absenceForm = new AbsenceForm();
            absenceForm.ShowDialog();
        }

        private void ajouterAbsenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire pour ajouter une absence
            AbsenceEditForm absenceEditForm = new AbsenceEditForm();
            absenceEditForm.Text = "Ajouter Absence";
            absenceEditForm.ShowDialog();
        }

        private void modifierAbsenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire pour modifier une absence
            // Pour la modification, il peut être nécessaire de passer des informations supplémentaires pour identifier l'absence
            AbsenceEditForm absenceEditForm = new AbsenceEditForm();
            absenceEditForm.Text = "Modifier Absence";
            absenceEditForm.ShowDialog();
        }

        private void supprimerAbsenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvrir un formulaire ou une boîte de dialogue pour supprimer une absence
            SupprimerAbsenceForm supprimerAbsenceForm = new SupprimerAbsenceForm();
            supprimerAbsenceForm.ShowDialog();
        }


            private System.Windows.Forms.MenuStrip menuStrip1;
            private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem ajouterPersonnelToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem modifierPersonnelToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem supprimerPersonnelToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem absencesToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem afficherAbsencesToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem ajouterAbsenceToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem modifierAbsenceToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem supprimerAbsenceToolStripMenuItem;
            }
            }
