namespace QMag.Pages.Stock
{
	partial class Ajouter
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.flatLabelTitre = new QMag.Controls.FlatLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.flatButtonAjouter = new QMag.Controls.Buttons.FlatButton();
			this.flatTextBoxPrixVente = new QMag.Controls.FlatTextBox();
			this.flatTextBoxPrixAchat = new QMag.Controls.FlatTextBox();
			this.flatTextBoxQuantiteMin = new QMag.Controls.FlatTextBox();
			this.flatTextBoxQuantiteActuelle = new QMag.Controls.FlatTextBox();
			this.flatTextBoxNom = new QMag.Controls.FlatTextBox();
			this.flatLabelPrixAchat = new QMag.Controls.FlatLabel();
			this.flatLabelPrixVente = new QMag.Controls.FlatLabel();
			this.flatLabelQuantiteMin = new QMag.Controls.FlatLabel();
			this.flatLabelQuantiteActuelle = new QMag.Controls.FlatLabel();
			this.flatLabelNom = new QMag.Controls.FlatLabel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panel1.Controls.Add(this.flatLabelTitre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.MaximumSize = new System.Drawing.Size(0, 220);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1439, 220);
			this.panel1.TabIndex = 5;
			// 
			// flatLabelTitre
			// 
			this.flatLabelTitre.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flatLabelTitre.AutoSize = true;
			this.flatLabelTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatLabelTitre.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabelTitre.ForeColor = System.Drawing.Color.White;
			this.flatLabelTitre.Location = new System.Drawing.Point(52, 99);
			this.flatLabelTitre.Name = "flatLabelTitre";
			this.flatLabelTitre.Size = new System.Drawing.Size(73, 37);
			this.flatLabelTitre.TabIndex = 0;
			this.flatLabelTitre.Text = "Titre";
			this.flatLabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.flatButtonAjouter);
			this.panel2.Controls.Add(this.flatTextBoxPrixVente);
			this.panel2.Controls.Add(this.flatTextBoxPrixAchat);
			this.panel2.Controls.Add(this.flatTextBoxQuantiteMin);
			this.panel2.Controls.Add(this.flatTextBoxQuantiteActuelle);
			this.panel2.Controls.Add(this.flatTextBoxNom);
			this.panel2.Controls.Add(this.flatLabelPrixAchat);
			this.panel2.Controls.Add(this.flatLabelPrixVente);
			this.panel2.Controls.Add(this.flatLabelQuantiteMin);
			this.panel2.Controls.Add(this.flatLabelQuantiteActuelle);
			this.panel2.Controls.Add(this.flatLabelNom);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1439, 893);
			this.panel2.TabIndex = 6;
			// 
			// flatButtonAjouter
			// 
			this.flatButtonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonAjouter.FlatAppearance.BorderSize = 0;
			this.flatButtonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonAjouter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonAjouter.ForeColor = System.Drawing.Color.White;
			this.flatButtonAjouter.Location = new System.Drawing.Point(594, 500);
			this.flatButtonAjouter.Name = "flatButtonAjouter";
			this.flatButtonAjouter.Size = new System.Drawing.Size(150, 40);
			this.flatButtonAjouter.TabIndex = 10;
			this.flatButtonAjouter.Text = "Ajouter";
			this.flatButtonAjouter.UseVisualStyleBackColor = false;
			this.flatButtonAjouter.Click += new System.EventHandler(this.flatButtonAjouter_Click);
			// 
			// flatTextBoxPrixVente
			// 
			this.flatTextBoxPrixVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxPrixVente.Location = new System.Drawing.Point(594, 400);
			this.flatTextBoxPrixVente.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxPrixVente.Name = "flatTextBoxPrixVente";
			this.flatTextBoxPrixVente.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxPrixVente.TabIndex = 9;
			this.flatTextBoxPrixVente.Texte = "";
			// 
			// flatTextBoxPrixAchat
			// 
			this.flatTextBoxPrixAchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxPrixAchat.Location = new System.Drawing.Point(594, 300);
			this.flatTextBoxPrixAchat.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxPrixAchat.Name = "flatTextBoxPrixAchat";
			this.flatTextBoxPrixAchat.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxPrixAchat.TabIndex = 8;
			this.flatTextBoxPrixAchat.Texte = "";
			// 
			// flatTextBoxQuantiteMin
			// 
			this.flatTextBoxQuantiteMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxQuantiteMin.Location = new System.Drawing.Point(232, 500);
			this.flatTextBoxQuantiteMin.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxQuantiteMin.Name = "flatTextBoxQuantiteMin";
			this.flatTextBoxQuantiteMin.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxQuantiteMin.TabIndex = 7;
			this.flatTextBoxQuantiteMin.Texte = "";
			// 
			// flatTextBoxQuantiteActuelle
			// 
			this.flatTextBoxQuantiteActuelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxQuantiteActuelle.Location = new System.Drawing.Point(232, 400);
			this.flatTextBoxQuantiteActuelle.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxQuantiteActuelle.Name = "flatTextBoxQuantiteActuelle";
			this.flatTextBoxQuantiteActuelle.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxQuantiteActuelle.TabIndex = 6;
			this.flatTextBoxQuantiteActuelle.Texte = "";
			// 
			// flatTextBoxNom
			// 
			this.flatTextBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxNom.Location = new System.Drawing.Point(232, 300);
			this.flatTextBoxNom.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxNom.Name = "flatTextBoxNom";
			this.flatTextBoxNom.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxNom.TabIndex = 5;
			this.flatTextBoxNom.Texte = "";
			// 
			// flatLabelPrixAchat
			// 
			this.flatLabelPrixAchat.AutoSize = true;
			this.flatLabelPrixAchat.BackColor = System.Drawing.Color.White;
			this.flatLabelPrixAchat.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelPrixAchat.ForeColor = System.Drawing.Color.Black;
			this.flatLabelPrixAchat.Location = new System.Drawing.Point(447, 317);
			this.flatLabelPrixAchat.Name = "flatLabelPrixAchat";
			this.flatLabelPrixAchat.Size = new System.Drawing.Size(99, 23);
			this.flatLabelPrixAchat.TabIndex = 4;
			this.flatLabelPrixAchat.Text = "Prix d\'achat";
			// 
			// flatLabelPrixVente
			// 
			this.flatLabelPrixVente.AutoSize = true;
			this.flatLabelPrixVente.BackColor = System.Drawing.Color.White;
			this.flatLabelPrixVente.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelPrixVente.ForeColor = System.Drawing.Color.Black;
			this.flatLabelPrixVente.Location = new System.Drawing.Point(445, 417);
			this.flatLabelPrixVente.Name = "flatLabelPrixVente";
			this.flatLabelPrixVente.Size = new System.Drawing.Size(109, 23);
			this.flatLabelPrixVente.TabIndex = 3;
			this.flatLabelPrixVente.Text = "Prix de vente";
			// 
			// flatLabelQuantiteMin
			// 
			this.flatLabelQuantiteMin.AutoSize = true;
			this.flatLabelQuantiteMin.BackColor = System.Drawing.Color.White;
			this.flatLabelQuantiteMin.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelQuantiteMin.ForeColor = System.Drawing.Color.Black;
			this.flatLabelQuantiteMin.Location = new System.Drawing.Point(50, 517);
			this.flatLabelQuantiteMin.Name = "flatLabelQuantiteMin";
			this.flatLabelQuantiteMin.Size = new System.Drawing.Size(152, 23);
			this.flatLabelQuantiteMin.TabIndex = 2;
			this.flatLabelQuantiteMin.Text = "Quantité minimale";
			// 
			// flatLabelQuantiteActuelle
			// 
			this.flatLabelQuantiteActuelle.AutoSize = true;
			this.flatLabelQuantiteActuelle.BackColor = System.Drawing.Color.White;
			this.flatLabelQuantiteActuelle.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelQuantiteActuelle.ForeColor = System.Drawing.Color.Black;
			this.flatLabelQuantiteActuelle.Location = new System.Drawing.Point(52, 417);
			this.flatLabelQuantiteActuelle.Name = "flatLabelQuantiteActuelle";
			this.flatLabelQuantiteActuelle.Size = new System.Drawing.Size(141, 23);
			this.flatLabelQuantiteActuelle.TabIndex = 1;
			this.flatLabelQuantiteActuelle.Text = "Quantité actuelle";
			// 
			// flatLabelNom
			// 
			this.flatLabelNom.AutoSize = true;
			this.flatLabelNom.BackColor = System.Drawing.Color.White;
			this.flatLabelNom.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelNom.ForeColor = System.Drawing.Color.Black;
			this.flatLabelNom.Location = new System.Drawing.Point(52, 317);
			this.flatLabelNom.Name = "flatLabelNom";
			this.flatLabelNom.Size = new System.Drawing.Size(48, 23);
			this.flatLabelNom.TabIndex = 0;
			this.flatLabelNom.Text = "Nom";
			// 
			// Ajouter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "Ajouter";
			this.Size = new System.Drawing.Size(1439, 893);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Controls.FlatLabel flatLabelTitre;
		private Controls.FlatLabel flatLabelNom;
		private Controls.FlatLabel flatLabelPrixAchat;
		private Controls.FlatLabel flatLabelPrixVente;
		private Controls.FlatLabel flatLabelQuantiteMin;
		private Controls.FlatLabel flatLabelQuantiteActuelle;
		private Controls.FlatTextBox flatTextBoxPrixVente;
		private Controls.FlatTextBox flatTextBoxPrixAchat;
		private Controls.FlatTextBox flatTextBoxQuantiteMin;
		private Controls.FlatTextBox flatTextBoxQuantiteActuelle;
		private Controls.FlatTextBox flatTextBoxNom;
		private Controls.Buttons.FlatButton flatButtonAjouter;
	}
}
