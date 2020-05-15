using  QMag.Controls.Buttons;

namespace QMag.Fenetres
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.menuFlatButtonClose = new QMag.Controls.Buttons.MenuFlatButton();
			this.panelSousMenuStock = new System.Windows.Forms.Panel();
			this.menu_Stock_Consulter = new QMag.Controls.Buttons.MenuFlatButton();
			this.menu_Stock_Ajouter = new QMag.Controls.Buttons.MenuFlatButton();
			this.menu_Stock = new QMag.Controls.Buttons.MenuFlatButton();
			this.menu_Accueil = new QMag.Controls.Buttons.MenuFlatButton();
			this.panelContainer = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.pictureBoxReduce = new System.Windows.Forms.PictureBox();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timerMenuDeroulant = new System.Windows.Forms.Timer(this.components);
			this.pictureBoxResize = new System.Windows.Forms.PictureBox();
			this.menu_Clients_Consulter = new QMag.Controls.Buttons.MenuFlatButton();
			this.menu_Clients_Ajouter = new QMag.Controls.Buttons.MenuFlatButton();
			this.menu_Clients = new QMag.Controls.Buttons.MenuFlatButton();
			this.panelSousMenuClients = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelSousMenuStock.SuspendLayout();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxReduce)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).BeginInit();
			this.panelSousMenuClients.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.AutoScroll = true;
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
			this.panelMenu.Controls.Add(this.menuFlatButtonClose);
			this.panelMenu.Controls.Add(this.panelSousMenuClients);
			this.panelMenu.Controls.Add(this.menu_Clients);
			this.panelMenu.Controls.Add(this.panelSousMenuStock);
			this.panelMenu.Controls.Add(this.menu_Stock);
			this.panelMenu.Controls.Add(this.menu_Accueil);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 94);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(275, 599);
			this.panelMenu.TabIndex = 3;
			// 
			// menuFlatButtonClose
			// 
			this.menuFlatButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.menuFlatButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuFlatButtonClose.FlatAppearance.BorderSize = 0;
			this.menuFlatButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuFlatButtonClose.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuFlatButtonClose.ForeColor = System.Drawing.Color.White;
			this.menuFlatButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("menuFlatButtonClose.Image")));
			this.menuFlatButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menuFlatButtonClose.Location = new System.Drawing.Point(0, 529);
			this.menuFlatButtonClose.Name = "menuFlatButtonClose";
			this.menuFlatButtonClose.Size = new System.Drawing.Size(275, 70);
			this.menuFlatButtonClose.TabIndex = 7;
			this.menuFlatButtonClose.Text = "   Quitter";
			this.menuFlatButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menuFlatButtonClose.UseVisualStyleBackColor = false;
			this.menuFlatButtonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// panelSousMenuStock
			// 
			this.panelSousMenuStock.Controls.Add(this.menu_Stock_Consulter);
			this.panelSousMenuStock.Controls.Add(this.menu_Stock_Ajouter);
			this.panelSousMenuStock.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSousMenuStock.Location = new System.Drawing.Point(0, 140);
			this.panelSousMenuStock.MaximumSize = new System.Drawing.Size(275, 140);
			this.panelSousMenuStock.Name = "panelSousMenuStock";
			this.panelSousMenuStock.Size = new System.Drawing.Size(275, 140);
			this.panelSousMenuStock.TabIndex = 8;
			// 
			// menu_Stock_Consulter
			// 
			this.menu_Stock_Consulter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.menu_Stock_Consulter.FlatAppearance.BorderSize = 0;
			this.menu_Stock_Consulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Stock_Consulter.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Stock_Consulter.ForeColor = System.Drawing.Color.White;
			this.menu_Stock_Consulter.Image = ((System.Drawing.Image)(resources.GetObject("menu_Stock_Consulter.Image")));
			this.menu_Stock_Consulter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Stock_Consulter.Location = new System.Drawing.Point(0, 70);
			this.menu_Stock_Consulter.Name = "menu_Stock_Consulter";
			this.menu_Stock_Consulter.Size = new System.Drawing.Size(275, 70);
			this.menu_Stock_Consulter.TabIndex = 1;
			this.menu_Stock_Consulter.Text = "   Consulter";
			this.menu_Stock_Consulter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Stock_Consulter.UseVisualStyleBackColor = false;
			this.menu_Stock_Consulter.Click += new System.EventHandler(this.Menu_Click);
			// 
			// menu_Stock_Ajouter
			// 
			this.menu_Stock_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.menu_Stock_Ajouter.FlatAppearance.BorderSize = 0;
			this.menu_Stock_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Stock_Ajouter.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Stock_Ajouter.ForeColor = System.Drawing.Color.White;
			this.menu_Stock_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("menu_Stock_Ajouter.Image")));
			this.menu_Stock_Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Stock_Ajouter.Location = new System.Drawing.Point(0, 0);
			this.menu_Stock_Ajouter.Name = "menu_Stock_Ajouter";
			this.menu_Stock_Ajouter.Size = new System.Drawing.Size(275, 70);
			this.menu_Stock_Ajouter.TabIndex = 0;
			this.menu_Stock_Ajouter.Text = "   Ajouter";
			this.menu_Stock_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Stock_Ajouter.UseVisualStyleBackColor = false;
			this.menu_Stock_Ajouter.Click += new System.EventHandler(this.Menu_Click);
			// 
			// menu_Stock
			// 
			this.menu_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.menu_Stock.Dock = System.Windows.Forms.DockStyle.Top;
			this.menu_Stock.FlatAppearance.BorderSize = 0;
			this.menu_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Stock.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Stock.ForeColor = System.Drawing.Color.White;
			this.menu_Stock.Image = ((System.Drawing.Image)(resources.GetObject("menu_Stock.Image")));
			this.menu_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Stock.Location = new System.Drawing.Point(0, 70);
			this.menu_Stock.Name = "menu_Stock";
			this.menu_Stock.Size = new System.Drawing.Size(275, 70);
			this.menu_Stock.TabIndex = 6;
			this.menu_Stock.Text = "   Stock";
			this.menu_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Stock.UseVisualStyleBackColor = false;
			this.menu_Stock.Click += new System.EventHandler(this.Menu_Click);
			// 
			// menu_Accueil
			// 
			this.menu_Accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.menu_Accueil.Dock = System.Windows.Forms.DockStyle.Top;
			this.menu_Accueil.FlatAppearance.BorderSize = 0;
			this.menu_Accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Accueil.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Accueil.ForeColor = System.Drawing.Color.White;
			this.menu_Accueil.Image = ((System.Drawing.Image)(resources.GetObject("menu_Accueil.Image")));
			this.menu_Accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Accueil.Location = new System.Drawing.Point(0, 0);
			this.menu_Accueil.Name = "menu_Accueil";
			this.menu_Accueil.Size = new System.Drawing.Size(275, 70);
			this.menu_Accueil.TabIndex = 5;
			this.menu_Accueil.Text = "   Accueil";
			this.menu_Accueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Accueil.UseVisualStyleBackColor = false;
			this.menu_Accueil.Click += new System.EventHandler(this.Menu_Click);
			// 
			// panelContainer
			// 
			this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelContainer.Location = new System.Drawing.Point(272, 93);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(800, 600);
			this.panelContainer.TabIndex = 4;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(193)))));
			this.panelHeader.Controls.Add(this.pictureBoxReduce);
			this.panelHeader.Controls.Add(this.pictureBoxClose);
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1072, 94);
			this.panelHeader.TabIndex = 5;
			this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
			// 
			// pictureBoxReduce
			// 
			this.pictureBoxReduce.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pictureBoxReduce.Image = global::QMag.Properties.Resources.minus;
			this.pictureBoxReduce.Location = new System.Drawing.Point(949, 30);
			this.pictureBoxReduce.Name = "pictureBoxReduce";
			this.pictureBoxReduce.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxReduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxReduce.TabIndex = 1;
			this.pictureBoxReduce.TabStop = false;
			this.pictureBoxReduce.Click += new System.EventHandler(this.pictureBoxReduce_Click);
			this.pictureBoxReduce.MouseEnter += new System.EventHandler(this.pictureBoxReduce_MouseEnter);
			this.pictureBoxReduce.MouseLeave += new System.EventHandler(this.pictureBoxReduce_MouseLeave);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pictureBoxClose.Image = global::QMag.Properties.Resources.close;
			this.pictureBoxClose.Location = new System.Drawing.Point(1011, 30);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClose.TabIndex = 0;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.buttonClose_Click);
			this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
			this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(49, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 88);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timerMenuDeroulant
			// 
			this.timerMenuDeroulant.Interval = 15;
			this.timerMenuDeroulant.Tick += new System.EventHandler(this.timerMenuDeroulant_Tick);
			// 
			// pictureBoxResize
			// 
			this.pictureBoxResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.pictureBoxResize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxResize.Image")));
			this.pictureBoxResize.Location = new System.Drawing.Point(1046, 667);
			this.pictureBoxResize.Name = "pictureBoxResize";
			this.pictureBoxResize.Size = new System.Drawing.Size(24, 24);
			this.pictureBoxResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxResize.TabIndex = 2;
			this.pictureBoxResize.TabStop = false;
			this.pictureBoxResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxResize_MouseDown);
			this.pictureBoxResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxResize_MouseMove);
			this.pictureBoxResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxResize_MouseUp);
			// 
			// menu_Clients_Consulter
			// 
			this.menu_Clients_Consulter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.menu_Clients_Consulter.FlatAppearance.BorderSize = 0;
			this.menu_Clients_Consulter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Clients_Consulter.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Clients_Consulter.ForeColor = System.Drawing.Color.White;
			this.menu_Clients_Consulter.Image = ((System.Drawing.Image)(resources.GetObject("menu_Clients_Consulter.Image")));
			this.menu_Clients_Consulter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Clients_Consulter.Location = new System.Drawing.Point(0, 70);
			this.menu_Clients_Consulter.Name = "menu_Clients_Consulter";
			this.menu_Clients_Consulter.Size = new System.Drawing.Size(275, 70);
			this.menu_Clients_Consulter.TabIndex = 10;
			this.menu_Clients_Consulter.Text = "   Consulter";
			this.menu_Clients_Consulter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Clients_Consulter.UseVisualStyleBackColor = false;
			this.menu_Clients_Consulter.Click += new System.EventHandler(this.Menu_Click);
			// 
			// menu_Clients_Ajouter
			// 
			this.menu_Clients_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
			this.menu_Clients_Ajouter.FlatAppearance.BorderSize = 0;
			this.menu_Clients_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Clients_Ajouter.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Clients_Ajouter.ForeColor = System.Drawing.Color.White;
			this.menu_Clients_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("menu_Clients_Ajouter.Image")));
			this.menu_Clients_Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Clients_Ajouter.Location = new System.Drawing.Point(0, 0);
			this.menu_Clients_Ajouter.Name = "menu_Clients_Ajouter";
			this.menu_Clients_Ajouter.Size = new System.Drawing.Size(275, 70);
			this.menu_Clients_Ajouter.TabIndex = 9;
			this.menu_Clients_Ajouter.Text = "   Ajouter";
			this.menu_Clients_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Clients_Ajouter.UseVisualStyleBackColor = false;
			this.menu_Clients_Ajouter.Click += new System.EventHandler(this.Menu_Click);
			// 
			// menu_Clients
			// 
			this.menu_Clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
			this.menu_Clients.Dock = System.Windows.Forms.DockStyle.Top;
			this.menu_Clients.FlatAppearance.BorderSize = 0;
			this.menu_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menu_Clients.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menu_Clients.ForeColor = System.Drawing.Color.White;
			this.menu_Clients.Image = ((System.Drawing.Image)(resources.GetObject("menu_Clients.Image")));
			this.menu_Clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menu_Clients.Location = new System.Drawing.Point(0, 280);
			this.menu_Clients.Name = "menu_Clients";
			this.menu_Clients.Size = new System.Drawing.Size(275, 70);
			this.menu_Clients.TabIndex = 11;
			this.menu_Clients.Text = "   Clients";
			this.menu_Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.menu_Clients.UseVisualStyleBackColor = false;
			this.menu_Clients.Click += new System.EventHandler(this.Menu_Click);
			// 
			// panelSousMenuClients
			// 
			this.panelSousMenuClients.Controls.Add(this.menu_Clients_Ajouter);
			this.panelSousMenuClients.Controls.Add(this.menu_Clients_Consulter);
			this.panelSousMenuClients.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSousMenuClients.Location = new System.Drawing.Point(0, 350);
			this.panelSousMenuClients.MaximumSize = new System.Drawing.Size(275, 140);
			this.panelSousMenuClients.Name = "panelSousMenuClients";
			this.panelSousMenuClients.Size = new System.Drawing.Size(275, 140);
			this.panelSousMenuClients.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1072, 693);
			this.Controls.Add(this.pictureBoxResize);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelContainer);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(1072, 693);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MySyno";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.panelMenu.ResumeLayout(false);
			this.panelSousMenuStock.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxReduce)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).EndInit();
			this.panelSousMenuClients.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
        private MenuFlatButton menu_Stock;
        private MenuFlatButton menu_Accueil;
        private MenuFlatButton menuFlatButtonClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxReduce;
        private System.Windows.Forms.Panel panelSousMenuStock;
        private MenuFlatButton menu_Stock_Consulter;
        private MenuFlatButton menu_Stock_Ajouter;
        private System.Windows.Forms.PictureBox pictureBoxResize;
        private System.Windows.Forms.Timer timerMenuDeroulant;
		private System.Windows.Forms.Panel panelSousMenuClients;
		private MenuFlatButton menu_Clients_Ajouter;
		private MenuFlatButton menu_Clients;
		private MenuFlatButton menu_Clients_Consulter;
	}
}

