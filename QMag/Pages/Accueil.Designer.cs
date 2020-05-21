using QMag.Controls.Buttons;

namespace QMag.Pages
{
    partial class Accueil
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonConnexion = new QMag.Controls.Buttons.FlatButton();
			this.labelConnexion = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelAlerte = new System.Windows.Forms.Panel();
			this.flatLabelAlerte = new QMag.Controls.FlatLabel();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panelAlerte.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.panel1.Controls.Add(this.panelAlerte);
			this.panel1.Controls.Add(this.buttonConnexion);
			this.panel1.Controls.Add(this.labelConnexion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1856, 220);
			this.panel1.TabIndex = 0;
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
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(54, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 175);
			this.button1.TabIndex = 1;
			this.button1.Text = "\r\nbutton1";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(844, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(175, 175);
			this.button2.TabIndex = 2;
			this.button2.Text = "\r\nbutton1";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new System.Drawing.Point(1634, 208);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(175, 175);
			this.button3.TabIndex = 3;
			this.button3.Text = "\r\nbutton1";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1856, 590);
			this.panel2.TabIndex = 4;
			// 
			// panelAlerte
			// 
			this.panelAlerte.BackColor = System.Drawing.Color.White;
			this.panelAlerte.Controls.Add(this.flatLabelAlerte);
			this.panelAlerte.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAlerte.Location = new System.Drawing.Point(0, 0);
			this.panelAlerte.Margin = new System.Windows.Forms.Padding(0);
			this.panelAlerte.MaximumSize = new System.Drawing.Size(0, 45);
			this.panelAlerte.Name = "panelAlerte";
			this.panelAlerte.Size = new System.Drawing.Size(1856, 45);
			this.panelAlerte.TabIndex = 4;
			this.panelAlerte.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAlerte_MouseClick);
			// 
			// flatLabelAlerte
			// 
			this.flatLabelAlerte.AutoSize = true;
			this.flatLabelAlerte.Font = new System.Drawing.Font("Yu Gothic UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabelAlerte.ForeColor = System.Drawing.Color.Black;
			this.flatLabelAlerte.Location = new System.Drawing.Point(20, 10);
			this.flatLabelAlerte.Name = "flatLabelAlerte";
			this.flatLabelAlerte.Size = new System.Drawing.Size(769, 23);
			this.flatLabelAlerte.TabIndex = 0;
			this.flatLabelAlerte.Text = "Il existe des articles en quantité insuffisante ! Cliquez sur ce message pour con" +
    "sulter l\'état du stock.";
			this.flatLabelAlerte.Click += new System.EventHandler(this.flatLabelAlerte_Click);
			// 
			// timer
			// 
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Accueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Accueil";
			this.Size = new System.Drawing.Size(1856, 810);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panelAlerte.ResumeLayout(false);
			this.panelAlerte.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Button button3;
        private FlatButton buttonConnexion;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelAlerte;
		private Controls.FlatLabel flatLabelAlerte;
		private System.Windows.Forms.Timer timer;
	}
}
