namespace ProjektNr2Paczesny72541;

using System.Drawing.Drawing2D;

public partial class bpCockpitLaboratory : Form
{
    private const int FormMargin = 20;
    private const int Gap = 10;    private Graphics? DrawingBoard;

    private Point BlockLocationPoint = new Point(-1, -1);    List<GeometricBlock.GeometricBlockBase> LBG = new List<GeometricBlock.GeometricBlockBase>();

    public static GeometricBlock.GeometricBlockBase? SelectedBlock;

    // Enumerator dla kryteriów sortowania
    public enum SortingCriteria
    {
        Height,
        Volume,
        SurfaceArea
    }

    // Właściwości do śledzenia wybranego kryterium i kolejności sortowania
    private SortingCriteria currentSortingCriteria = SortingCriteria.Height;
    private bool isAscendingOrder = true;

    public bpCockpitLaboratory()
    {
        InitializeComponent();
        Console.WriteLine("Component initialized");

        // Dodajemy event handlery dla radio buttonów
        SetupEventHandlers();

        LayoutControls();

        Resize += (sender, e) => LayoutControls();
    }

    private void SetupEventHandlers()
    {        // Inicjalizujemy ComboBox z typami brył
        bpCBoxBlockType.Items.Clear();
        bpCBoxBlockType.Items.Add("Stożek");
        bpCBoxBlockType.Items.Add("Walec");
        bpCBoxBlockType.Items.Add("Kula");
        bpCBoxBlockType.Items.Add("Piramida");
        bpCBoxBlockType.SelectedIndex = 0;

        // Inicjalizujemy ComboBox ze stylami linii
        bpCBoxLineStyle.Items.Clear();
        bpCBoxLineStyle.Items.Add("Ciągła");
        bpCBoxLineStyle.Items.Add("Kreskowana");
        bpCBoxLineStyle.Items.Add("Kropkowana");
        bpCBoxLineStyle.Items.Add("Kreska-kropka");
        bpCBoxLineStyle.Items.Add("Kreska-kropka-kropka");
        bpCBoxLineStyle.SelectedIndex = 0;

        // Inicjalizujemy NumericUpDown
        bpNumUpDownBlockSidesNumber.Minimum = 3;
        bpNumUpDownBlockSidesNumber.Maximum = 20;
        bpNumUpDownBlockSidesNumber.Value = 6;

        bpNumUpDownLineWidth.Minimum = 1;
        bpNumUpDownLineWidth.Maximum = 10;
        bpNumUpDownLineWidth.Value = 2;

        // Event handlery dla kryteriów sortowania
        bpRBtnBlockHeight.CheckedChanged += OnSortingCriteriaChanged;
        bpRBtnBlockVolume.CheckedChanged += OnSortingCriteriaChanged;
        bpRBtnBlockSurfaceArea.CheckedChanged += OnSortingCriteriaChanged;        // Event handlery dla kolejności sortowania
        bpRBtnBlockOrderIncreasing.CheckedChanged += OnSortingOrderChanged;
        bpRBtnBlockOrderDecreasing.CheckedChanged += OnSortingOrderChanged;        // Event handler dla przycisku wyboru koloru
        bpBtnBlockLineColor.Click += BpBtnBlockLineColor_Click;        // Event handlery dla przycisków slidera
        bpBtnTurnOnSlider.Click += BpBtnTurnOnSlider_Click;
        bpBtnTurnOffSlider.Click += BpBtnTurnOffSlider_Click;
        bpBtnNext.Click += BpBtnNext_Click;
        bpBtnPrevious.Click += BpBtnPrevious_Click;

        // Event handlery dla przycisków usuwania brył
        bpBtnRemoveFirstAddedBlock.Click += BpBtnRemoveFirstAddedBlock_Click;
        bpBtnRemoveRecentBlock.Click += BpBtnRemoveRecentBlock_Click;
        bpBtnRemoveSelectedBlock.Click += BpBtnRemoveSelectedBlock_Click;

        // Event handlery dla przycisków usuwania brył
        bpBtnRemoveFirstAddedBlock.Click += BpBtnRemoveFirstAddedBlock_Click;
        bpBtnRemoveRecentBlock.Click += BpBtnRemoveRecentBlock_Click;
        bpBtnRemoveSelectedBlock.Click += BpBtnRemoveSelectedBlock_Click;

        // Ustawiamy domyślne wartości
        bpRBtnBlockHeight.Checked = true;
        bpRBtnBlockOrderIncreasing.Checked = true;

        // Domyślny kolor linii
        bpTxtBlockLineColor.BackColor = Color.Black;

        // Inicjalizujemy pola tekstowe
        bpTxtBlockNumber.Text = "0";
        bpTxtSelectedBlock.Text = "Brak";
    }
    private void OnSortingCriteriaChanged(object? sender, EventArgs e)
    {
        RadioButton? radioButton = sender as RadioButton;
        if (radioButton?.Checked == true)
        {
            if (radioButton == bpRBtnBlockHeight)
                currentSortingCriteria = SortingCriteria.Height;
            else if (radioButton == bpRBtnBlockVolume)
                currentSortingCriteria = SortingCriteria.Volume;
            else if (radioButton == bpRBtnBlockSurfaceArea)
                currentSortingCriteria = SortingCriteria.SurfaceArea;

            Console.WriteLine($"[ZMIANA] Kryterium sortowania: {currentSortingCriteria}");
            SortAndRedrawBlocks();
        }
    }

