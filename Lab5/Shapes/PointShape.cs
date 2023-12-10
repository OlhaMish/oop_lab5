using System.Drawing;

namespace Lab5.Shapes
{
    class PointShape : Shape
    {
        public PointShape(Point currentStartPoint, Point currentEndPoint, Color normalFillColor) :
                    base(currentStartPoint, currentEndPoint, normalFillColor)
        {
            ukr_name = "Точка";
        }
        public override void Show(Graphics g)
        {
            g.FillEllipse(Brushes.Black, startPoint.X, startPoint.Y, 3, 3);
        }
        public override Shape Clone()
        {
            return new PointShape(this.startPoint, this.endPoint, this._normalFillColor);
        }
    }
}
