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
			this.panelTitre = new System.Windows.Forms.Panel();
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
			this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCorps.Location = new System.Drawing.Point(0, 220);
			this.panelCorps.Name = "panelCorps";
			this.panelCorps.Size = new System.Drawing.Size(1856, 673);
			this.panelCorps.TabIndex = 11;
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
			this.panelTitre.ResumeLayout(false);
			this.panelTitre.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.FlatLabel flatLabelTitre;
		private System.Windows.Forms.Panel panelCorps;
		private System.Windows.Forms.Panel panelTitre;
	}
}
