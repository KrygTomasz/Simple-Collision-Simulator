using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Graphics canvas;
        private bool _isPainted = false;
        private List<Shape> _shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            canvas = splitContainer1.Panel2.CreateGraphics();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            createShapes(10);
            _isPainted = true;
            paint();
            timerMoving.Enabled = true;
            timerMoving.Start();
        }

        private void createShapes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _shapes.Add(RandomShapeFactory.createRandomShapeObject());
                createLastShapePosition();
                _shapes.Last().Field = canvas;
            }
        }

        private void createLastShapePosition()
        {
            RandomSingleton randomSingleton = RandomSingleton.Instance;
            for (int j = 0; j < _shapes.Count - 1; j++)
            {
                while (pointsDistance(_shapes.Last().MiddlePoint, _shapes[j].MiddlePoint) <= _shapes.Last().Width / 2 + _shapes[j].Width / 2)
                {
                    int randomXPos = randomSingleton.Random.Next((splitContainer1.Panel2.Width - (int)EnumValue.values.maxShapeSize));
                    int randomYPos = randomSingleton.Random.Next((splitContainer1.Panel2.Height - (int)EnumValue.values.maxShapeSize));
                    _shapes.Last().HoldPoint = new Point(randomXPos, randomYPos);
                }
            }

        }

        private double pointsDistance(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
        }

        private void paint()
        {
            foreach (Shape shape in _shapes)
            {
                shape.Paint();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            canvas.Clear(Color.DarkGreen);
            if(_isPainted) paint();
        }

        private void timerMoving_Tick(object sender, EventArgs e)
        {
            foreach (Shape shape in _shapes)
            {
                shape.checkBoundariesCollision();
                shape.checkCollisionWithShapeList(_shapes);
                shape.moveShape();
            }
            splitContainer1.Panel2.Invalidate();
            Invalidate();
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            int dpi = (int)canvas.DpiX;
            double circleArea = AreaCalculator.circlesArea(_shapes, dpi);
            double squareArea = AreaCalculator.squaresArea(_shapes, dpi);
            double rectangleArea = AreaCalculator.rectanglesArea(_shapes, dpi);
            labelCircleAreaCalculated.Text = circleArea.ToString() + " cm2";
            labelSquareAreaCalculated.Text = squareArea.ToString() + " cm2";
            labelRectangleAreaCalculated.Text = rectangleArea.ToString() + " cm2";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _shapes.Clear();
        }

        protected override CreateParams CreateParams // nie miga
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
