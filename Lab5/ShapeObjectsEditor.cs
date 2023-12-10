using Lab5.Shapes;
using System.Collections.Generic;
using System.Drawing;

namespace Lab5
{
    class ShapeObjectsEditor
    {
        private static ShapeObjectsEditor? instance;

        private List<Shape> shapes = new List<Shape>();
        private bool isLBdown = false;

        private ShapeObjectsEditor() { }

        public static ShapeObjectsEditor GetInstance()
        {
            if (instance == null)
            {
                instance = new ShapeObjectsEditor();
            }
            return instance;
        }

        public void OnLBdown(Point location)
        {
            isLBdown = true;
            currentShape.startPoint = location;
            currentShape.SetRubber();
        }

        public void OnLBup(Point location)
        {
            currentShape.endPoint = location;
            currentShape.SetNormal();
            AddNewShapeToArray(currentShape.Clone());
            currentShape.startPoint = Point.Empty;
            currentShape.endPoint = Point.Empty;
            isLBdown = false;
        }

        public void OnMouseMove(Point location)
        {
            if (isLBdown)
            {
                currentShape.endPoint = location;
            }
        }

        public void OnPaint(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.SetNormal();
                shape.Show(g);
            }
            currentShape.Show(g);
        }

        public void AddNewShapeToArray(Shape shape)
        {
            shapes.Add(shape);
        }

        private Shape _currentShape = new PointShape(Point.Empty, Point.Empty, Color.Empty);
        public Shape currentShape
        {
            get { return _currentShape; }
            set { _currentShape = value; }
        }
    }
}
