using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class AbsenceEditForm : Form
    {
        public AbsenceEditForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelEmploye = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.comboBoxEmploye = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmploye
            // 
            this.labelEmploye.AutoSize = true;
            this.labelEmploye.Location = new System.Drawing.Point(13, 13);
            this.labelEmploye.Name = "labelEmploye";
            this.labelEmploye.Size = new System.Drawing.Size(51, 13);
            this.labelEmploye.TabIndex = 0;
            this.labelEmploye.Text = "Employé";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(13, 39);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(66, 13);
            this.labelDateDebut.TabIndex = 1;
            this.labelDateDebut.Text = "Date Début";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(13, 65);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(49, 13);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date Fin";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(13, 91);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(31, 13);
            this.labelMotif.TabIndex = 3;
            this.labelMotif.Text = "Motif";
            // 
            // comboBoxEmploye
            // 
            this.comboBoxEmploye.FormattingEnabled = true;
            this.comboBoxEmploye.Location = new System.Drawing.Point(85, 10);
            this.comboBoxEmploye.Name = "comboBoxEmploye";
            this.comboBoxEmploye.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmploye.TabIndex = 4;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(85, 36);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDebut.TabIndex = 5;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(85, 62);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFin.TabIndex = 6;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(85, 88);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMotif.TabIndex = 7;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(210, 115);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 8;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // AbsenceEditForm
            // 
            this.ClientSize = new System.Drawing.Size(297, 150);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.comboBoxEmploye);
            this.Controls.Add(this.labelMotif);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.labelDateDebut);
            this.Controls.Add(this.labelEmploye);
            this.Name = "AbsenceEditForm";
            this.Text = "Ajouter/Modifier Absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelEmploye;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.ComboBox comboBoxEmploye;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.Button buttonEnregistrer;
    }
}
