using System.Drawing;

namespace Lab5.Shapes
{
    public abstract class Shape
    {
        protected Point _startPoint;
        private Point _endPoint;
        protected Color _fillColor;
        protected Color _outlineColor;
        protected Color _normalFillColor;
        protected Pen _pen = Pens.Black;
        protected string _ukr_name = "Фігура"; 

        public string ukr_name
        {
            get { return _ukr_name; }
            protected set { _ukr_name = value; }
        }
        public Point endPoint
        {
            get { return _endPoint; }
            set { _endPoint = value; }
        }
        public Point startPoint
        {
            get { return _startPoint; }
            set { _startPoint = value; }
        }

        public void SetRubber()
        {
            _fillColor = Color.Empty;
            SetRubberOutline();
        }
        public void SetNormal()
        {
            _fillColor = _normalFillColor;
            SetNormalOutline();
        }
        private void SetRubberOutline()
        {
            _pen = Pens.Black;
        }
        private void SetNormalOutline()
        {
            _pen = Pens.Black;
        }
        public Shape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor)
        {
            startPoint = currentStartPoint;
            endPoint = currentEndPoint;
            _normalFillColor = normalFillColor;
        }
        public abstract void Show(Graphics g);
        public abstract Shape Clone();
    }

}
