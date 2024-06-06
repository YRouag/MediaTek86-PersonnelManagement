using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class SupprimerAbsenceForm : Form
    {
        public SupprimerAbsenceForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewAbsences = new System.Windows.Forms.DataGridView();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbsences
            // 
            this.dataGridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsences.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAbsences.Name = "dataGridViewAbsences";
            this.dataGridViewAbsences.Size = new System.Drawing.Size(360, 200);
            this.dataGridViewAbsences.TabIndex = 0;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(297, 218);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // SupprimerAbsenceForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.dataGridViewAbsences);
            this.Name = "SupprimerAbsenceForm";
            this.Text = "Supprimer Absence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // Logic to delete the selected absence
        }

        private System.Windows.Forms.DataGridView dataGridViewAbsences;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}
