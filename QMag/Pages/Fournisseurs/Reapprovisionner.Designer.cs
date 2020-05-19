namespace QMag.Pages.Fournisseurs
{
	partial class Reapprovisionner
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
			this.flatLabelTitre = new QMag.Controls.FlatLabel();
			this.panelCorps = new System.Windows.Forms.Panel();
			this.flatButtonConfirmer = new QMag.Controls.Buttons.FlatButton();
			this.flatButtonAjouter = new QMag.Controls.Buttons.FlatButton();
			this.flatTextBoxQuantite = new QMag.Controls.FlatTextBox();
			this.flatLabelQuantite = new QMag.Controls.FlatLabel();
			this.flatLabelArticle = new QMag.Controls.FlatLabel();
			this.panelDgv = new System.Windows.Forms.Panel();
			this.flatDataGridView = new QMag.Controls.FlatDataGridView();
			this.panelTitre = new System.Windows.Forms.Panel();
			this.panelCorps.SuspendLayout();
			this.panelDgv.SuspendLayout();
			this.panelTitre.SuspendLayout();
			this.SuspendLayout();
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
			this.panelCorps.Controls.Add(this.flatButtonConfirmer);
			this.panelCorps.Controls.Add(this.flatButtonAjouter);
			this.panelCorps.Controls.Add(this.flatTextBoxQuantite);
			this.panelCorps.Controls.Add(this.flatLabelQuantite);
			this.panelCorps.Controls.Add(this.flatLabelArticle);
			this.panelCorps.Controls.Add(this.panelDgv);
			this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCorps.Location = new System.Drawing.Point(0, 220);
			this.panelCorps.Name = "panelCorps";
			this.panelCorps.Size = new System.Drawing.Size(1856, 673);
			this.panelCorps.TabIndex = 11;
			// 
			// flatButtonConfirmer
			// 
			this.flatButtonConfirmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flatButtonConfirmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonConfirmer.FlatAppearance.BorderSize = 0;
			this.flatButtonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonConfirmer.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonConfirmer.ForeColor = System.Drawing.Color.White;
			this.flatButtonConfirmer.Location = new System.Drawing.Point(231, 609);
			this.flatButtonConfirmer.Name = "flatButtonConfirmer";
			this.flatButtonConfirmer.Size = new System.Drawing.Size(150, 40);
			this.flatButtonConfirmer.TabIndex = 6;
			this.flatButtonConfirmer.Text = "Confirmer";
			this.flatButtonConfirmer.UseVisualStyleBackColor = false;
			// 
			// flatButtonAjouter
			// 
			this.flatButtonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonAjouter.FlatAppearance.BorderSize = 0;
			this.flatButtonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonAjouter.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonAjouter.ForeColor = System.Drawing.Color.White;
			this.flatButtonAjouter.Location = new System.Drawing.Point(231, 210);
			this.flatButtonAjouter.Name = "flatButtonAjouter";
			this.flatButtonAjouter.Size = new System.Drawing.Size(150, 40);
			this.flatButtonAjouter.TabIndex = 5;
			this.flatButtonAjouter.Text = "Ajouter";
			this.flatButtonAjouter.UseVisualStyleBackColor = false;
			this.flatButtonAjouter.Click += new System.EventHandler(this.Ajouter_Click);
			// 
			// flatTextBoxQuantite
			// 
			this.flatTextBoxQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.flatTextBoxQuantite.Location = new System.Drawing.Point(231, 136);
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
			this.flatLabelQuantite.Location = new System.Drawing.Point(74, 153);
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
			this.flatLabelArticle.Location = new System.Drawing.Point(74, 87);
			this.flatLabelArticle.Name = "flatLabelArticle";
			this.flatLabelArticle.Size = new System.Drawing.Size(58, 23);
			this.flatLabelArticle.TabIndex = 1;
			this.flatLabelArticle.Text = "Article";
			// 
			// panelDgv
			// 
			this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panelDgv.Controls.Add(this.flatDataGridView);
			this.panelDgv.Location = new System.Drawing.Point(1366, 131);
			this.panelDgv.Name = "panelDgv";
			this.panelDgv.Size = new System.Drawing.Size(473, 527);
			this.panelDgv.TabIndex = 0;
			// 
			// flatDataGridView
			// 
			this.flatDataGridView.BackColor = System.Drawing.Color.White;
			this.flatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatDataGridView.Location = new System.Drawing.Point(0, 0);
			this.flatDataGridView.Name = "flatDataGridView";
			this.flatDataGridView.Size = new System.Drawing.Size(473, 527);
			this.flatDataGridView.TabIndex = 0;
			// 
			// panelTitre
			// 
			this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panelTitre.Controls.Add(this.flatLabelTitre);
			this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitre.Location = new System.Drawing.Point(0, 0);
			this.panelTitre.MaximumSize = new System.Drawing.Size(0, 220);
			this.panelTitre.Name = "panelTitre";
			this.panelTitre.Size = new System.Drawing.Size(1856, 220);
			this.panelTitre.TabIndex = 10;
			// 
			// Reapprovisionner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panelCorps);
			this.Controls.Add(this.panelTitre);
			this.Name = "Reapprovisionner";
			this.Size = new System.Drawing.Size(1856, 893);
			this.Load += new System.EventHandler(this.Reapprovisionner_Load);
			this.panelCorps.ResumeLayout(false);
			this.panelCorps.PerformLayout();
			this.panelDgv.ResumeLayout(false);
			this.panelTitre.ResumeLayout(false);
			this.panelTitre.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.FlatLabel flatLabelTitre;
		private System.Windows.Forms.Panel panelCorps;
		private System.Windows.Forms.Panel panelTitre;
		private System.Windows.Forms.Panel panelDgv;
		private Controls.FlatDataGridView flatDataGridView;
		private Controls.FlatLabel flatLabelArticle;
		private Controls.FlatLabel flatLabelQuantite;
		private Controls.Buttons.FlatButton flatButtonConfirmer;
		private Controls.Buttons.FlatButton flatButtonAjouter;
		private Controls.FlatTextBox flatTextBoxQuantite;
	}
}
