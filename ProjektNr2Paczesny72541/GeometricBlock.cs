using System.Drawing.Drawing2D;

namespace ProjektNr2Paczesny72541;

public class GeometricBlock
{
    public enum GeometricBlockType
    {
        Cone,
        Cylinder,
        Sphere,
        Pyramid, // Existing, might need to decide if this is generic or one of the new ones.
                 // Based on new requirements, we'll add specific ones.
                 // Let's assume this 'Pyramid' can be kept for now or removed if it causes conflict later.
GraniastosłupProsty,
            GraniastosłupPochyły,
            OstrosłupProsty,
            OstrosłupPochyły
    }

    public abstract class GeometricBlockBase
    {
        public int XsP { get; protected set; }
        public int YsP { get; protected set; }
        public Color LineColor { get; protected set; }
        public DashStyle LineStyle { get; protected set; }
        public float LineWidth { get; protected set; }
        public bool Visible { get; set; }
        protected float _currentRotationAngle = 0f; // Added for rotation (degrees)

        public abstract int Height { get; }
        public abstract GeometricBlockType Type { get; }
        public abstract float Volume { get; }
        public abstract float SurfaceArea { get; }

        public abstract void Draw(Graphics g);
        public abstract void Erase(Graphics g, Control control);
        public abstract void Move(Graphics g, Control control, int x, int y);

        // Made Rotate virtual to provide a base implementation for angle update
        public virtual void Rotate(Graphics g, Control control, int angleDelta)
        {
            _currentRotationAngle = (_currentRotationAngle + angleDelta) % 360;
            // The form/caller should invalidate the PictureBox to trigger a redraw
        }

        protected GeometricBlockBase(int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
        {
            XsP = x;
            YsP = y;
            LineColor = lineColor;
            LineStyle = lineStyle;
            LineWidth = lineWidth;
            Visible = true;
        }

        // Helper to get 2D projected point with perspective for base
        // Moved to GeometricBlockBase to access XsP and YsP
        protected PointF Project(Point3D p3d, int viewDepthFactor = 2)
        {
            // Simple perspective: objects further away (larger Z) appear smaller or shifted
            // For base drawing, we can simulate depth by squashing Y based on a pseudo-Z
            // This is a very simplified perspective for 2.5D
            float perspectiveRatio = p3d.Z / (float)viewDepthFactor; // Larger Z means more "depth" effect
            return new PointF(this.XsP + p3d.X, this.YsP + p3d.Y * (1 - perspectiveRatio * 0.3f)); // Adjust Y for perspective
        }

        // Helper struct for 3D points
        // Moved to be nested within GeometricBlockBase or accessible to it.
        // For simplicity, keeping it as a nested struct here.
        protected struct Point3D
        {
            public float X, Y, Z;
            public Point3D(float x, float y, float z) { X = x; Y = y; Z = z; }
        }
    }

    // Stożek
    public class ConeBlock : GeometricBlockBase
    {
        private int _radius;
        private int _height;
        private float _rotationAngle;

        public override int Height => _height;
        public override GeometricBlockType Type => GeometricBlockType.Cone;
        public override float Volume => (float)(Math.PI * _radius * _radius * _height / 3.0);
        public override float SurfaceArea => (float)(Math.PI * _radius * (_radius + Math.Sqrt(_height * _height + _radius * _radius)));

        public ConeBlock(int radius, int height, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
            : base(x, y, lineColor, lineStyle, lineWidth)
        {
            _radius = radius;
            _height = height;
            _rotationAngle = 0;
        }

        public override void Draw(Graphics g)
        {
            if (!Visible) return;

            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                pen.DashStyle = LineStyle;

                // Podstawa (elipsa)
                int ellipseWidth = _radius * 2;
                int ellipseHeight = _radius / 2;
                g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2, ellipseWidth, ellipseHeight);

                // Wierzchołek stożca
                int apexX = XsP;
                int apexY = YsP - _height;

                // Linie boczne
                g.DrawLine(pen, XsP - _radius, YsP, apexX, apexY);
                g.DrawLine(pen, XsP + _radius, YsP, apexX, apexY);

                // Środkowa linia (opcjonalna)
                using (Pen dashedPen = new Pen(LineColor, LineWidth * 0.5f))
                {
                    dashedPen.DashStyle = DashStyle.Dash;
                    g.DrawLine(dashedPen, XsP, YsP, apexX, apexY);
                }
            }
        }

