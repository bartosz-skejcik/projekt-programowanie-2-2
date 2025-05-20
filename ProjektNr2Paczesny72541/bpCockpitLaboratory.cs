namespace ProjektNr2Paczesny72541;

using System.Drawing.Drawing2D;

public partial class bpCockpitLaboratory : Form
{
    private const int FormMargin = 20;
    private const int Gap = 10;

    private Graphics DrawingBoard;
    
    public bpCockpitLaboratory()
    {
        InitializeComponent();
        Console.WriteLine("Component initialized");
        
        LayoutControls();

        Resize += (sender, e) => LayoutControls();
    }

    private void LayoutControls()
    {
        // Set form position and size
        Location = new Point(Screen.PrimaryScreen.Bounds.X + FormMargin, Screen.PrimaryScreen.Bounds.Y + FormMargin);
        
        StartPosition = FormStartPosition.Manual;
        
        AutoScroll = true;

        // Set left column width to 20% of form width
        int leftColumnWidth = (int)(Width * 0.3) - (FormMargin * 2);
        
        // Layout block list group box
        bpGrBoxBlockList.Location = new Point(FormMargin, FormMargin);
        bpGrBoxBlockList.Width = leftColumnWidth;
        bpGrBoxBlockList.Height = (int)(Height * 0.1);
        
        // Layout geometric attributes group box
        bpGrBoxGeometricAttrs.Location = new Point(FormMargin, bpGrBoxBlockList.Bottom + Gap);
        bpGrBoxGeometricAttrs.Width = leftColumnWidth;
        bpGrBoxGeometricAttrs.Height = (int)(Height * 0.5);

        // Layout graphic attributes group box
        bpGrBoxGraphicAttrs.Location = new Point(FormMargin, bpGrBoxGeometricAttrs.Bottom + Gap);
        bpGrBoxGraphicAttrs.Width = leftColumnWidth;
        bpGrBoxGraphicAttrs.Height = (int)(Height * 0.25);

        // Calculate right column width
        int rightColumnWidth = Width - leftColumnWidth - (FormMargin * 3) - Gap;
        
        // Layout picture box
        bpPictureBox.Location = new Point(bpGrBoxBlockList.Right + Gap, FormMargin);
        bpPictureBox.Width = rightColumnWidth;
        bpPictureBox.Height = (int)(Height * 0.75);

        // Layout bottom controls
        int bottomControlsY = bpPictureBox.Bottom + Gap;
        int bottomHeight = (int)(Height * 0.1);
        
        bpBtnAddSelectedBlock.Location = new Point(bpGrBoxBlockList.Right + Gap, bottomControlsY);
        bpBtnAddSelectedBlock.Height = bottomHeight;
        bpBtnAddSelectedBlock.Width = (int)(rightColumnWidth * 0.2);
        
        bpGrBoxBlockVisibilityCriteria.Location = new Point(bpBtnAddSelectedBlock.Right + Gap, bottomControlsY);
        bpGrBoxBlockVisibilityCriteria.Height = bottomHeight;
        bpGrBoxBlockVisibilityCriteria.Width = (int)(rightColumnWidth * 0.5);
        
        bpGrBoxBlockOrdering.Location = new Point(bpGrBoxBlockVisibilityCriteria.Right + Gap, bottomControlsY);
        bpGrBoxBlockOrdering.Height = bottomHeight;
        bpGrBoxBlockOrdering.Width = Width - bpGrBoxBlockOrdering.Left - FormMargin;

        // Recreate drawing surface whenever the form is resized
        if (bpPictureBox.Image != null)
        {
            bpPictureBox.Image.Dispose();
            DrawingBoard.Dispose();
        }
        
        bpPictureBox.Image = new Bitmap(bpPictureBox.Width, bpPictureBox.Height);
        DrawingBoard = Graphics.FromImage(bpPictureBox.Image);
        DrawingBoard.SmoothingMode = SmoothingMode.AntiAlias;
        DrawingBoard.Clear(Color.White);

        bpTBarBlockHeight.Maximum = bpPictureBox.Height / 2;
        bpTBarBlockHeight.Value = bpTBarBlockHeight.Maximum / 2;
        
        bpTBarBlockRadius.Maximum = bpPictureBox.Width / 2;
        bpTBarBlockRadius.Value = bpTBarBlockRadius.Maximum / 2;
    }

    private void bpCockpitLaboratory_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Czy na pewno chcesz zamknąć formularz projektu laboratoryjnego?", 
            "Potwierdzenie zamknięcia",
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            bpCockpit cockpitForm = new bpCockpit();
            cockpitForm.Show();
        }
        else
        {
            e.Cancel = true;
        }
    }

    private void bpTBarBlockHeight_ValueChanged(object sender, EventArgs e)
    {
        int currentValue = bpTBarBlockHeight.Value;
        
        Console.WriteLine($"[ZMIANA] Wysokość bloku: {currentValue}");
        
        bpTxtBlockHeight.Text = currentValue.ToString();
    }

    private void bpTBarBlockRadius_ValueChanged(object sender, EventArgs e)
    {
        int currentValue = bpTBarBlockRadius.Value;
        
        Console.WriteLine($"[ZMIANA] Promień bloku: {currentValue}");

        bpTxtBlockRadius.Text = currentValue.ToString();
    }

    private void bpTBarBlockAngle_ValueChanged(object sender, EventArgs e)
    {
        int currentValue = bpTBarBlockAngle.Value;
        
        Console.WriteLine($"[ZMIANA] Kąt bloku: {currentValue}");
        
        bpTxtBlockAngle.Text = currentValue.ToString();
    }
}
