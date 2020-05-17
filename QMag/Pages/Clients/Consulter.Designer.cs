namespace QMag.Pages.Clients
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
			this.flatLabelTitre = new QMag.Controls.FlatLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.flatDataGridView = new QMag.Controls.FlatDataGridView();
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
			this.panel1.TabIndex = 8;
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
			this.flatLabelTitre.Size = new System.Drawing.Size(309, 37);
			this.flatLabelTitre.TabIndex = 0;
			this.flatLabelTitre.Text = "Consultation des clients";
			this.flatLabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.flatDataGridView);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1856, 673);
			this.panel2.TabIndex = 9;
			// 
			// flatDataGridView
			// 
			this.flatDataGridView.BackColor = System.Drawing.Color.White;
			this.flatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatDataGridView.Location = new System.Drawing.Point(0, 0);
			this.flatDataGridView.Name = "flatDataGridView";
			this.flatDataGridView.Size = new System.Drawing.Size(1856, 673);
			this.flatDataGridView.TabIndex = 0;
			// 
			// Consulter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Consulter";
			this.Size = new System.Drawing.Size(1856, 893);
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
		private Controls.FlatDataGridView flatDataGridView;
	}
}
