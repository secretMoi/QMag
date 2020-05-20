namespace QMag.Pages.Clients
{
	partial class Commander
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
			this.panelTitre = new System.Windows.Forms.Panel();
			this.flatLabelTitre = new QMag.Controls.FlatLabel();
			this.panelCorps = new System.Windows.Forms.Panel();
			this.panelDgv = new System.Windows.Forms.Panel();
			this.flatDataGridView = new QMag.Controls.FlatDataGridView();
			this.panelFormulaire = new System.Windows.Forms.Panel();
			this.flatListBoxClient = new QMag.Controls.FlatListBox();
			this.flatLabelClient = new QMag.Controls.FlatLabel();
			this.flatListBoxArticle = new QMag.Controls.FlatListBox();
			this.flatLabelTotalMontant = new QMag.Controls.FlatLabel();
			this.flatLabelTotal = new QMag.Controls.FlatLabel();
			this.flatButtonConfirmer = new QMag.Controls.Buttons.FlatButton();
			this.flatButtonAjouter = new QMag.Controls.Buttons.FlatButton();
			this.flatTextBoxQuantite = new QMag.Controls.FlatTextBox();
			this.flatLabelQuantite = new QMag.Controls.FlatLabel();
			this.flatLabelArticle = new QMag.Controls.FlatLabel();
			this.panelTitre.SuspendLayout();
			this.panelCorps.SuspendLayout();
			this.panelDgv.SuspendLayout();
			this.panelFormulaire.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitre
			// 
			this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panelTitre.Controls.Add(this.flatLabelTitre);
			this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitre.Location = new System.Drawing.Point(0, 0);
			this.panelTitre.MaximumSize = new System.Drawing.Size(0, 220);
			this.panelTitre.Name = "panelTitre";
			this.panelTitre.Size = new System.Drawing.Size(1039, 220);
			this.panelTitre.TabIndex = 12;
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
			this.flatLabelTitre.Size = new System.Drawing.Size(291, 37);
			this.flatLabelTitre.TabIndex = 0;
			this.flatLabelTitre.Text = "Passer une commande";
			this.flatLabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelCorps
			// 
			this.panelCorps.Controls.Add(this.panelDgv);
			this.panelCorps.Controls.Add(this.panelFormulaire);
			this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCorps.Location = new System.Drawing.Point(0, 220);
			this.panelCorps.Name = "panelCorps";
			this.panelCorps.Size = new System.Drawing.Size(1039, 673);
			this.panelCorps.TabIndex = 13;
			// 
			// panelDgv
			// 
			this.panelDgv.Controls.Add(this.flatDataGridView);
			this.panelDgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDgv.Location = new System.Drawing.Point(293, 0);
			this.panelDgv.Name = "panelDgv";
			this.panelDgv.Size = new System.Drawing.Size(746, 673);
			this.panelDgv.TabIndex = 0;
			// 
			// flatDataGridView
			// 
			this.flatDataGridView.BackColor = System.Drawing.Color.White;
			this.flatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatDataGridView.Location = new System.Drawing.Point(0, 0);
			this.flatDataGridView.Name = "flatDataGridView";
			this.flatDataGridView.Size = new System.Drawing.Size(746, 673);
			this.flatDataGridView.TabIndex = 0;
			// 
			// panelFormulaire
			// 
			this.panelFormulaire.Controls.Add(this.flatListBoxClient);
			this.panelFormulaire.Controls.Add(this.flatLabelClient);
			this.panelFormulaire.Controls.Add(this.flatListBoxArticle);
			this.panelFormulaire.Controls.Add(this.flatLabelTotalMontant);
			this.panelFormulaire.Controls.Add(this.flatLabelTotal);
			this.panelFormulaire.Controls.Add(this.flatButtonConfirmer);
			this.panelFormulaire.Controls.Add(this.flatButtonAjouter);
			this.panelFormulaire.Controls.Add(this.flatTextBoxQuantite);
			this.panelFormulaire.Controls.Add(this.flatLabelQuantite);
			this.panelFormulaire.Controls.Add(this.flatLabelArticle);
			this.panelFormulaire.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelFormulaire.Location = new System.Drawing.Point(0, 0);
			this.panelFormulaire.Name = "panelFormulaire";
			this.panelFormulaire.Size = new System.Drawing.Size(293, 673);
			this.panelFormulaire.TabIndex = 10;
			// 
			// flatListBoxClient
			// 
			this.flatListBoxClient.AutoSize = true;
			this.flatListBoxClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flatListBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatListBoxClient.Location = new System.Drawing.Point(135, 17);
			this.flatListBoxClient.Margin = new System.Windows.Forms.Padding(0);
			this.flatListBoxClient.MaximumSize = new System.Drawing.Size(150, 40);
			this.flatListBoxClient.MinimumSize = new System.Drawing.Size(150, 40);
			this.flatListBoxClient.Name = "flatListBoxClient";
			this.flatListBoxClient.Size = new System.Drawing.Size(150, 40);
			this.flatListBoxClient.TabIndex = 11;
			// 
			// flatLabelClient
			// 
			this.flatLabelClient.AutoSize = true;
			this.flatLabelClient.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelClient.ForeColor = System.Drawing.Color.Black;
			this.flatLabelClient.Location = new System.Drawing.Point(13, 34);
			this.flatLabelClient.Name = "flatLabelClient";
			this.flatLabelClient.Size = new System.Drawing.Size(54, 23);
			this.flatLabelClient.TabIndex = 10;
			this.flatLabelClient.Text = "Client";
			// 
			// flatListBoxArticle
			// 
			this.flatListBoxArticle.AutoSize = true;
			this.flatListBoxArticle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flatListBoxArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatListBoxArticle.Location = new System.Drawing.Point(135, 79);
			this.flatListBoxArticle.Margin = new System.Windows.Forms.Padding(0);
			this.flatListBoxArticle.MaximumSize = new System.Drawing.Size(150, 40);
			this.flatListBoxArticle.MinimumSize = new System.Drawing.Size(150, 40);
			this.flatListBoxArticle.Name = "flatListBoxArticle";
			this.flatListBoxArticle.Size = new System.Drawing.Size(150, 40);
			this.flatListBoxArticle.TabIndex = 7;
			// 
			// flatLabelTotalMontant
			// 
			this.flatLabelTotalMontant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flatLabelTotalMontant.BackColor = System.Drawing.Color.White;
			this.flatLabelTotalMontant.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabelTotalMontant.ForeColor = System.Drawing.Color.Black;
			this.flatLabelTotalMontant.Location = new System.Drawing.Point(130, 565);
			this.flatLabelTotalMontant.Name = "flatLabelTotalMontant";
			this.flatLabelTotalMontant.Size = new System.Drawing.Size(155, 30);
			this.flatLabelTotalMontant.TabIndex = 9;
			this.flatLabelTotalMontant.Text = "0,00";
			this.flatLabelTotalMontant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// flatLabelTotal
			// 
			this.flatLabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flatLabelTotal.AutoSize = true;
			this.flatLabelTotal.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabelTotal.ForeColor = System.Drawing.Color.Black;
			this.flatLabelTotal.Location = new System.Drawing.Point(12, 565);
			this.flatLabelTotal.Name = "flatLabelTotal";
			this.flatLabelTotal.Size = new System.Drawing.Size(60, 30);
			this.flatLabelTotal.TabIndex = 8;
			this.flatLabelTotal.Text = "Total";
			// 
			// flatButtonConfirmer
			// 
			this.flatButtonConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flatButtonConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonConfirmer.FlatAppearance.BorderSize = 0;
			this.flatButtonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonConfirmer.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonConfirmer.ForeColor = System.Drawing.Color.White;
			this.flatButtonConfirmer.Location = new System.Drawing.Point(135, 622);
			this.flatButtonConfirmer.Name = "flatButtonConfirmer";
			this.flatButtonConfirmer.Size = new System.Drawing.Size(150, 40);
			this.flatButtonConfirmer.TabIndex = 6;
			this.flatButtonConfirmer.Text = "Confirmer";
			this.flatButtonConfirmer.UseVisualStyleBackColor = false;
			this.flatButtonConfirmer.Click += new System.EventHandler(this.flatButtonConfirmer_Click);
			// 
			// flatButtonAjouter
			// 
			this.flatButtonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonAjouter.FlatAppearance.BorderSize = 0;
			this.flatButtonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonAjouter.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonAjouter.ForeColor = System.Drawing.Color.White;
			this.flatButtonAjouter.Location = new System.Drawing.Point(135, 208);
			this.flatButtonAjouter.Name = "flatButtonAjouter";
			this.flatButtonAjouter.Size = new System.Drawing.Size(150, 40);
			this.flatButtonAjouter.TabIndex = 5;
			this.flatButtonAjouter.Text = "Ajouter";
			this.flatButtonAjouter.UseVisualStyleBackColor = false;
			this.flatButtonAjouter.Click += new System.EventHandler(this.flatButtonAjouter_Click);
			// 
			// flatTextBoxQuantite
			// 
			this.flatTextBoxQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxQuantite.Location = new System.Drawing.Point(135, 145);
			this.flatTextBoxQuantite.Margin = new System.Windows.Forms.Padding(0);
			this.flatTextBoxQuantite.Name = "flatTextBoxQuantite";
			this.flatTextBoxQuantite.Size = new System.Drawing.Size(150, 40);
			this.flatTextBoxQuantite.TabIndex = 4;
			// 
			// flatLabelQuantite
			// 
			this.flatLabelQuantite.AutoSize = true;
			this.flatLabelQuantite.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelQuantite.ForeColor = System.Drawing.Color.Black;
			this.flatLabelQuantite.Location = new System.Drawing.Point(13, 162);
			this.flatLabelQuantite.Name = "flatLabelQuantite";
			this.flatLabelQuantite.Size = new System.Drawing.Size(77, 23);
			this.flatLabelQuantite.TabIndex = 2;
			this.flatLabelQuantite.Text = "Quantité";
			// 
			// flatLabelArticle
			// 
			this.flatLabelArticle.AutoSize = true;
			this.flatLabelArticle.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelArticle.ForeColor = System.Drawing.Color.Black;
			this.flatLabelArticle.Location = new System.Drawing.Point(13, 96);
			this.flatLabelArticle.Name = "flatLabelArticle";
			this.flatLabelArticle.Size = new System.Drawing.Size(58, 23);
			this.flatLabelArticle.TabIndex = 1;
			this.flatLabelArticle.Text = "Article";
			// 
			// Commander
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panelCorps);
			this.Controls.Add(this.panelTitre);
			this.Name = "Commander";
			this.Size = new System.Drawing.Size(1039, 893);
			this.Load += new System.EventHandler(this.Commander_Load);
			this.panelTitre.ResumeLayout(false);
			this.panelTitre.PerformLayout();
			this.panelCorps.ResumeLayout(false);
			this.panelDgv.ResumeLayout(false);
			this.panelFormulaire.ResumeLayout(false);
			this.panelFormulaire.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTitre;
		private Controls.FlatLabel flatLabelTitre;
		private System.Windows.Forms.Panel panelCorps;
		private System.Windows.Forms.Panel panelDgv;
		private Controls.FlatDataGridView flatDataGridView;
		private System.Windows.Forms.Panel panelFormulaire;
		private Controls.FlatListBox flatListBoxClient;
		private Controls.FlatLabel flatLabelClient;
		private Controls.FlatListBox flatListBoxArticle;
		private Controls.FlatLabel flatLabelTotalMontant;
		private Controls.FlatLabel flatLabelTotal;
		private Controls.Buttons.FlatButton flatButtonConfirmer;
		private Controls.Buttons.FlatButton flatButtonAjouter;
		private Controls.FlatTextBox flatTextBoxQuantite;
		private Controls.FlatLabel flatLabelQuantite;
		private Controls.FlatLabel flatLabelArticle;
	}
}
