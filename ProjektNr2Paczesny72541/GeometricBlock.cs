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
        public int Xsp { get; protected set; }
        public int Ysp { get; protected set; }
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
}