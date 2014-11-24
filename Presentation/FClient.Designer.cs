namespace Presentation
{
    partial class FClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Client = new System.Windows.Forms.ComboBox();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_Societe = new System.Windows.Forms.Label();
            this.lb_Adresse = new System.Windows.Forms.Label();
            this.lb_Ville = new System.Windows.Forms.Label();
            this.lb_Cp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Interroger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(12, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(307, 26);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "Informations sur un CLIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // cb_Client
            // 
            this.cb_Client.FormattingEnabled = true;
            this.cb_Client.Location = new System.Drawing.Point(203, 54);
            this.cb_Client.Name = "cb_Client";
            this.cb_Client.Size = new System.Drawing.Size(133, 21);
            this.cb_Client.TabIndex = 2;
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(14, 111);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(29, 13);
            this.lb_Nom.TabIndex = 3;
            this.lb_Nom.Text = "Nom";
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Location = new System.Drawing.Point(14, 135);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lb_Prenom.TabIndex = 4;
            this.lb_Prenom.Text = "Prénom";
            // 
            // lb_Societe
            // 
            this.lb_Societe.AutoSize = true;
            this.lb_Societe.Location = new System.Drawing.Point(14, 159);
            this.lb_Societe.Name = "lb_Societe";
            this.lb_Societe.Size = new System.Drawing.Size(43, 13);
            this.lb_Societe.TabIndex = 5;
            this.lb_Societe.Text = "Sociéte";
            // 
            // lb_Adresse
            // 
            this.lb_Adresse.AutoSize = true;
            this.lb_Adresse.Location = new System.Drawing.Point(14, 187);
            this.lb_Adresse.Name = "lb_Adresse";
            this.lb_Adresse.Size = new System.Drawing.Size(45, 13);
            this.lb_Adresse.TabIndex = 6;
            this.lb_Adresse.Text = "Adresse";
            // 
            // lb_Ville
            // 
            this.lb_Ville.AutoSize = true;
            this.lb_Ville.Location = new System.Drawing.Point(14, 217);
            this.lb_Ville.Name = "lb_Ville";
            this.lb_Ville.Size = new System.Drawing.Size(26, 13);
            this.lb_Ville.TabIndex = 7;
            this.lb_Ville.Text = "Ville";
            // 
            // lb_Cp
            // 
            this.lb_Cp.AutoSize = true;
            this.lb_Cp.Location = new System.Drawing.Point(14, 243);
            this.lb_Cp.Name = "lb_Cp";
            this.lb_Cp.Size = new System.Drawing.Size(63, 13);
            this.lb_Cp.TabIndex = 8;
            this.lb_Cp.Text = "Code postal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Interroger
            // 
            this.bt_Interroger.Location = new System.Drawing.Point(375, 47);
            this.bt_Interroger.Name = "bt_Interroger";
            this.bt_Interroger.Size = new System.Drawing.Size(75, 23);
            this.bt_Interroger.TabIndex = 9;
            this.bt_Interroger.Text = "Interroger";
            this.bt_Interroger.UseVisualStyleBackColor = true;
            this.bt_Interroger.Click += new System.EventHandler(this.bt_Interroger_Click_1);
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 275);
            this.Controls.Add(this.bt_Interroger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Cp);
            this.Controls.Add(this.lb_Ville);
            this.Controls.Add(this.lb_Adresse);
            this.Controls.Add(this.lb_Societe);
            this.Controls.Add(this.lb_Prenom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.cb_Client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_title);
            this.Name = "FClient";
            this.Text = "FClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Client;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.Label lb_Prenom;
        private System.Windows.Forms.Label lb_Societe;
        private System.Windows.Forms.Label lb_Adresse;
        private System.Windows.Forms.Label lb_Ville;
        private System.Windows.Forms.Label lb_Cp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Interroger;
    }
}