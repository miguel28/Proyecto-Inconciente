namespace LevelEditor
{
    partial class frmLevelEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTileSets = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboxLayers = new System.Windows.Forms.ToolStripComboBox();
            this.btnAddLayer = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteLayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveImage = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolNavigator = new System.Windows.Forms.TabControl();
            this.tabTileSet = new System.Windows.Forms.TabPage();
            this.tlpTileset = new System.Windows.Forms.TableLayoutPanel();
            this.cboxTileSetSelect = new System.Windows.Forms.ComboBox();
            this.pnlTileSetScrollContainer = new System.Windows.Forms.Panel();
            this.picTileSet = new System.Windows.Forms.PictureBox();
            this.picSelectedTile = new System.Windows.Forms.PictureBox();
            this.tabCollisionMap = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.picLevelDesign = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolNavigator.SuspendLayout();
            this.tabTileSet.SuspendLayout();
            this.tlpTileset.SuspendLayout();
            this.pnlTileSetScrollContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelDesign)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelToolStripMenuItem,
            this.openLevelToolStripMenuItem,
            this.saveLevelToolStripMenuItem,
            this.closeLevelToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newLevelToolStripMenuItem
            // 
            this.newLevelToolStripMenuItem.Name = "newLevelToolStripMenuItem";
            this.newLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.newLevelToolStripMenuItem.Text = "New Level";
            this.newLevelToolStripMenuItem.Click += new System.EventHandler(this.newLevelToolStripMenuItem_Click);
            // 
            // openLevelToolStripMenuItem
            // 
            this.openLevelToolStripMenuItem.Name = "openLevelToolStripMenuItem";
            this.openLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.openLevelToolStripMenuItem.Text = "Open Level";
            this.openLevelToolStripMenuItem.Click += new System.EventHandler(this.openLevelToolStripMenuItem_Click);
            // 
            // saveLevelToolStripMenuItem
            // 
            this.saveLevelToolStripMenuItem.Enabled = false;
            this.saveLevelToolStripMenuItem.Name = "saveLevelToolStripMenuItem";
            this.saveLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.saveLevelToolStripMenuItem.Text = "Save Level";
            this.saveLevelToolStripMenuItem.Click += new System.EventHandler(this.saveLevelToolStripMenuItem_Click);
            // 
            // closeLevelToolStripMenuItem
            // 
            this.closeLevelToolStripMenuItem.Enabled = false;
            this.closeLevelToolStripMenuItem.Name = "closeLevelToolStripMenuItem";
            this.closeLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.closeLevelToolStripMenuItem.Text = "Close Level";
            this.closeLevelToolStripMenuItem.Click += new System.EventHandler(this.closeLevelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTileSets,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cboxLayers,
            this.btnAddLayer,
            this.btnDeleteLayer,
            this.toolStripSeparator2,
            this.btnSaveImage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1010, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTileSets
            // 
            this.btnAddTileSets.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTileSets.Image")));
            this.btnAddTileSets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTileSets.Name = "btnAddTileSets";
            this.btnAddTileSets.Size = new System.Drawing.Size(141, 44);
            this.btnAddTileSets.Text = "Load TileSets";
            this.btnAddTileSets.Click += new System.EventHandler(this.btnAddTileSets_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 44);
            this.toolStripLabel1.Text = "Layer";
            // 
            // cboxLayers
            // 
            this.cboxLayers.Name = "cboxLayers";
            this.cboxLayers.Size = new System.Drawing.Size(121, 47);
            this.cboxLayers.SelectedIndexChanged += new System.EventHandler(this.cboxLayers_SelectedIndexChanged);
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLayer.Image")));
            this.btnAddLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(44, 44);
            this.btnAddLayer.Text = "toolStripButton1";
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnDeleteLayer
            // 
            this.btnDeleteLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLayer.Image")));
            this.btnDeleteLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteLayer.Name = "btnDeleteLayer";
            this.btnDeleteLayer.Size = new System.Drawing.Size(44, 44);
            this.btnDeleteLayer.Text = "toolStripButton1";
            this.btnDeleteLayer.Click += new System.EventHandler(this.btnDeleteLayer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveImage.Image")));
            this.btnSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(142, 44);
            this.btnSaveImage.Text = "Export Image";
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolNavigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.picLevelDesign);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 499);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolNavigator
            // 
            this.toolNavigator.Controls.Add(this.tabTileSet);
            this.toolNavigator.Controls.Add(this.tabCollisionMap);
            this.toolNavigator.Controls.Add(this.tabEvents);
            this.toolNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolNavigator.Location = new System.Drawing.Point(0, 0);
            this.toolNavigator.Name = "toolNavigator";
            this.toolNavigator.SelectedIndex = 0;
            this.toolNavigator.Size = new System.Drawing.Size(322, 499);
            this.toolNavigator.TabIndex = 0;
            // 
            // tabTileSet
            // 
            this.tabTileSet.Controls.Add(this.tlpTileset);
            this.tabTileSet.Location = new System.Drawing.Point(4, 25);
            this.tabTileSet.Name = "tabTileSet";
            this.tabTileSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileSet.Size = new System.Drawing.Size(314, 470);
            this.tabTileSet.TabIndex = 0;
            this.tabTileSet.Text = "Tile Set";
            this.tabTileSet.UseVisualStyleBackColor = true;
            // 
            // tlpTileset
            // 
            this.tlpTileset.ColumnCount = 1;
            this.tlpTileset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTileset.Controls.Add(this.cboxTileSetSelect, 0, 0);
            this.tlpTileset.Controls.Add(this.pnlTileSetScrollContainer, 0, 1);
            this.tlpTileset.Controls.Add(this.panel1, 0, 2);
            this.tlpTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTileset.Location = new System.Drawing.Point(3, 3);
            this.tlpTileset.Name = "tlpTileset";
            this.tlpTileset.RowCount = 3;
            this.tlpTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTileset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTileset.Size = new System.Drawing.Size(308, 464);
            this.tlpTileset.TabIndex = 0;
            // 
            // cboxTileSetSelect
            // 
            this.cboxTileSetSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxTileSetSelect.FormattingEnabled = true;
            this.cboxTileSetSelect.Location = new System.Drawing.Point(3, 3);
            this.cboxTileSetSelect.Name = "cboxTileSetSelect";
            this.cboxTileSetSelect.Size = new System.Drawing.Size(302, 24);
            this.cboxTileSetSelect.TabIndex = 0;
            this.cboxTileSetSelect.SelectedIndexChanged += new System.EventHandler(this.cboxTileSetSelect_SelectedIndexChanged);
            // 
            // pnlTileSetScrollContainer
            // 
            this.pnlTileSetScrollContainer.AutoScroll = true;
            this.pnlTileSetScrollContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTileSetScrollContainer.Controls.Add(this.picTileSet);
            this.pnlTileSetScrollContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileSetScrollContainer.Location = new System.Drawing.Point(3, 33);
            this.pnlTileSetScrollContainer.Name = "pnlTileSetScrollContainer";
            this.pnlTileSetScrollContainer.Size = new System.Drawing.Size(302, 328);
            this.pnlTileSetScrollContainer.TabIndex = 1;
            // 
            // picTileSet
            // 
            this.picTileSet.Location = new System.Drawing.Point(3, 3);
            this.picTileSet.Name = "picTileSet";
            this.picTileSet.Size = new System.Drawing.Size(100, 50);
            this.picTileSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTileSet.TabIndex = 0;
            this.picTileSet.TabStop = false;
            this.picTileSet.Paint += new System.Windows.Forms.PaintEventHandler(this.picTileSet_Paint);
            this.picTileSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTileSet_MouseDown);
            this.picTileSet.MouseLeave += new System.EventHandler(this.picTileSet_MouseLeave);
            this.picTileSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTileSet_MouseMove);
            this.picTileSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTileSet_MouseUp);
            // 
            // picSelectedTile
            // 
            this.picSelectedTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectedTile.Location = new System.Drawing.Point(3, 5);
            this.picSelectedTile.Name = "picSelectedTile";
            this.picSelectedTile.Size = new System.Drawing.Size(142, 86);
            this.picSelectedTile.TabIndex = 2;
            this.picSelectedTile.TabStop = false;
            // 
            // tabCollisionMap
            // 
            this.tabCollisionMap.Location = new System.Drawing.Point(4, 25);
            this.tabCollisionMap.Name = "tabCollisionMap";
            this.tabCollisionMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollisionMap.Size = new System.Drawing.Size(314, 470);
            this.tabCollisionMap.TabIndex = 1;
            this.tabCollisionMap.Text = "Collision Map";
            this.tabCollisionMap.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(314, 470);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // picLevelDesign
            // 
            this.picLevelDesign.Location = new System.Drawing.Point(3, 5);
            this.picLevelDesign.Name = "picLevelDesign";
            this.picLevelDesign.Size = new System.Drawing.Size(100, 50);
            this.picLevelDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLevelDesign.TabIndex = 0;
            this.picLevelDesign.TabStop = false;
            this.picLevelDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.picLevelDesign_Paint);
            this.picLevelDesign.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picLevelDesign_MouseClick);
            this.picLevelDesign.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLevelDesign_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.picSelectedTile);
            this.panel1.Location = new System.Drawing.Point(3, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 94);
            this.panel1.TabIndex = 2;
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnPencil.Image")));
            this.btnPencil.Location = new System.Drawing.Point(151, 5);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(74, 86);
            this.btnPencil.TabIndex = 3;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(231, 5);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(68, 86);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelPropertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // levelPropertiesToolStripMenuItem
            // 
            this.levelPropertiesToolStripMenuItem.Enabled = false;
            this.levelPropertiesToolStripMenuItem.Name = "levelPropertiesToolStripMenuItem";
            this.levelPropertiesToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.levelPropertiesToolStripMenuItem.Text = "Level Properties";
            this.levelPropertiesToolStripMenuItem.Click += new System.EventHandler(this.levelPropertiesToolStripMenuItem_Click);
            // 
            // frmLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLevelEditor";
            this.Text = "Level Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolNavigator.ResumeLayout(false);
            this.tabTileSet.ResumeLayout(false);
            this.tlpTileset.ResumeLayout(false);
            this.pnlTileSetScrollContainer.ResumeLayout(false);
            this.pnlTileSetScrollContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevelDesign)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnAddTileSets;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl toolNavigator;
        private System.Windows.Forms.TabPage tabTileSet;
        private System.Windows.Forms.TabPage tabCollisionMap;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TableLayoutPanel tlpTileset;
        private System.Windows.Forms.ComboBox cboxTileSetSelect;
        private System.Windows.Forms.Panel pnlTileSetScrollContainer;
        private System.Windows.Forms.PictureBox picTileSet;
        private System.Windows.Forms.PictureBox picLevelDesign;
        private System.Windows.Forms.PictureBox picSelectedTile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboxLayers;
        private System.Windows.Forms.ToolStripButton btnAddLayer;
        private System.Windows.Forms.ToolStripButton btnDeleteLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSaveImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelPropertiesToolStripMenuItem;
    }
}

