namespace QMag.Pages.Stock
{
	partial class VueHtml
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
			this.flatButtonHtml = new QMag.Controls.Buttons.FlatButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
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
			this.panel1.Size = new System.Drawing.Size(1650, 220);
			this.panel1.TabIndex = 9;
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
			this.flatLabelTitre.Size = new System.Drawing.Size(285, 37);
			this.flatLabelTitre.TabIndex = 0;
			this.flatLabelTitre.Text = "Consultation du stock";
			this.flatLabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flatButtonHtml
			// 
			this.flatButtonHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatButtonHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonHtml.FlatAppearance.BorderSize = 0;
			this.flatButtonHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonHtml.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonHtml.ForeColor = System.Drawing.Color.White;
			this.flatButtonHtml.Location = new System.Drawing.Point(1382, 138);
			this.flatButtonHtml.Name = "flatButtonHtml";
			this.flatButtonHtml.Size = new System.Drawing.Size(239, 63);
			this.flatButtonHtml.TabIndex = 8;
			this.flatButtonHtml.Text = "Exporter";
			this.flatButtonHtml.UseVisualStyleBackColor = false;
			this.flatButtonHtml.Click += new System.EventHandler(this.flatButtonHtml_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.webBrowser);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1650, 673);
			this.panel2.TabIndex = 10;
			// 
			// webBrowser
			// 
			this.webBrowser.AllowNavigation = false;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(1650, 673);
			this.webBrowser.TabIndex = 0;
			// 
			// VueHtml
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.flatButtonHtml);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "VueHtml";
			this.Size = new System.Drawing.Size(1650, 893);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Controls.FlatLabel flatLabelTitre;
		private Controls.Buttons.FlatButton flatButtonHtml;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.WebBrowser webBrowser;
	}
}