    private void OnSortingOrderChanged(object? sender, EventArgs e)
    {
        RadioButton? radioButton = sender as RadioButton;
        if (radioButton?.Checked == true)
        {
            isAscendingOrder = radioButton == bpRBtnBlockOrderIncreasing;
            Console.WriteLine($"[ZMIANA] Kolejność sortowania: {(isAscendingOrder ? "rosnąco" : "malejąco")}");
            SortAndRedrawBlocks();
        }
    }

    private void SortAndRedrawBlocks()
    {
        if (LBG.Count <= 1) return; // Nie ma co sortować

        // Sortujemy listę zgodnie z wybranym kryterium
        switch (currentSortingCriteria)
        {
            case SortingCriteria.Height:
                LBG = isAscendingOrder
                    ? LBG.OrderBy(block => block.Height).ToList()
                    : LBG.OrderByDescending(block => block.Height).ToList();
                break;

            case SortingCriteria.Volume:
                LBG = isAscendingOrder
                    ? LBG.OrderBy(block => block.Volume).ToList()
                    : LBG.OrderByDescending(block => block.Volume).ToList();
                break;

            case SortingCriteria.SurfaceArea:
                LBG = isAscendingOrder
                    ? LBG.OrderBy(block => block.SurfaceArea).ToList()
                    : LBG.OrderByDescending(block => block.SurfaceArea).ToList();
                break;
        }        // Odświeżamy rysunek
        RedrawAllBlocks();

        Console.WriteLine($"[SORTOWANIE] Posortowano {LBG.Count} brył według {currentSortingCriteria}, kolejność: {(isAscendingOrder ? "rosnąco" : "malejąco")}");

        // Wyświetlamy listę brył w kolejności sortowania
        for (int i = 0; i < LBG.Count; i++)
        {
            var block = LBG[i];
            Console.WriteLine($"  {i + 1}. Wysokość: {block.Height}, Objętość: {block.Volume:F2}, Powierzchnia: {block.SurfaceArea:F2}");
        }

    }

