using System;
using System.Windows.Forms;
using MediaTek86.dal;
using MediaTek86.Modele;

namespace MediaTek86.Views
{
    public partial class AjouterPersonnelForm : Form
    {
        public AjouterPersonnelForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(13, 13);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(13, 39);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(13, 65);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(25, 13);
            this.labelTel.TabIndex = 2;
            this.labelTel.Text = "Tel";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(13, 91);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Mail";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(13, 117);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 4;
            this.labelService.Text = "Service";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(72, 10);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(72, 36);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(72, 62);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(200, 20);
            this.textBoxTel.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(72, 88);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(200, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(72, 114);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(200, 21);
            this.comboBoxService.TabIndex = 9;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(197, 141);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 10;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(116, 141);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 11;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // AjouterPersonnelForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Name = "AjouterPersonnelForm";
            this.Text = "Ajouter Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel(
                0, // L'identifiant sera généré par la base de données
                textBoxNom.Text,
                textBoxPrenom.Text,
                textBoxTel.Text,
                textBoxMail.Text,
                int.Parse(comboBoxService.SelectedValue.ToString())
            );

            PersonnelDal personnelDal = new PersonnelDal();
            personnelDal.AddPersonnel(personnel);

            MessageBox.Show("Personnel ajouté avec succès !");
            this.Close();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonRetour;
    }
}
