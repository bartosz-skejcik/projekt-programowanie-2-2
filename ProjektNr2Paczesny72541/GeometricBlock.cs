using System.Drawing.Drawing2D;

namespace ProjektNr2Paczesny72541;

public class GeometricBlock
{
    const float RightAngle = 90f;

    public enum GeometricBlockType
    {
        Cylinder,
        Cone,
        Sphere,
        Pyramid,
        Prism,
    };

    public abstract class GeometricBlockBase
    {
        public int XsP { get; protected set; }
        public int YsP { get; protected set; }
        public Color LineColor { get; protected set; }
        public DashStyle LineStyle { get; protected set; }
        public float LineWidth { get; protected set; }
        public bool Visible { get; protected set; }
        public bool RotationDirection { get; protected set; }

        public abstract void Draw(Graphics g);
        public abstract void Erase(Graphics g, Control control);
        public abstract void Move(Graphics g, Control control, int x, int y);
        public abstract void Rotate(Graphics g, Control control, int angle);

        protected int _Height;
        public abstract int Height { get; protected set; }

        protected GeometricBlockType _Type;
        public abstract GeometricBlockType Type { get; protected set; }

        protected float _Volume;
        public abstract float Volume { get; protected set; }
        
        protected float _SurfaceArea;
        public abstract float SurfaceArea { get; protected set; }

        public void SetGraphicsAttributes(Color lineColor, DashStyle lineStyle, float lineWidth)
        {
            LineColor = lineColor;
            LineStyle = lineStyle;
            LineWidth = lineWidth;
        }
        
        protected GeometricBlockBase(Color lineColor, DashStyle lineStyle, float lineWidth)
        {
            LineColor = lineColor;
            LineStyle = lineStyle;
            LineWidth = lineWidth;
            Visible = true;
            RotationDirection = false;
        }
    }

    public class RevolvingBlock(int r, Color lineColor, DashStyle lineStyle, float lineWidth)
        : GeometricBlockBase(lineColor, lineStyle, lineWidth)
    {
        protected int _Radius = r;

        public override int Height
        {
            get => _Height;
            protected set => _Height = value;
        }

        public override GeometricBlockType Type
        {
            get => _Type;
            protected set => _Type = value;
        }

        public override float Volume
        {
            get => _Volume;
            protected set => _Volume = value;
        }

        public override float SurfaceArea
        {
            get => _SurfaceArea;
            protected set => _SurfaceArea = value;
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void Erase(Graphics g, Control control)
        {
            throw new NotImplementedException();
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void Rotate(Graphics g, Control control, int angle)
        {
            throw new NotImplementedException();
        }
    }

    public class PyramidBlock: RevolvingBlock
    {
        int XsS, YsS;
        // stopien wielokata
        int PolygonDegree;
        float BigAxis, SmallAxis;
        // kąt położenia
        float Angle;
        // kąt między wierzcholkami
        float SideAngle;
        Point[] polygonFloors;

        public PyramidBlock(int r, int height, int polygonDegree, int XsP, int YsP, Color lineColor, DashStyle lineStyle, float lineWidth): base(r, lineColor, lineStyle, lineWidth)
        {
            Height = height;
            PolygonDegree = polygonDegree;
            this.XsP = XsP;
            this.YsP = YsP;
            this.Type = GeometricBlockType.Pyramid;

            XsS = XsP;
            YsS = YsP - height;

            BigAxis = 2.0F * r;
            SmallAxis = r / 2.0F;

            Visible = false;

            Angle = 0.0F;
            SideAngle = 360.0F / PolygonDegree;
            polygonFloors = new Point[PolygonDegree + 1];
            for (int i = 0; i < PolygonDegree; i++)
            {
                // utworzenie egzemplarza point dla i-tego wierzchołka wielokąta
                polygonFloors[i] = new Point();
                polygonFloors[i].X = (int)(XsP + BigAxis / 2.0F * Math.Cos(Angle + i * SideAngle) / 100.0F);
                polygonFloors[i].Y = (int)(YsP + SmallAxis / 2.0F * Math.Cos(Angle + i * SideAngle) / 100.0F);
            }
            
            // wyznaczenie wartosci wlasciwosci abstrakcyjnych dla potrzeb Slajdera
            Volume = (float)(Math.PI * _Radius * _Radius * Height / 3.0F);
            SurfaceArea = (float)(Math.PI * _Radius * (_Radius + Math.Sqrt(Height * Height + _Radius * _Radius)));
        }

        public override void Draw(Graphics g)
        {
            using (Pen p = new Pen(LineColor, LineWidth))
            {
                g.DrawEllipse(p, XsP - BigAxis/2.0F, YsP - SmallAxis, BigAxis, SmallAxis);
                
                g.DrawLine(p, XsP - BigAxis/2.0F, YsP, XsS, YsS);
                g.DrawLine(p, XsP + BigAxis/2.0F, YsP, XsS, YsS);

                using (Pen p1 = new Pen(LineColor, LineWidth / 2.0F))
                {
                    p1.DashStyle = DashStyle.Dot;

                    for (int i = 0; i < PolygonDegree; i++)
                        g.DrawLine(p1, polygonFloors[i], new Point(XsS, YsS));
                }
            }
        }

        public override void Erase(Graphics g, Control control)
        {
            using (Pen p = new Pen(control.BackColor, LineWidth))
            {
                g.DrawEllipse(p, XsP - BigAxis/2.0F, YsP - SmallAxis, BigAxis, SmallAxis);
                
                g.DrawLine(p, XsP - BigAxis/2.0F, YsP, XsS, YsS);
                g.DrawLine(p, XsP + BigAxis/2.0F, YsP, XsS, YsS);

                using (Pen p1 = new Pen(control.BackColor, LineWidth / 2.0F))
                {
                    p1.DashStyle = DashStyle.Dot;

                    for (int i = 0; i < PolygonDegree; i++)
                        g.DrawLine(p1, polygonFloors[i], new Point(XsS, YsS));
                }
            }
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            base.Move(g, control, x, y);
        }
    }
}