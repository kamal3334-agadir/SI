
namespace GestionAteliers
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Initialize components
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelephone = new System.Windows.Forms.TextBox();
            this.textMotPasse = new System.Windows.Forms.TextBox();

            this.buttonCreerCompte = new System.Windows.Forms.Button();
            this.buttonConnexion = new System.Windows.Forms.LinkLabel();
            this.comboChoix = new System.Windows.Forms.ComboBox();

            // Set up labels
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Nom:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Prénom:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Email:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Téléphone:";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Mot de passe:";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "Type de compte:";

            // Set up textboxes
            this.textNom.Location = new System.Drawing.Point(160, 30);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(200, 20);

            this.textPrenom.Location = new System.Drawing.Point(160, 70);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(200, 20);

            this.textEmail.Location = new System.Drawing.Point(160, 110);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(200, 20);

            this.textTelephone.Location = new System.Drawing.Point(160, 150);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(200, 20);

            this.textMotPasse.Location = new System.Drawing.Point(160, 190);
            this.textMotPasse.Name = "textMotPasse";
            this.textMotPasse.PasswordChar = '*';
            this.textMotPasse.Size = new System.Drawing.Size(200, 20);

            // Set up combobox
            this.comboChoix.Location = new System.Drawing.Point(160, 230);
            this.comboChoix.Name = "comboChoix";
            this.comboChoix.Size = new System.Drawing.Size(200, 20);
            this.comboChoix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Set up buttons
            this.buttonCreerCompte.Location = new System.Drawing.Point(160, 270);
            this.buttonCreerCompte.Name = "buttonCreerCompte";
            this.buttonCreerCompte.Size = new System.Drawing.Size(200, 30);
            this.buttonCreerCompte.Text = "Créer un compte";
            this.buttonCreerCompte.Click += new System.EventHandler(this.ButtonCreerCompte_Click);

            this.buttonConnexion.Location = new System.Drawing.Point(160, 310);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(200, 20);
            this.buttonConnexion.Text = "Tu as déjà un compte? Connecte-toi";
            this.buttonConnexion.Click += new System.EventHandler(this.LinkLabel_Click);

            // Add controls to form
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);

            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelephone);
            this.Controls.Add(this.textMotPasse);

            this.Controls.Add(this.comboChoix);
            this.Controls.Add(this.buttonCreerCompte);
            this.Controls.Add(this.buttonConnexion);

            // Form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Name = "Form1";
            this.Text = "Création de compte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelephone;
        private System.Windows.Forms.TextBox textMotPasse;
        private System.Windows.Forms.Button buttonCreerCompte;
        private System.Windows.Forms.LinkLabel buttonConnexion;
        private System.Windows.Forms.ComboBox comboChoix;
    }
}
