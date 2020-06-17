namespace Pain_Version_0._3
{
    partial class Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOldProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shape = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.pentagon = new System.Windows.Forms.PictureBox();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.Square = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.PictureBox();
            this.Brush = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Palitra = new System.Windows.Forms.PictureBox();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pentagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palitra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(66, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.new2;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveUsToolStripMenuItem
            // 
            this.saveUsToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.save;
            this.saveUsToolStripMenuItem.Name = "saveUsToolStripMenuItem";
            this.saveUsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveUsToolStripMenuItem.Text = "&Save us";
            this.saveUsToolStripMenuItem.Click += new System.EventHandler(this.saveUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOldProjectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // openOldProjectToolStripMenuItem
            // 
            this.openOldProjectToolStripMenuItem.Name = "openOldProjectToolStripMenuItem";
            this.openOldProjectToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openOldProjectToolStripMenuItem.Text = "&Open Old Project";
            this.openOldProjectToolStripMenuItem.Click += new System.EventHandler(this.openOldProjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Pain_Version_0._3.Properties.Resources.help;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8px",
            "12px",
            "16px",
            "20px",
            "24px",
            "28px"});
            this.comboBox1.Location = new System.Drawing.Point(2, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big",
            "Very Big"});
            this.comboBox2.Location = new System.Drawing.Point(2, 359);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Small",
            "Big"});
            this.comboBox3.Location = new System.Drawing.Point(2, 300);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.shape);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.pentagon);
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.Square);
            this.panel2.Controls.Add(this.Circle);
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 101);
            this.panel2.TabIndex = 10;
            // 
            // shape
            // 
            this.shape.Image = global::Pain_Version_0._3.Properties.Resources.shape;
            this.shape.Location = new System.Drawing.Point(31, 67);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(26, 26);
            this.shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shape.TabIndex = 16;
            this.shape.TabStop = false;
            // 
            // line
            // 
            this.line.Image = global::Pain_Version_0._3.Properties.Resources.line;
            this.line.Location = new System.Drawing.Point(3, 67);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(26, 26);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.line.TabIndex = 15;
            this.line.TabStop = false;
            // 
            // pentagon
            // 
            this.pentagon.Image = global::Pain_Version_0._3.Properties.Resources.pentagon;
            this.pentagon.Location = new System.Drawing.Point(31, 35);
            this.pentagon.Name = "pentagon";
            this.pentagon.Size = new System.Drawing.Size(26, 26);
            this.pentagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pentagon.TabIndex = 14;
            this.pentagon.TabStop = false;
            // 
            // triangle
            // 
            this.triangle.Image = global::Pain_Version_0._3.Properties.Resources.triangle;
            this.triangle.Location = new System.Drawing.Point(3, 35);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(26, 26);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangle.TabIndex = 13;
            this.triangle.TabStop = false;
            // 
            // Square
            // 
            this.Square.Image = global::Pain_Version_0._3.Properties.Resources.Square;
            this.Square.Location = new System.Drawing.Point(31, 3);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(26, 26);
            this.Square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Square.TabIndex = 12;
            this.Square.TabStop = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Circle
            // 
            this.Circle.Image = global::Pain_Version_0._3.Properties.Resources.Circle;
            this.Circle.Location = new System.Drawing.Point(3, 3);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(26, 26);
            this.Circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Circle.TabIndex = 11;
            this.Circle.TabStop = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Brush
            // 
            this.Brush.Image = global::Pain_Version_0._3.Properties.Resources.brush;
            this.Brush.Location = new System.Drawing.Point(6, 268);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(26, 26);
            this.Brush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Brush.TabIndex = 8;
            this.Brush.TabStop = false;
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            this.Brush.MouseLeave += new System.EventHandler(this.Brush_MouseLeave);
            this.Brush.MouseHover += new System.EventHandler(this.Brush_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pain_Version_0._3.Properties.Resources.guma2;
            this.pictureBox3.Location = new System.Drawing.Point(6, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pain_Version_0._3.Properties.Resources.pensil;
            this.pictureBox1.Location = new System.Drawing.Point(6, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Palitra
            // 
            this.Palitra.Image = global::Pain_Version_0._3.Properties.Resources.palitra;
            this.Palitra.Location = new System.Drawing.Point(12, 27);
            this.Palitra.Name = "Palitra";
            this.Palitra.Size = new System.Drawing.Size(26, 26);
            this.Palitra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Palitra.TabIndex = 2;
            this.Palitra.TabStop = false;
            this.Palitra.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(3, 166);
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(57, 20);
            this.txt_ShapeSize.TabIndex = 0;
            this.txt_ShapeSize.Text = "100";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(709, 392);
            this.Controls.Add(this.txt_ShapeSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Palitra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pentagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palitra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox Palitra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem openOldProjectToolStripMenuItem;
        private System.Windows.Forms.PictureBox Brush;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox pentagon;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox shape;
        private System.Windows.Forms.TextBox txt_ShapeSize;
    }
}

