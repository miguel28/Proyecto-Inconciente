namespace LevelEditor
{
    partial class diaLevelProperties
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
            this.lblGridWith = new System.Windows.Forms.Label();
            this.lblGridHeight = new System.Windows.Forms.Label();
            this.groupGrid = new System.Windows.Forms.GroupBox();
            this.numGridHeight = new System.Windows.Forms.NumericUpDown();
            this.numGridWidth = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupMapSize = new System.Windows.Forms.GroupBox();
            this.numMapHeight = new System.Windows.Forms.NumericUpDown();
            this.numMapWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridWidth)).BeginInit();
            this.groupMapSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGridWith
            // 
            this.lblGridWith.AutoSize = true;
            this.lblGridWith.Location = new System.Drawing.Point(6, 18);
            this.lblGridWith.Name = "lblGridWith";
            this.lblGridWith.Size = new System.Drawing.Size(44, 17);
            this.lblGridWith.TabIndex = 0;
            this.lblGridWith.Text = "Width";
            // 
            // lblGridHeight
            // 
            this.lblGridHeight.AutoSize = true;
            this.lblGridHeight.Location = new System.Drawing.Point(6, 52);
            this.lblGridHeight.Name = "lblGridHeight";
            this.lblGridHeight.Size = new System.Drawing.Size(49, 17);
            this.lblGridHeight.TabIndex = 1;
            this.lblGridHeight.Text = "Height";
            // 
            // groupGrid
            // 
            this.groupGrid.Controls.Add(this.numGridHeight);
            this.groupGrid.Controls.Add(this.numGridWidth);
            this.groupGrid.Controls.Add(this.lblGridWith);
            this.groupGrid.Controls.Add(this.lblGridHeight);
            this.groupGrid.Location = new System.Drawing.Point(12, 12);
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.Size = new System.Drawing.Size(220, 96);
            this.groupGrid.TabIndex = 2;
            this.groupGrid.TabStop = false;
            this.groupGrid.Text = "Grid Size";
            // 
            // numGridHeight
            // 
            this.numGridHeight.Location = new System.Drawing.Point(81, 52);
            this.numGridHeight.Name = "numGridHeight";
            this.numGridHeight.Size = new System.Drawing.Size(120, 22);
            this.numGridHeight.TabIndex = 3;
            this.numGridHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // numGridWidth
            // 
            this.numGridWidth.Location = new System.Drawing.Point(81, 22);
            this.numGridWidth.Name = "numGridWidth";
            this.numGridWidth.Size = new System.Drawing.Size(120, 22);
            this.numGridWidth.TabIndex = 2;
            this.numGridWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(157, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupMapSize
            // 
            this.groupMapSize.Controls.Add(this.numMapHeight);
            this.groupMapSize.Controls.Add(this.numMapWidth);
            this.groupMapSize.Controls.Add(this.label1);
            this.groupMapSize.Controls.Add(this.label2);
            this.groupMapSize.Location = new System.Drawing.Point(12, 114);
            this.groupMapSize.Name = "groupMapSize";
            this.groupMapSize.Size = new System.Drawing.Size(220, 96);
            this.groupMapSize.TabIndex = 4;
            this.groupMapSize.TabStop = false;
            this.groupMapSize.Text = "Map Size (Tiles)";
            // 
            // numMapHeight
            // 
            this.numMapHeight.Location = new System.Drawing.Point(81, 52);
            this.numMapHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMapHeight.Name = "numMapHeight";
            this.numMapHeight.Size = new System.Drawing.Size(120, 22);
            this.numMapHeight.TabIndex = 3;
            this.numMapHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numMapWidth
            // 
            this.numMapWidth.Location = new System.Drawing.Point(81, 22);
            this.numMapWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMapWidth.Name = "numMapWidth";
            this.numMapWidth.Size = new System.Drawing.Size(120, 22);
            this.numMapWidth.TabIndex = 2;
            this.numMapWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // diaLevelProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 266);
            this.Controls.Add(this.groupMapSize);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupGrid);
            this.Name = "diaLevelProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Properties";
            this.groupGrid.ResumeLayout(false);
            this.groupGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridWidth)).EndInit();
            this.groupMapSize.ResumeLayout(false);
            this.groupMapSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMapWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGridWith;
        private System.Windows.Forms.Label lblGridHeight;
        private System.Windows.Forms.GroupBox groupGrid;
        private System.Windows.Forms.NumericUpDown numGridHeight;
        private System.Windows.Forms.NumericUpDown numGridWidth;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupMapSize;
        private System.Windows.Forms.NumericUpDown numMapHeight;
        private System.Windows.Forms.NumericUpDown numMapWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}