    private void RedrawAllBlocks()
    {
        if (DrawingBoard == null || bpPictureBox.Image == null) return;

        // Czyścimy powierzchnię rysowania
        DrawingBoard.Clear(Color.White);

        // Rysujemy wszystkie bryły w nowej kolejności
        foreach (var block in LBG)
        {
            block.Draw(DrawingBoard);
        }

        bpPictureBox.Refresh();
    }
    private void LayoutControls()
    {
        AutoScroll = true;

        // Recreate drawing surface whenever the form is resized
        if (bpPictureBox.Image != null)
        {
            bpPictureBox.Image.Dispose();
            DrawingBoard?.Dispose();
        }

        bpPictureBox.Image = new Bitmap(bpPictureBox.Width, bpPictureBox.Height);
        DrawingBoard = Graphics.FromImage(bpPictureBox.Image);
        DrawingBoard.SmoothingMode = SmoothingMode.AntiAlias;
        DrawingBoard.Clear(Color.White);

        bpTBarBlockHeight.Maximum = bpPictureBox.Height / 2;
        bpTBarBlockHeight.Value = bpTBarBlockHeight.Maximum / 2;

        bpTBarBlockRadius.Maximum = bpPictureBox.Width / 2;
        bpTBarBlockRadius.Value = bpTBarBlockRadius.Maximum / 2;

        // zegar obrotu
        // timer1.Enabled = true;

        // zegar slidera
        timer2.Tag = 0;
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
    }    private void timer2_Tick(object sender, EventArgs e)
    {
        // Slider functionality - pokazuje pojedyncze bryły w kolejności sortowania
        if (LBG.Count == 0) return;

        int currentBlockIndex = (int)(timer2.Tag ?? 0);

        // Czyścimy ekran
        if (DrawingBoard != null)
        {
            DrawingBoard.Clear(Color.White);

            // Pokazujemy tylko aktualną bryłę
            if (currentBlockIndex < LBG.Count)
            {
                var currentBlock = LBG[currentBlockIndex];
                currentBlock.Draw(DrawingBoard);

                // Aktualizujemy pola tekstowe
                bpTxtBlockNumber.Text = (currentBlockIndex + 1).ToString();
                bpTxtSelectedBlock.Text = $"{currentBlock.Type} {currentBlockIndex + 1}";

                Console.WriteLine($"[SLIDER] Pokazano {currentBlock.Type} {currentBlockIndex + 1}: H={currentBlock.Height}, V={currentBlock.Volume:F2}, S={currentBlock.SurfaceArea:F2}");
            }

            bpPictureBox.Refresh();
        }

        // Przejście do następnej bryły
        currentBlockIndex = (currentBlockIndex + 1) % LBG.Count;
        timer2.Tag = currentBlockIndex;
    }private void timer1_Tick(object sender, EventArgs e)
    {
        if (DrawingBoard == null) return;

        float RotationalAngle = 5.0F;

        for (int i = 0; i < LBG.Count; i++)
        {
            LBG[i].Rotate(DrawingBoard, bpPictureBox, (int)RotationalAngle);
        }

        bpPictureBox.Refresh();

    }    // bpPictureBox_MouseClick
    private void bpPictureBox_MouseClick(object sender, MouseEventArgs e)
    {
        if (DrawingBoard == null) return;

        // Sprawdzamy czy kliknięto prawym przyciskiem myszy - usuwanie bryły
        if (e.Button == MouseButtons.Right)
        {
            // Szukamy bryły pod kursorem
            int clickedBlockIndex = FindBlockAtPosition(e.X, e.Y);
            if (clickedBlockIndex >= 0)
            {
                var blockToRemove = LBG[clickedBlockIndex];
                var result = MessageBox.Show(
                    $"Czy chcesz usunąć bryłę {blockToRemove.Type} #{clickedBlockIndex + 1}?",
                    "Potwierdzenie usunięcia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LBG.RemoveAt(clickedBlockIndex);
                    Console.WriteLine($"[USUNIĘTO] Bryłę przez kliknięcie PPM: {blockToRemove.Type} #{clickedBlockIndex + 1}. Pozostało: {LBG.Count} brył");

                    if (LBG.Count > 0)
                    {
                        SortAndRedrawBlocks();
                    }
                    else
                    {
                        DrawingBoard.Clear(Color.White);
                        bpPictureBox.Refresh();
                        bpTxtBlockNumber.Text = "0";
                        bpTxtSelectedBlock.Text = "Brak";
                        bpGrBoxBlockVisibilityCriteria.Enabled = false;
                        bpGrBoxBlockOrdering.Enabled = false;
                        timer2.Enabled = false;
                    }
                }
            }
            return;
        }

        // Lewy przycisk myszy - dodawanie bryły (istniejąca funkcjonalność)
        SolidBrush Brush = new SolidBrush(bpPictureBox.BackColor);

        if (BlockLocationPoint.X != -1 && BlockLocationPoint.Y != -1)
        {
            DrawingBoard.FillEllipse(Brush, BlockLocationPoint.X, BlockLocationPoint.Y, 6, 6);
        }

        BlockLocationPoint = new Point(e.Location.X, e.Location.Y);

        DrawingBoard.FillEllipse(Brushes.Red, BlockLocationPoint.X, BlockLocationPoint.Y, 6, 6);

        bpPictureBox.Refresh();
    }

