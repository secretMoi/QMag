namespace QMag.Pages.Stock
{
	partial class Consulter
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
			this.flatButtonHtml = new QMag.Controls.Buttons.FlatButton();
			this.flatLabelTitre = new QMag.Controls.FlatLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.flatDataGridView1 = new QMag.Controls.FlatDataGridView();
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
			this.panel1.Size = new System.Drawing.Size(1856, 220);
			this.panel1.TabIndex = 6;
			// 
			// flatButtonHtml
			// 
			this.flatButtonHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatButtonHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.flatButtonHtml.FlatAppearance.BorderSize = 0;
			this.flatButtonHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flatButtonHtml.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatButtonHtml.ForeColor = System.Drawing.Color.White;
			this.flatButtonHtml.Location = new System.Drawing.Point(1593, 139);
			this.flatButtonHtml.Name = "flatButtonHtml";
			this.flatButtonHtml.Size = new System.Drawing.Size(239, 63);
			this.flatButtonHtml.TabIndex = 3;
			this.flatButtonHtml.Text = "Vue HTML";
			this.flatButtonHtml.UseVisualStyleBackColor = false;
			this.flatButtonHtml.Click += new System.EventHandler(this.flatButtonHtml_Click);
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
			// panel2
			// 
			this.panel2.Controls.Add(this.flatDataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1856, 673);
			this.panel2.TabIndex = 7;
			// 
			// flatDataGridView1
			// 
			this.flatDataGridView1.BackColor = System.Drawing.Color.White;
			this.flatDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatDataGridView1.Location = new System.Drawing.Point(0, 0);
			this.flatDataGridView1.Name = "flatDataGridView1";
			this.flatDataGridView1.Size = new System.Drawing.Size(1856, 673);
			this.flatDataGridView1.TabIndex = 0;
			// 
			// Consulter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.flatButtonHtml);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Consulter";
			this.Load += new System.EventHandler(this.Consulter_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Controls.FlatLabel flatLabelTitre;
		private System.Windows.Forms.Panel panel2;
		private Controls.FlatDataGridView flatDataGridView1;
		private Controls.Buttons.FlatButton flatButtonHtml;
	}
}
