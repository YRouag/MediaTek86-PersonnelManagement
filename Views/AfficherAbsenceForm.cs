using System;
using System.Windows.Forms;

namespace MediaTek86.Views
{
    public partial class AfficherAbsenceForm : Form
    {
        public AfficherAbsenceForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(697, 415);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 1;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // AfficherAbsenceForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AfficherAbsenceForm";
            this.Text = "Afficher Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRetour;
    }
}
