using Lab5.Shapes;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MainForm : Form
    {
        private TableForm tableForm;
        public MainForm()
        {
            InitializeComponent();

            ToolStripMenuPoint.Click += Point_Click;
            ToolStripMenuLine.Click += Line_Click;
            ToolStripMenuRectangle.Click += Rectangle_Click;
            ToolStripMenuEllipse.Click += Ellipse_Click;
            ToolStripMenuLineOO.Click += LineOO_Click;
            ToolStripMenuCube.Click += Cube_Click;
            Paint += MainForm_Paint;
        }

        private void SelectCurrentButtonItem(ToolStripButton currentItem)
        {
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripButton button)
                {
                    button.Checked = false;
                }
            }
            currentItem.Checked = true;
        }
        private void SelectCurrentMenuItem(ToolStripMenuItem currentItem)
        {
            foreach (ToolStripMenuItem topLevelItem in menuStrip.Items)
            {
                // Перший рівень пунктів меню
                if (topLevelItem is ToolStripMenuItem topLevelMenuItem)
                {
                    foreach (ToolStripItem item in topLevelMenuItem.DropDownItems)
                    {
                        // Підпункти меню
                        if (item is ToolStripMenuItem menuItem)
                        {
                            menuItem.Checked = false;
                        }
                    }
                }
            }
            currentItem.Checked = true;
        }
        private void Point_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonPoint);
            SelectCurrentMenuItem(ToolStripMenuPoint);
            ShapeObjectsEditor.GetInstance().currentShape = new PointShape(Point.Empty, Point.Empty, Color.Empty);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonLine);
            SelectCurrentMenuItem(ToolStripMenuLine);
            ShapeObjectsEditor.GetInstance().currentShape = new LineShape(Point.Empty, Point.Empty, Color.Empty);
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonRectangle);
            SelectCurrentMenuItem(ToolStripMenuRectangle);
            ShapeObjectsEditor.GetInstance().currentShape = new RectangleShape(Point.Empty, Point.Empty, Color.Orange);
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonEllipse);
            SelectCurrentMenuItem(ToolStripMenuEllipse);
            ShapeObjectsEditor.GetInstance().currentShape = new EllipseShape(Point.Empty, Point.Empty, Color.White);
        }

        private void LineOO_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonLineOO);
            SelectCurrentMenuItem(ToolStripMenuLineOO);
            ShapeObjectsEditor.GetInstance().currentShape = new LineOOShape(Point.Empty, Point.Empty, Color.Empty);
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            SelectCurrentButtonItem(ToolStripButtonCube);
            SelectCurrentMenuItem(ToolStripMenuCube);
            ShapeObjectsEditor.GetInstance().currentShape = new CubeShape(Point.Empty, Point.Empty, Color.Empty);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ShapeObjectsEditor.GetInstance().OnPaint(g);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ShapeObjectsEditor.GetInstance().OnLBdown(e.Location);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            Table.GetInstance().AddShapeInfo(ShapeObjectsEditor.GetInstance().currentShape.startPoint, e.Location, ShapeObjectsEditor.GetInstance().currentShape.ukr_name);
            ShapeObjectsEditor.GetInstance().OnLBup(e.Location);
            Refresh();
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            ShapeObjectsEditor.GetInstance().OnMouseMove(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                Refresh();
            }
        }

        private void ToolStripMenuClose_Click(object sender, EventArgs e)
        {
            if (tableForm != null)
            {
                tableForm.Close();
            }
        }

        private void ToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            this.tableForm = tableForm;
            tableForm.Show(this);
        }

        private void ToolStripMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Data to Text File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Table.GetInstance().SaveDataToTextFile(filePath);
            }
        }
    
}
}