    // Funkcja pomocnicza do znajdowania bryły pod kursorem
    private int FindBlockAtPosition(int x, int y)
    {
        for (int i = 0; i < LBG.Count; i++)
        {
            var block = LBG[i];
            // Sprawdzamy czy punkt jest w przybliżeniu w obszarze bryły
            int deltaX = Math.Abs(x - block.XsP);
            int deltaY = Math.Abs(y - block.YsP);

            // Przyjmujemy tolerancję 50 pikseli dla łatwiejszego klikania
            if (deltaX <= 50 && deltaY <= 50)
            {
                return i;
            }
        }
        return -1; // Nie znaleziono bryły
    }

    // bpBtnAddSelectedBlock_Click
    private void bpBtnAddSelectedBlock_Click(object sender, EventArgs e)
    {
        if (BlockLocationPoint.X != -1 && BlockLocationPoint.Y != -1 && DrawingBoard != null)
        {
            SolidBrush Brush = new SolidBrush(bpPictureBox.BackColor);

            DrawingBoard.FillEllipse(Brush, BlockLocationPoint.X, BlockLocationPoint.Y, 6, 6);

            int BlockRadius = bpTBarBlockRadius.Value;
            int BlockHeight = bpTBarBlockHeight.Value;
            int BlockSidesNumber = (int)bpNumUpDownBlockSidesNumber.Value;

            float RotationalAngle = float.Parse(bpTxtBlockAngle.Text);

            int XpP = BlockLocationPoint.X;
            int YpP = BlockLocationPoint.Y; // Poprawiona pozycja podstawy

            Color bpColor = bpTxtBlockLineColor.BackColor;
            float bpLineWidth = (int)bpNumUpDownLineWidth.Value;
            DashStyle bpLineStyle;

            switch (bpCBoxLineStyle.SelectedIndex)
            {
                case 0:
                    bpLineStyle = DashStyle.Solid;
                    break;
                case 1:
                    bpLineStyle = DashStyle.Dash;
                    break;
                case 2:
                    bpLineStyle = DashStyle.Dot;
                    break;
                case 3:
                    bpLineStyle = DashStyle.DashDot;
                    break;
                case 4:
                    bpLineStyle = DashStyle.DashDotDot;
                    break;
                default:
                    bpLineStyle = DashStyle.Solid;
                    break;
            }            switch (bpCBoxBlockType.SelectedItem?.ToString())
            {
                case "Stożek":
                    GeometricBlock.ConeBlock cone = new GeometricBlock.ConeBlock(BlockRadius, BlockHeight, XpP, YpP, bpColor, bpLineStyle, bpLineWidth);
                    LBG.Add(cone);
                    Console.WriteLine($"[DODANO] Stożek: wysokość={BlockHeight}, objętość={cone.Volume:F2}, powierzchnia={cone.SurfaceArea:F2}");
                    cone.Draw(DrawingBoard);
                    break;
                case "Walec":
                    GeometricBlock.CylinderBlock cylinder = new GeometricBlock.CylinderBlock(BlockRadius, BlockHeight, XpP, YpP, bpColor, bpLineStyle, bpLineWidth);
                    LBG.Add(cylinder);
                    Console.WriteLine($"[DODANO] Walec: wysokość={BlockHeight}, objętość={cylinder.Volume:F2}, powierzchnia={cylinder.SurfaceArea:F2}");
                    cylinder.Draw(DrawingBoard);
                    break;
                case "Kula":
                    GeometricBlock.SphereBlock sphere = new GeometricBlock.SphereBlock(BlockRadius, XpP, YpP, bpColor, bpLineStyle, bpLineWidth);
                    LBG.Add(sphere);
                    Console.WriteLine($"[DODANO] Kula: wysokość={sphere.Height}, objętość={sphere.Volume:F2}, powierzchnia={sphere.SurfaceArea:F2}");
                    sphere.Draw(DrawingBoard);
                    break;
                case "Piramida":
                    GeometricBlock.PyramidBlock pyramid = new GeometricBlock.PyramidBlock(BlockRadius, BlockHeight, BlockSidesNumber, XpP, YpP, bpColor, bpLineStyle, bpLineWidth);
                    LBG.Add(pyramid);
                    Console.WriteLine($"[DODANO] Piramida: wysokość={BlockHeight}, objętość={pyramid.Volume:F2}, powierzchnia={pyramid.SurfaceArea:F2}");
                    pyramid.Draw(DrawingBoard);
                    break;
                default:
                    MessageBox.Show("Nie wybrano poprawnego typu bloku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Wyjście bez dodawania bryły
            }

            // Sortujemy bryły po dodaniu nowej (tylko jeśli mamy więcej niż jedną bryłę)
            if (LBG.Count > 1)
            {
                SortAndRedrawBlocks();
            }
            else
            {
                bpPictureBox.Refresh();
            }

            timer1.Enabled = true;

            BlockLocationPoint = new Point(-1, -1); // Reset location after adding block

            bpGrBoxBlockVisibilityCriteria.Enabled = true;
            bpGrBoxBlockOrdering.Enabled = true;

        }
        else
        {
            MessageBox.Show("Proszę najpierw kliknąć na obszar rysowania, aby wybrać pozycję bryły.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void BpBtnBlockLineColor_Click(object? sender, EventArgs e)
    {
        using (ColorDialog colorDialog = new ColorDialog())
        {
            colorDialog.Color = bpTxtBlockLineColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                bpTxtBlockLineColor.BackColor = colorDialog.Color;
                Console.WriteLine($"[ZMIANA] Kolor linii: {colorDialog.Color}");
            }
        }
    }

    private void BpBtnTurnOnSlider_Click(object? sender, EventArgs e)
    {
        if (LBG.Count > 0)
        {
            timer2.Enabled = true;
            timer2.Tag = 0; // Reset to first block
            Console.WriteLine("[SLIDER] Włączono pokaz slajdów");
        }
        else
        {
            MessageBox.Show("Brak brył do pokazania w sliderze.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void BpBtnTurnOffSlider_Click(object? sender, EventArgs e)
    {
        timer2.Enabled = false;
        bpTxtBlockNumber.Text = "0";
        bpTxtSelectedBlock.Text = "Brak";
        Console.WriteLine("[SLIDER] Wyłączono pokaz slajdów");
    }    private void BpBtnNext_Click(object? sender, EventArgs e)
    {
        if (LBG.Count == 0) return;

        int currentBlockIndex = (int)(timer2.Tag ?? 0);
        currentBlockIndex = (currentBlockIndex + 1) % LBG.Count;
        timer2.Tag = currentBlockIndex;

        // Pokazujemy tylko wybraną bryłę
        ShowSingleBlock(currentBlockIndex);

        Console.WriteLine($"[SLIDER] Następna bryła: {currentBlockIndex + 1}");
    }

    private void BpBtnPrevious_Click(object? sender, EventArgs e)
    {
        if (LBG.Count == 0) return;

        int currentBlockIndex = (int)(timer2.Tag ?? 0);
        currentBlockIndex = (currentBlockIndex - 1 + LBG.Count) % LBG.Count;
        timer2.Tag = currentBlockIndex;

        // Pokazujemy tylko wybraną bryłę
        ShowSingleBlock(currentBlockIndex);

        Console.WriteLine($"[SLIDER] Poprzednia bryła: {currentBlockIndex + 1}");
    }

    private void ShowSingleBlock(int blockIndex)
    {
        if (DrawingBoard == null || blockIndex >= LBG.Count) return;

        // Czyścimy ekran
        DrawingBoard.Clear(Color.White);

        // Pokazujemy tylko wybraną bryłę
        var currentBlock = LBG[blockIndex];
        currentBlock.Draw(DrawingBoard);

        // Aktualizujemy pola tekstowe
        bpTxtBlockNumber.Text = (blockIndex + 1).ToString();
        bpTxtSelectedBlock.Text = $"{currentBlock.Type} {blockIndex + 1}";

        bpPictureBox.Refresh();
    }

    // Funkcje usuwania brył
    private void BpBtnRemoveFirstAddedBlock_Click(object? sender, EventArgs e)
    {
        if (LBG.Count == 0)
        {
            MessageBox.Show("Brak brył do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Usuwamy pierwszą bryłę z listy
        var removedBlock = LBG[0];
        LBG.RemoveAt(0);

        Console.WriteLine($"[USUNIĘTO] Pierwszą bryłę: {removedBlock.Type}. Pozostało: {LBG.Count} brył");

        // Odświeżamy widok
        if (LBG.Count > 0)
        {
            SortAndRedrawBlocks();
        }
        else
        {
            // Jeśli nie ma już brył, czyścimy ekran
            if (DrawingBoard != null)
            {
                DrawingBoard.Clear(Color.White);
                bpPictureBox.Refresh();
            }
            bpTxtBlockNumber.Text = "0";
            bpTxtSelectedBlock.Text = "Brak";
            bpGrBoxBlockVisibilityCriteria.Enabled = false;
            bpGrBoxBlockOrdering.Enabled = false;
        }
    }

    private void BpBtnRemoveRecentBlock_Click(object? sender, EventArgs e)
    {
        if (LBG.Count == 0)
        {
            MessageBox.Show("Brak brył do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Usuwamy ostatnią bryłę z listy
        var removedBlock = LBG[LBG.Count - 1];
        LBG.RemoveAt(LBG.Count - 1);

        Console.WriteLine($"[USUNIĘTO] Ostatnią bryłę: {removedBlock.Type}. Pozostało: {LBG.Count} brył");

        // Odświeżamy widok
        if (LBG.Count > 0)
        {
            SortAndRedrawBlocks();
        }
        else
        {
            // Jeśli nie ma już brył, czyścimy ekran
            if (DrawingBoard != null)
            {
                DrawingBoard.Clear(Color.White);
                bpPictureBox.Refresh();
            }
            bpTxtBlockNumber.Text = "0";
            bpTxtSelectedBlock.Text = "Brak";
            bpGrBoxBlockVisibilityCriteria.Enabled = false;
            bpGrBoxBlockOrdering.Enabled = false;
        }
    }

    private void BpBtnRemoveSelectedBlock_Click(object? sender, EventArgs e)
    {
        if (LBG.Count == 0)
        {
            MessageBox.Show("Brak brył do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Sprawdzamy czy mamy wybraną bryłę
        if (int.TryParse(bpTxtBlockNumber.Text, out int selectedIndex) && selectedIndex > 0 && selectedIndex <= LBG.Count)
        {
            // Usuwamy wybraną bryłę (indeks w UI jest 1-based, a w liście 0-based)
            var removedBlock = LBG[selectedIndex - 1];
            LBG.RemoveAt(selectedIndex - 1);

            Console.WriteLine($"[USUNIĘTO] Wybraną bryłę #{selectedIndex}: {removedBlock.Type}. Pozostało: {LBG.Count} brył");

            // Odświeżamy widok
            if (LBG.Count > 0)
            {
                SortAndRedrawBlocks();

                // Dostosowujemy indeks dla slidera jeśli był włączony
                if (timer2.Enabled)
                {
                    int currentIndex = (int)(timer2.Tag ?? 0);
                    if (currentIndex >= LBG.Count)
                    {
                        currentIndex = 0;
                    }
                    timer2.Tag = currentIndex;
                    ShowSingleBlock(currentIndex);
                }
            }
            else
            {
                // Jeśli nie ma już brył, czyścimy ekran
                if (DrawingBoard != null)
                {
                    DrawingBoard.Clear(Color.White);
                    bpPictureBox.Refresh();
                }
                bpTxtBlockNumber.Text = "0";
                bpTxtSelectedBlock.Text = "Brak";
                bpGrBoxBlockVisibilityCriteria.Enabled = false;
                bpGrBoxBlockOrdering.Enabled = false;
                timer2.Enabled = false;
            }
        }
        else
        {
            MessageBox.Show("Wybierz prawidłowy numer bryły do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
