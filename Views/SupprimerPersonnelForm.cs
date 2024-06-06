using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class SupprimerPersonnelForm : Form
    {
        public SupprimerPersonnelForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(360, 200);
            this.dataGridViewPersonnel.TabIndex = 0;
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
            // SupprimerPersonnelForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.dataGridViewPersonnel);
            this.Name = "SupprimerPersonnelForm";
            this.Text = "Supprimer Personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            // Logic to delete the selected personnel
        }

        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}