        public override void Erase(Graphics g, Control control)
        {
            using (Pen pen = new Pen(control.BackColor, LineWidth + 2))
            {
                int ellipseWidth = _radius * 2;
                int ellipseHeight = _radius / 2;
                g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2, ellipseWidth, ellipseHeight);

                int apexX = XsP;
                int apexY = YsP - _height;

                g.DrawLine(pen, XsP - _radius, YsP, apexX, apexY);
                g.DrawLine(pen, XsP + _radius, YsP, apexX, apexY);
                g.DrawLine(pen, XsP, YsP, apexX, apexY);
            }
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            Erase(g, control);
            XsP = x;
            YsP = y;
            Draw(g);
        }

        public override void Rotate(Graphics g, Control control, int angle)
        {
            _rotationAngle += angle;
            // Dla stożka rotacja nie zmienia znacząco wyglądu
        }
    }

    // Walec
    public class CylinderBlock : GeometricBlockBase
    {
        private int _radius;
        private int _height;

        public override int Height => _height;
        public override GeometricBlockType Type => GeometricBlockType.Cylinder;
        public override float Volume => (float)(Math.PI * _radius * _radius * _height);
        public override float SurfaceArea => (float)(2 * Math.PI * _radius * (_radius + _height));

        public CylinderBlock(int radius, int height, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
            : base(x, y, lineColor, lineStyle, lineWidth)
        {
            _radius = radius;
            _height = height;
        }

        public override void Draw(Graphics g)
        {
            if (!Visible) return;

            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                pen.DashStyle = LineStyle;

                int ellipseWidth = _radius * 2;
                int ellipseHeight = _radius / 2;

                // Podstawa dolna
                g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2, ellipseWidth, ellipseHeight);

                // Podstawa górna
                g.DrawEllipse(pen, XsP - _radius, YsP - _height - ellipseHeight/2, ellipseWidth, ellipseHeight);

                // Linie boczne
                g.DrawLine(pen, XsP - _radius, YsP, XsP - _radius, YsP - _height);
                g.DrawLine(pen, XsP + _radius, YsP, XsP + _radius, YsP - _height);
            }
        }

        public override void Erase(Graphics g, Control control)
        {
            using (Pen pen = new Pen(control.BackColor, LineWidth + 2))
            {
                int ellipseWidth = _radius * 2;
                int ellipseHeight = _radius / 2;

                g.DrawEllipse(pen, XsP - _radius, YsP - ellipseHeight/2, ellipseWidth, ellipseHeight);
                g.DrawEllipse(pen, XsP - _radius, YsP - _height - ellipseHeight/2, ellipseWidth, ellipseHeight);
                g.DrawLine(pen, XsP - _radius, YsP, XsP - _radius, YsP - _height);
                g.DrawLine(pen, XsP + _radius, YsP, XsP + _radius, YsP - _height);
            }
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            Erase(g, control);
            XsP = x;
            YsP = y;
            Draw(g);
        }

        public override void Rotate(Graphics g, Control control, int angle)
        {
            // Walec wygląda tak samo po rotacji
        }
    }

    // Kula
    public class SphereBlock : GeometricBlockBase
    {
        private int _radius;

        public override int Height => _radius * 2;
        public override GeometricBlockType Type => GeometricBlockType.Sphere;
        public override float Volume => (float)(4.0/3.0 * Math.PI * _radius * _radius * _radius);
        public override float SurfaceArea => (float)(4 * Math.PI * _radius * _radius);

        public SphereBlock(int radius, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
            : base(x, y, lineColor, lineStyle, lineWidth)
        {
            _radius = radius;
        }

        public override void Draw(Graphics g)
        {
            if (!Visible) return;

            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                pen.DashStyle = LineStyle;

                // Główny okrąg
                g.DrawEllipse(pen, XsP - _radius, YsP - _radius, _radius * 2, _radius * 2);

                // Elipsa środkowa (równik)
                using (Pen dashedPen = new Pen(LineColor, LineWidth * 0.7f))
                {
                    dashedPen.DashStyle = DashStyle.Dash;
                    g.DrawEllipse(dashedPen, XsP - _radius, YsP - _radius/3, _radius * 2, _radius * 2/3);
                }
            }
        }

        public override void Erase(Graphics g, Control control)
        {
            using (Pen pen = new Pen(control.BackColor, LineWidth + 2))
            {
                g.DrawEllipse(pen, XsP - _radius, YsP - _radius, _radius * 2, _radius * 2);
                g.DrawEllipse(pen, XsP - _radius, YsP - _radius/3, _radius * 2, _radius * 2/3);
            }
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            Erase(g, control);
            XsP = x;
            YsP = y;
            Draw(g);
        }

        public override void Rotate(Graphics g, Control control, int angle)
        {
            // Kula wygląda tak samo po rotacji
        }
    }

    // Piramida
    public class PyramidBlock : GeometricBlockBase
    {
        private int _baseSize;
        private int _height;
        private int _sides;

        public override int Height => _height;
        public override GeometricBlockType Type => GeometricBlockType.Pyramid;
        public override float Volume => (float)(_baseSize * _baseSize * _height / 3.0);
        public override float SurfaceArea => (float)(_baseSize * _baseSize + 2 * _baseSize * Math.Sqrt((_baseSize/2.0)*(_baseSize/2.0) + _height*_height));

        public PyramidBlock(int baseSize, int height, int sides, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
            : base(x, y, lineColor, lineStyle, lineWidth)
        {
            _baseSize = baseSize;
            _height = height;
            _sides = Math.Max(3, sides);
        }

        public override void Draw(Graphics g)
        {
            if (!Visible) return;

            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                pen.DashStyle = LineStyle;

                int halfBase = _baseSize / 2;

                // Podstawa (prostokąt lub wielokąt)
                if (_sides == 4)
                {
                    // Kwadratowa podstawa
                    g.DrawRectangle(pen, XsP - halfBase, YsP - halfBase/2, _baseSize, halfBase);
                }
                else
                {
                    // Wielokątna podstawa (uproszczona jako elipsa)
                    g.DrawEllipse(pen, XsP - halfBase, YsP - halfBase/2, _baseSize, halfBase);
                }

                // Wierzchołek piramidy
                int apexX = XsP;
                int apexY = YsP - _height;

                // Linie do wierzchołka
                g.DrawLine(pen, XsP - halfBase, YsP - halfBase/2, apexX, apexY);
                g.DrawLine(pen, XsP + halfBase, YsP - halfBase/2, apexX, apexY);
                g.DrawLine(pen, XsP - halfBase, YsP, apexX, apexY);
                g.DrawLine(pen, XsP + halfBase, YsP, apexX, apexY);
            }
        }

        public override void Erase(Graphics g, Control control)
        {
            using (Pen pen = new Pen(control.BackColor, LineWidth + 2))
            {
                int halfBase = _baseSize / 2;

                if (_sides == 4)
                {
                    g.DrawRectangle(pen, XsP - halfBase, YsP - halfBase/2, _baseSize, halfBase);
                }
                else
                {
                    g.DrawEllipse(pen, XsP - halfBase, YsP - halfBase/2, _baseSize, halfBase);
                }

                int apexX = XsP;
                int apexY = YsP - _height;

                g.DrawLine(pen, XsP - halfBase, YsP - halfBase/2, apexX, apexY);
                g.DrawLine(pen, XsP + halfBase, YsP - halfBase/2, apexX, apexY);
                g.DrawLine(pen, XsP - halfBase, YsP, apexX, apexY);
                g.DrawLine(pen, XsP + halfBase, YsP, apexX, apexY);
            }
        }

        public override void Move(Graphics g, Control control, int x, int y)
        {
            Erase(g, control);
            XsP = x;
            YsP = y;
            Draw(g);
        }

        public override void Rotate(Graphics g, Control control, int angle)
        {
            // Dla piramidy można dodać rotację jeśli potrzebna
        }
    }

    // Helper method for rotating points (add this inside GeometricBlock class or as a static utility)
    // This can remain static or be moved to GeometricBlockBase if preferred.
    // Keeping it static within the GeometricBlock class for now.
    protected static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, float angleInDegrees)
    {
        float angleInRadians = angleInDegrees * (float)(Math.PI / 180.0);
        float cosTheta = (float)Math.Cos(angleInRadians);
        float sinTheta = (float)Math.Sin(angleInRadians);
        return new PointF
        {
            X = cosTheta * (pointToRotate.X - centerPoint.X) - sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X,
            Y = sinTheta * (pointToRotate.X - centerPoint.X) + cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y
        };
    }


    public abstract class bpGeometricBlockBase
        {
            public GeometricBlockType Type { get; protected set; }
            public int XsP { get; protected set; } // Środek podstawy X
            public int YsP { get; protected set; } // Środek podstawy Y
            public int Height { get; protected set; }
            public int Radius { get; protected set; } // Promień podstawy
            public int Slant { get; protected set; }  // Pochylenie dla brył pochyłych

            public Color LineColor { get; protected set; }
            public DashStyle LineStyle { get; protected set; }
            public float LineWidth { get; protected set; }

            public bool Visible { get; set; }
            protected float CurrentRotationAngle; // Kąt obrotu w stopniach
            protected int NumberOfSides = 6; // Ustalona liczba boków podstawy (sześciokąt)

            public bpGeometricBlockBase(int height, int radius, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
            {
                Height = height;
                Radius = radius;
                XsP = x;
                YsP = y;
                LineColor = lineColor;
                LineStyle = lineStyle;
                LineWidth = lineWidth;
                Visible = true;
                CurrentRotationAngle = 0f;
                Slant = 0; // Domyślnie brak pochylenia
            }

            public abstract void Draw(Graphics g);
            public virtual void Erase(Graphics g, Control control)
            {
                using (Pen erasePen = new Pen(control.BackColor, LineWidth + 1))
                {
                    Draw(g); // Rysowanie kolorem tła to de facto wymazywanie
                }
            }

            public void Rotate(float angle)
            {
                CurrentRotationAngle += angle;
                if (CurrentRotationAngle >= 360f) CurrentRotationAngle -= 360f;
                if (CurrentRotationAngle < 0f) CurrentRotationAngle += 360f;
            }

            public void Move(int x, int y)
            {
                XsP = x;
                YsP = y;
            }

            // Metody do zmiany atrybutów
            public void SetHeight(int height) { Height = height; }
            public void SetRadius(int radius) { Radius = radius; }
            public void SetSlant(int slant) { Slant = slant; }
            public void SetLineColor(Color color) { LineColor = color; }
            public void SetLineStyle(DashStyle style) { LineStyle = style; }
            public void SetLineWidth(float width) { LineWidth = width; }


            // Pomocnicza funkcja do obracania punktu wokół centrum
            protected PointF RotatePoint(PointF pointToRotate, PointF centerPoint, float angleInDegrees)
            {
                float angleInRadians = (float)(angleInDegrees * (System.Math.PI / 180));
                float cosTheta = (float)System.Math.Cos(angleInRadians);
                float sinTheta = (float)System.Math.Sin(angleInRadians);
                return new PointF
                {
                    X = cosTheta * (pointToRotate.X - centerPoint.X) - sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X,
                    Y = sinTheta * (pointToRotate.X - centerPoint.X) + cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y
                };
            }
        }

        // Klasy konkretnych brył

        public class bpRightPrism : bpGeometricBlockBase
        {
            public bpRightPrism(int height, int radius, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
                : base(height, radius, x, y, lineColor, lineStyle, lineWidth)
            {
                Type = GeometricBlockType.GraniastosłupProsty;
            }

            public override void Draw(Graphics g)
            {
                PointF[] bottomBase = new PointF[NumberOfSides];
                PointF[] topBase = new PointF[NumberOfSides];
                PointF centerPoint = new PointF(XsP, YsP);

                for (int i = 0; i < NumberOfSides; i++)
                {
                    float angle = (float)(2 * System.Math.PI / NumberOfSides * i);
                    PointF p = new PointF(XsP + Radius * (float)System.Math.Cos(angle), YsP + Radius * (float)System.Math.Sin(angle));
                    bottomBase[i] = RotatePoint(p, centerPoint, CurrentRotationAngle);
                    topBase[i] = RotatePoint(new PointF(p.X, p.Y - Height), new PointF(centerPoint.X, centerPoint.Y - Height), CurrentRotationAngle);
                }

                using (Pen pen = new Pen(LineColor, LineWidth) { DashStyle = LineStyle })
                {
                    g.DrawPolygon(pen, bottomBase);
                    g.DrawPolygon(pen, topBase);
                    for (int i = 0; i < NumberOfSides; i++)
                    {
                        g.DrawLine(pen, bottomBase[i], topBase[i]);
                    }
                }
            }
        }

        public class bpObliquePrism : bpGeometricBlockBase
        {
            public bpObliquePrism(int height, int radius, int slant, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
                : base(height, radius, x, y, lineColor, lineStyle, lineWidth)
            {
                Type = GeometricBlockType.GraniastosłupPochyły;
                Slant = slant;
            }

            public override void Draw(Graphics g)
            {
                PointF[] bottomBase = new PointF[NumberOfSides];
                PointF[] topBase = new PointF[NumberOfSides];
                PointF bottomCenter = new PointF(XsP, YsP);
                PointF topCenter = new PointF(XsP + Slant, YsP - Height);

                for (int i = 0; i < NumberOfSides; i++)
                {
                    float angle = (float)(2 * System.Math.PI / NumberOfSides * i);
                    PointF p = new PointF(XsP + Radius * (float)System.Math.Cos(angle), YsP + Radius * (float)System.Math.Sin(angle));
                    bottomBase[i] = RotatePoint(p, bottomCenter, CurrentRotationAngle);
                    topBase[i] = RotatePoint(new PointF(p.X + Slant, p.Y - Height), topCenter, CurrentRotationAngle);
                }

                using (Pen pen = new Pen(LineColor, LineWidth) { DashStyle = LineStyle })
                {
                    g.DrawPolygon(pen, bottomBase);
                    g.DrawPolygon(pen, topBase);
                    for (int i = 0; i < NumberOfSides; i++)
                    {
                        g.DrawLine(pen, bottomBase[i], topBase[i]);
                    }
                }
            }
        }

        public class bpRightPyramid : bpGeometricBlockBase
        {
            public bpRightPyramid(int height, int radius, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
                : base(height, radius, x, y, lineColor, lineStyle, lineWidth)
            {
                Type = GeometricBlockType.OstrosłupProsty;
            }

            public override void Draw(Graphics g)
            {
                PointF[] baseVertices = new PointF[NumberOfSides];
                PointF bottomCenter = new PointF(XsP, YsP);
                PointF apex = new PointF(XsP, YsP - Height);

                for (int i = 0; i < NumberOfSides; i++)
                {
                    float angle = (float)(2 * System.Math.PI / NumberOfSides * i);
                    PointF p = new PointF(XsP + Radius * (float)System.Math.Cos(angle), YsP + Radius * (float)System.Math.Sin(angle));
                    baseVertices[i] = RotatePoint(p, bottomCenter, CurrentRotationAngle);
                }

                PointF rotatedApex = RotatePoint(apex, new PointF(apex.X, bottomCenter.Y), CurrentRotationAngle);


                using (Pen pen = new Pen(LineColor, LineWidth) { DashStyle = LineStyle })
                {
                    g.DrawPolygon(pen, baseVertices);
                    foreach (PointF vertex in baseVertices)
                    {
                        g.DrawLine(pen, vertex, rotatedApex);
                    }
                }
            }
        }

        public class bpObliquePyramid : bpGeometricBlockBase
        {
            public bpObliquePyramid(int height, int radius, int slant, int x, int y, Color lineColor, DashStyle lineStyle, float lineWidth)
                : base(height, radius, x, y, lineColor, lineStyle, lineWidth)
            {
                Type = GeometricBlockType.OstrosłupPochyły;
                Slant = slant;
            }

            public override void Draw(Graphics g)
            {
                PointF[] baseVertices = new PointF[NumberOfSides];
                PointF bottomCenter = new PointF(XsP, YsP);
                PointF apex = new PointF(XsP + Slant, YsP - Height);

                for (int i = 0; i < NumberOfSides; i++)
                {
                    float angle = (float)(2 * System.Math.PI / NumberOfSides * i);
                    PointF p = new PointF(XsP + Radius * (float)System.Math.Cos(angle), YsP + Radius * (float)System.Math.Sin(angle));
                    baseVertices[i] = RotatePoint(p, bottomCenter, CurrentRotationAngle);
                }

                PointF rotatedApex = RotatePoint(apex, new PointF(apex.X, bottomCenter.Y), CurrentRotationAngle);

                using (Pen pen = new Pen(LineColor, LineWidth) { DashStyle = LineStyle })
                {
                    g.DrawPolygon(pen, baseVertices);
                    foreach (PointF vertex in baseVertices)
                    {
                        g.DrawLine(pen, vertex, rotatedApex);
                    }
                }
            }
        }
}
