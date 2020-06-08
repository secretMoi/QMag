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
			this.labelTitre = new System.Windows.Forms.Label();
			this.panelCorps = new System.Windows.Forms.Panel();
			this.graphic = new QMag.Controls.Graphic();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panelTexte = new System.Windows.Forms.Panel();
			this.panelInfosPoints = new System.Windows.Forms.Panel();
			this.flatDataGridViewPoints = new QMag.Controls.FlatDataGridView();
			this.panelLabels = new System.Windows.Forms.Panel();
			this.flatLabelChiffreAffaires = new QMag.Controls.FlatLabel();
			this.flatLabelDateDebut = new QMag.Controls.FlatLabel();
			this.flatLabelDateFin = new QMag.Controls.FlatLabel();
			this.panel1.SuspendLayout();
			this.panelCorps.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
			this.panelTexte.SuspendLayout();
			this.panelInfosPoints.SuspendLayout();
			this.panelLabels.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panel1.Controls.Add(this.labelTitre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1856, 220);
			this.panel1.TabIndex = 5;
			// 
			// labelTitre
			// 
			this.labelTitre.AutoSize = true;
			this.labelTitre.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitre.ForeColor = System.Drawing.Color.White;
			this.labelTitre.Location = new System.Drawing.Point(17, 85);
			this.labelTitre.Margin = new System.Windows.Forms.Padding(0);
			this.labelTitre.Name = "labelTitre";
			this.labelTitre.Size = new System.Drawing.Size(301, 37);
			this.labelTitre.TabIndex = 1;
			this.labelTitre.Text = "Chiffre d\'affaires total";
			// 
			// panelCorps
			// 
			this.panelCorps.Controls.Add(this.graphic);
			this.panelCorps.Controls.Add(this.flowLayoutPanel1);
			this.panelCorps.Controls.Add(this.panelTexte);
			this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCorps.Location = new System.Drawing.Point(0, 220);
			this.panelCorps.Margin = new System.Windows.Forms.Padding(0);
			this.panelCorps.Name = "panelCorps";
			this.panelCorps.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.panelCorps.Size = new System.Drawing.Size(1856, 673);
			this.panelCorps.TabIndex = 6;
			// 
			// graphic
			// 
			this.graphic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphic.Location = new System.Drawing.Point(244, 0);
			this.graphic.Margin = new System.Windows.Forms.Padding(0);
			this.graphic.Name = "graphic";
			this.graphic.Size = new System.Drawing.Size(1612, 673);
			this.graphic.TabIndex = 0;
			this.graphic.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(244, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1612, 673);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// panelTexte
			// 
			this.panelTexte.Controls.Add(this.panelInfosPoints);
			this.panelTexte.Controls.Add(this.panelLabels);
			this.panelTexte.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelTexte.Location = new System.Drawing.Point(5, 0);
			this.panelTexte.Name = "panelTexte";
			this.panelTexte.Size = new System.Drawing.Size(239, 673);
			this.panelTexte.TabIndex = 1;
			// 
			// panelInfosPoints
			// 
			this.panelInfosPoints.Controls.Add(this.flatDataGridViewPoints);
			this.panelInfosPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelInfosPoints.Location = new System.Drawing.Point(0, 142);
			this.panelInfosPoints.Name = "panelInfosPoints";
			this.panelInfosPoints.Size = new System.Drawing.Size(239, 531);
			this.panelInfosPoints.TabIndex = 4;
			// 
			// flatDataGridViewPoints
			// 
			this.flatDataGridViewPoints.BackColor = System.Drawing.Color.White;
			this.flatDataGridViewPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatDataGridViewPoints.Location = new System.Drawing.Point(0, 0);
			this.flatDataGridViewPoints.Name = "flatDataGridViewPoints";
			this.flatDataGridViewPoints.Size = new System.Drawing.Size(239, 531);
			this.flatDataGridViewPoints.TabIndex = 0;
			// 
			// panelLabels
			// 
			this.panelLabels.Controls.Add(this.flatLabelChiffreAffaires);
			this.panelLabels.Controls.Add(this.flatLabelDateDebut);
			this.panelLabels.Controls.Add(this.flatLabelDateFin);
			this.panelLabels.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLabels.Location = new System.Drawing.Point(0, 0);
			this.panelLabels.Name = "panelLabels";
			this.panelLabels.Size = new System.Drawing.Size(239, 142);
			this.panelLabels.TabIndex = 3;
			// 
			// flatLabelChiffreAffaires
			// 
			this.flatLabelChiffreAffaires.AutoSize = true;
			this.flatLabelChiffreAffaires.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelChiffreAffaires.ForeColor = System.Drawing.Color.Black;
			this.flatLabelChiffreAffaires.Location = new System.Drawing.Point(3, 101);
			this.flatLabelChiffreAffaires.Name = "flatLabelChiffreAffaires";
			this.flatLabelChiffreAffaires.Size = new System.Drawing.Size(129, 23);
			this.flatLabelChiffreAffaires.TabIndex = 1;
			this.flatLabelChiffreAffaires.Text = "Argent gagné : ";
			// 
			// flatLabelDateDebut
			// 
			this.flatLabelDateDebut.AutoSize = true;
			this.flatLabelDateDebut.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelDateDebut.ForeColor = System.Drawing.Color.Black;
			this.flatLabelDateDebut.Location = new System.Drawing.Point(3, 15);
			this.flatLabelDateDebut.Name = "flatLabelDateDebut";
			this.flatLabelDateDebut.Size = new System.Drawing.Size(85, 23);
			this.flatLabelDateDebut.TabIndex = 0;
			this.flatLabelDateDebut.Text = "Depuis le ";
			// 
			// flatLabelDateFin
			// 
			this.flatLabelDateFin.AutoSize = true;
			this.flatLabelDateFin.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F);
			this.flatLabelDateFin.ForeColor = System.Drawing.Color.Black;
			this.flatLabelDateFin.Location = new System.Drawing.Point(3, 58);
			this.flatLabelDateFin.Name = "flatLabelDateFin";
			this.flatLabelDateFin.Size = new System.Drawing.Size(81, 23);
			this.flatLabelDateFin.TabIndex = 2;
			this.flatLabelDateFin.Text = "Jusqu\'au ";
			// 
			// ChiffreAffaire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.panelCorps);
			this.Controls.Add(this.panel1);
			this.Name = "ChiffreAffaire";
			this.Size = new System.Drawing.Size(1856, 893);
			this.Load += new System.EventHandler(this.ChiffreAffaire_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelCorps.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
			this.panelTexte.ResumeLayout(false);
			this.panelInfosPoints.ResumeLayout(false);
			this.panelLabels.ResumeLayout(false);
			this.panelLabels.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelTitre;
		private System.Windows.Forms.Panel panelCorps;
		private Controls.Graphic graphic;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panelTexte;
		private System.Windows.Forms.Panel panelInfosPoints;
		private Controls.FlatDataGridView flatDataGridViewPoints;
		private System.Windows.Forms.Panel panelLabels;
		private Controls.FlatLabel flatLabelChiffreAffaires;
		private Controls.FlatLabel flatLabelDateDebut;
		private Controls.FlatLabel flatLabelDateFin;
	}
}
