namespace Lab5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            ToolStripMenuFile = new ToolStripMenuItem();
            обєктиToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuPoint = new ToolStripMenuItem();
            ToolStripMenuLine = new ToolStripMenuItem();
            ToolStripMenuRectangle = new ToolStripMenuItem();
            ToolStripMenuEllipse = new ToolStripMenuItem();
            ToolStripMenuLineOO = new ToolStripMenuItem();
            ToolStripMenuCube = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuTable = new ToolStripMenuItem();
            ToolStripMenuOpen = new ToolStripMenuItem();
            ToolStripMenuClose = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            ToolStripButtonPoint = new ToolStripButton();
            ToolStripButtonLine = new ToolStripButton();
            ToolStripButtonRectangle = new ToolStripButton();
            ToolStripButtonEllipse = new ToolStripButton();
            ToolStripButtonLineOO = new ToolStripButton();
            ToolStripButtonCube = new ToolStripButton();
            pictureBox1 = new PictureBox();
            ToolStripMenuSave = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuFile, обєктиToolStripMenuItem, довідкаToolStripMenuItem, ToolStripMenuTable });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuFile
            // 
            ToolStripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuSave });
            ToolStripMenuFile.Name = "ToolStripMenuFile";
            ToolStripMenuFile.Size = new Size(59, 24);
            ToolStripMenuFile.Text = "Файл";
            // 
            // обєктиToolStripMenuItem
            // 
            обєктиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuPoint, ToolStripMenuLine, ToolStripMenuRectangle, ToolStripMenuEllipse, ToolStripMenuLineOO, ToolStripMenuCube });
            обєктиToolStripMenuItem.Name = "обєктиToolStripMenuItem";
            обєктиToolStripMenuItem.Size = new Size(75, 24);
            обєктиToolStripMenuItem.Text = "Об'єкти";
            // 
            // ToolStripMenuPoint
            // 
            ToolStripMenuPoint.Name = "ToolStripMenuPoint";
            ToolStripMenuPoint.Size = new Size(185, 26);
            ToolStripMenuPoint.Text = "Точка";
            ToolStripMenuPoint.Click += Point_Click;
            // 
            // ToolStripMenuLine
            // 
            ToolStripMenuLine.Name = "ToolStripMenuLine";
            ToolStripMenuLine.Size = new Size(185, 26);
            ToolStripMenuLine.Text = "Лінія";
            ToolStripMenuLine.Click += Line_Click;
            // 
            // ToolStripMenuRectangle
            // 
            ToolStripMenuRectangle.Name = "ToolStripMenuRectangle";
            ToolStripMenuRectangle.Size = new Size(185, 26);
            ToolStripMenuRectangle.Text = "Прямокутник";
            ToolStripMenuRectangle.Click += Rectangle_Click;
            // 
            // ToolStripMenuEllipse
            // 
            ToolStripMenuEllipse.Name = "ToolStripMenuEllipse";
            ToolStripMenuEllipse.Size = new Size(185, 26);
            ToolStripMenuEllipse.Text = "Еліпс";
            ToolStripMenuEllipse.Click += Ellipse_Click;
            // 
            // ToolStripMenuLineOO
            // 
            ToolStripMenuLineOO.Name = "ToolStripMenuLineOO";
            ToolStripMenuLineOO.Size = new Size(185, 26);
            ToolStripMenuLineOO.Text = "Відрізок";
            ToolStripMenuLineOO.Click += LineOO_Click;
            // 
            // ToolStripMenuCube
            // 
            ToolStripMenuCube.Name = "ToolStripMenuCube";
            ToolStripMenuCube.Size = new Size(185, 26);
            ToolStripMenuCube.Text = "Каркас куба";
            ToolStripMenuCube.Click += Cube_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(77, 24);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // ToolStripMenuTable
            // 
            ToolStripMenuTable.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpen, ToolStripMenuClose });
            ToolStripMenuTable.Name = "ToolStripMenuTable";
            ToolStripMenuTable.Size = new Size(82, 24);
            ToolStripMenuTable.Text = "Таблиця";
            // 
            // ToolStripMenuOpen
            // 
            ToolStripMenuOpen.Name = "ToolStripMenuOpen";
            ToolStripMenuOpen.Size = new Size(224, 26);
            ToolStripMenuOpen.Text = "Відкрити";
            ToolStripMenuOpen.Click += ToolStripMenuOpen_Click;
            // 
            // ToolStripMenuClose
            // 
            ToolStripMenuClose.Name = "ToolStripMenuClose";
            ToolStripMenuClose.Size = new Size(224, 26);
            ToolStripMenuClose.Text = "Закрити";
            ToolStripMenuClose.Click += ToolStripMenuClose_Click;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { ToolStripButtonPoint, ToolStripButtonLine, ToolStripButtonRectangle, ToolStripButtonEllipse, ToolStripButtonLineOO, ToolStripButtonCube });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // ToolStripButtonPoint
            // 
            ToolStripButtonPoint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonPoint.Image = (Image)resources.GetObject("ToolStripButtonPoint.Image");
            ToolStripButtonPoint.ImageTransparentColor = Color.Magenta;
            ToolStripButtonPoint.Name = "ToolStripButtonPoint";
            ToolStripButtonPoint.Size = new Size(29, 24);
            ToolStripButtonPoint.Text = "Точка";
            ToolStripButtonPoint.Click += Point_Click;
            // 
            // ToolStripButtonLine
            // 
            ToolStripButtonLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonLine.Image = (Image)resources.GetObject("ToolStripButtonLine.Image");
            ToolStripButtonLine.ImageTransparentColor = Color.Magenta;
            ToolStripButtonLine.Name = "ToolStripButtonLine";
            ToolStripButtonLine.Size = new Size(29, 24);
            ToolStripButtonLine.Text = "Лінія";
            ToolStripButtonLine.Click += Line_Click;
            // 
            // ToolStripButtonRectangle
            // 
            ToolStripButtonRectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonRectangle.Image = (Image)resources.GetObject("ToolStripButtonRectangle.Image");
            ToolStripButtonRectangle.ImageTransparentColor = Color.Magenta;
            ToolStripButtonRectangle.Name = "ToolStripButtonRectangle";
            ToolStripButtonRectangle.Size = new Size(29, 24);
            ToolStripButtonRectangle.Text = "Прямокутник";
            ToolStripButtonRectangle.Click += Rectangle_Click;
            // 
            // ToolStripButtonEllipse
            // 
            ToolStripButtonEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonEllipse.Image = (Image)resources.GetObject("ToolStripButtonEllipse.Image");
            ToolStripButtonEllipse.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEllipse.Name = "ToolStripButtonEllipse";
            ToolStripButtonEllipse.Size = new Size(29, 24);
            ToolStripButtonEllipse.Text = "Еліпс";
            ToolStripButtonEllipse.Click += Ellipse_Click;
            // 
            // ToolStripButtonLineOO
            // 
            ToolStripButtonLineOO.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonLineOO.Image = (Image)resources.GetObject("ToolStripButtonLineOO.Image");
            ToolStripButtonLineOO.ImageTransparentColor = Color.Magenta;
            ToolStripButtonLineOO.Name = "ToolStripButtonLineOO";
            ToolStripButtonLineOO.Size = new Size(29, 24);
            ToolStripButtonLineOO.Text = "Відрізок";
            ToolStripButtonLineOO.Click += LineOO_Click;
            // 
            // ToolStripButtonCube
            // 
            ToolStripButtonCube.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonCube.Image = (Image)resources.GetObject("ToolStripButtonCube.Image");
            ToolStripButtonCube.ImageTransparentColor = Color.Magenta;
            ToolStripButtonCube.Name = "ToolStripButtonCube";
            ToolStripButtonCube.Size = new Size(29, 24);
            ToolStripButtonCube.Text = "Каркас куба";
            ToolStripButtonCube.Click += Cube_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 392);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += MainForm_Paint;
            pictureBox1.MouseDown += MainForm_MouseDown;
            pictureBox1.MouseMove += MainForm_MouseMove;
            pictureBox1.MouseUp += MainForm_MouseUp;
            // 
            // ToolStripMenuSave
            // 
            ToolStripMenuSave.Name = "ToolStripMenuSave";
            ToolStripMenuSave.Size = new Size(224, 26);
            ToolStripMenuSave.Text = "Зберегти";
            ToolStripMenuSave.Click += ToolStripMenuSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Paint";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem ToolStripMenuFile;
        private ToolStripMenuItem обєктиToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuPoint;
        private ToolStripMenuItem ToolStripMenuLine;
        private ToolStripMenuItem ToolStripMenuRectangle;
        private ToolStripMenuItem ToolStripMenuEllipse;
        private ToolStripMenuItem ToolStripMenuLineOO;
        private ToolStripMenuItem ToolStripMenuCube;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton ToolStripButtonPoint;
        private ToolStripButton ToolStripButtonLine;
        private ToolStripButton ToolStripButtonRectangle;
        private ToolStripButton ToolStripButtonEllipse;
        private ToolStripButton ToolStripButtonLineOO;
        private ToolStripButton ToolStripButtonCube;
        private PictureBox pictureBox1;
        private ToolStripMenuItem ToolStripMenuTable;
        private ToolStripMenuItem ToolStripMenuOpen;
        private ToolStripMenuItem ToolStripMenuClose;
        private ToolStripMenuItem ToolStripMenuSave;
    }
}