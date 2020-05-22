namespace QMag.Pages
{
	partial class ChiffreAffaire
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
			this.buttonConnexion = new QMag.Controls.Buttons.FlatButton();
			this.labelConnexion = new System.Windows.Forms.Label();
			this.panelCorps = new System.Windows.Forms.Panel();
			this.graphic1 = new QMag.Controls.Graphic();
			this.panel1.SuspendLayout();
			this.panelCorps.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.graphic1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panel1.Controls.Add(this.buttonConnexion);
			this.panel1.Controls.Add(this.labelConnexion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1856, 220);
			this.panel1.TabIndex = 5;
			// 
			// buttonConnexion
			// 
			this.buttonConnexion.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.buttonConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.buttonConnexion.FlatAppearance.BorderSize = 0;
			this.buttonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConnexion.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConnexion.ForeColor = System.Drawing.Color.White;
			this.buttonConnexion.Location = new System.Drawing.Point(1570, 127);
			this.buttonConnexion.Name = "buttonConnexion";
			this.buttonConnexion.Size = new System.Drawing.Size(239, 63);
			this.buttonConnexion.TabIndex = 2;
			this.buttonConnexion.Text = "flatButton1";
			this.buttonConnexion.UseVisualStyleBackColor = false;
			// 
			// labelConnexion
			// 
			this.labelConnexion.AutoSize = true;
			this.labelConnexion.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConnexion.ForeColor = System.Drawing.Color.White;
			this.labelConnexion.Location = new System.Drawing.Point(17, 85);
			this.labelConnexion.Margin = new System.Windows.Forms.Padding(0);
			this.labelConnexion.Name = "labelConnexion";
			this.labelConnexion.Size = new System.Drawing.Size(250, 37);
			this.labelConnexion.TabIndex = 1;
			this.labelConnexion.Text = "Connexion établie";
			// 
			// panelCorps
			// 
			this.panelCorps.Controls.Add(this.graphic1);
			this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCorps.Location = new System.Drawing.Point(0, 220);
			this.panelCorps.Name = "panelCorps";
			this.panelCorps.Size = new System.Drawing.Size(1856, 673);
			this.panelCorps.TabIndex = 6;
			// 
			// graphic1
			// 
			this.graphic1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphic1.Location = new System.Drawing.Point(0, 0);
			this.graphic1.Name = "graphic1";
			this.graphic1.Size = new System.Drawing.Size(1856, 673);
			this.graphic1.TabIndex = 0;
			this.graphic1.TabStop = false;
			// 
			// ChiffreAffaire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panelCorps);
			this.Controls.Add(this.panel1);
			this.Name = "ChiffreAffaire";
			this.Size = new System.Drawing.Size(1856, 893);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelCorps.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.graphic1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Controls.Buttons.FlatButton buttonConnexion;
		private System.Windows.Forms.Label labelConnexion;
		private System.Windows.Forms.Panel panelCorps;
		private Controls.Graphic graphic1;
	}
}
