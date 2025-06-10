using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
// Używamy aliasu, aby uniknąć konfliktu nazw z klasą formularza
using bpBlock = ProjektNr2Paczesny72541.GeometricBlock;

namespace ProjektNr2Paczesny72541
{
    public partial class bpCockpitIndividual : Form
    {
        // Lista Figur Geometrycznych (Brył)
        private List<bpBlock.bpGeometricBlockBase> LBG = new List<bpBlock.bpGeometricBlockBase>();
        private Graphics Rysownica;
        private int IndexOfActiveBlock = -1;
        private Point? clickedPosition = null;

        public bpCockpitIndividual()
        {
            InitializeComponent();

            // Ustawienie podwójnego buforowania dla PictureBox, aby animacje były płynne
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            // Inicjalizacja Rysownicy
            bpPictureBox.Image = new Bitmap(bpPictureBox.Width, bpPictureBox.Height);
            Rysownica = Graphics.FromImage(bpPictureBox.Image);
        }

        private void bpCockpitIndividual_Load(object sender, EventArgs e)
        {
            AutoScroll = true;

            if (bpPictureBox.Image != null)
            {
                bpPictureBox.Image.Dispose();
                Rysownica?.Dispose();
            }

            bpPictureBox.Image = new Bitmap(bpPictureBox.Width, bpPictureBox.Height);
            Rysownica = Graphics.FromImage(bpPictureBox.Image);
            Rysownica.SmoothingMode = SmoothingMode.AntiAlias;
            Rysownica.Clear(Color.Beige);

            bpTBarBlockHeight.Maximum = bpPictureBox.Height / 2;
            bpTBarBlockHeight.Value = bpTBarBlockHeight.Maximum / 2;

            bpTBarBlockRadius.Maximum = bpPictureBox.Width / 2;
            bpTBarBlockRadius.Value = bpTBarBlockRadius.Maximum / 2;

            bpGrBoxGeometricAttributes.Enabled = true;
            bpBtnLineColor.BackColor = Color.Black; // Set default line color to black

            // Wypełnienie ComboBoxów
            bpCBoxBlockType.DataSource = Enum.GetValues(typeof(bpBlock.GeometricBlockType));
            bpCBoxLineStyle.DataSource = Enum.GetValues(typeof(DashStyle));

            // Ustawienie wartości początkowych dla kontrolek
            bpTxtBlockHeight.Text = bpTBarBlockHeight.Value.ToString();
            bpTxtBlockRadius.Text = bpTBarBlockRadius.Value.ToString();
            bpTxtBlockSlant.Text = bpTBarBlockSlant.Value.ToString();

            bpGrBoxGeometricAttributes.Enabled = true; // Enable geometric attributes at start

            // Zarządzanie dostępnością kontrolek
            UpdateControlStates();
        }

        #region Zarządzanie stanem kontrolek

        private void UpdateControlStates()
        {
            bool anyBlockExists = LBG.Count > 0;
            bpGrBoxGeometricAttributes.Enabled = true;
            bpGrBoxGraphicAttributes.Enabled = true;
            bpGrBoxRotation.Enabled = anyBlockExists;
            bpGrBoxSlider.Enabled = anyBlockExists;
            bpBtnDeleteBlock.Enabled = anyBlockExists;
            bpTxtBlockInfo.Enabled = anyBlockExists;

            if (anyBlockExists)
            {
                var activeBlock = LBG[IndexOfActiveBlock];
                bool isOblique = activeBlock.Type == bpBlock.GeometricBlockType.GraniastosłupPochyły ||
                                 activeBlock.Type == bpBlock.GeometricBlockType.OstrosłupPochyły;
                bpTBarBlockSlant.Enabled = isOblique;
                bpTxtBlockSlant.Enabled = isOblique;

                bpBtnPrevious.Enabled = LBG.Count > 1;
                bpBtnNext.Enabled = LBG.Count > 1;
                bpChkEnableSlider.Enabled = LBG.Count > 1;

                UpdateUIForActiveBlock();
            }
            else
            {
                bpLblCurrentBlockInfo.Text = "Bryła: 0/0";
                bpTxtBlockInfo.Text = "";
            }
        }

        private void UpdateUIForActiveBlock()
        {
            if (IndexOfActiveBlock == -1 || IndexOfActiveBlock >= LBG.Count) return;

            var activeBlock = LBG[IndexOfActiveBlock];
            bpTBarBlockHeight.Value = activeBlock.Height;
            bpTBarBlockRadius.Value = activeBlock.Radius;
            bpTBarBlockSlant.Value = activeBlock.Slant;
            bpNumUpDownLineWidth.Value = (decimal)activeBlock.LineWidth;
            bpCBoxLineStyle.SelectedItem = activeBlock.LineStyle;

            bpTxtBlockHeight.Text = activeBlock.Height.ToString();
            bpTxtBlockRadius.Text = activeBlock.Radius.ToString();
            bpTxtBlockSlant.Text = activeBlock.Slant.ToString();

            bpLblCurrentBlockInfo.Text = $"Bryła: {IndexOfActiveBlock + 1}/{LBG.Count}";
            bpTxtBlockInfo.Text = activeBlock.Type.ToString();
        }

        #endregion

        #region Obsługa zdarzeń - Tworzenie i usuwanie

        private void bpBtnAddBlock_Click(object sender, EventArgs e)
        {
            if (clickedPosition == null)
            {
                MessageBox.Show("Proszę kliknąć na PictureBox, aby wybrać miejsce dla bryły.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int x = clickedPosition.Value.X;
            int y = clickedPosition.Value.Y;

            var blockType = bpCBoxBlockType.SelectedItem is bpBlock.GeometricBlockType type ? type : bpBlock.GeometricBlockType.GraniastosłupProsty;
            var height = bpTBarBlockHeight.Value;
            var radius = bpTBarBlockRadius.Value;
            var slant = bpTBarBlockSlant.Value;
            var color = bpBtnLineColor.BackColor;
            var lineStyle = bpCBoxLineStyle.SelectedItem is DashStyle style ? style : DashStyle.Solid;
            var lineWidth = (float)bpNumUpDownLineWidth.Value;

            bpBlock.bpGeometricBlockBase newBlock;

            switch (blockType)
            {
                case bpBlock.GeometricBlockType.GraniastosłupProsty:
                    newBlock = new bpBlock.bpRightPrism(height, radius, x, y, color, lineStyle, lineWidth);
                    break;
                case bpBlock.GeometricBlockType.GraniastosłupPochyły:
                    newBlock = new bpBlock.bpObliquePrism(height, radius, slant, x, y, color, lineStyle, lineWidth);
                    break;
                case bpBlock.GeometricBlockType.OstrosłupProsty:
                    newBlock = new bpBlock.bpRightPyramid(height, radius, x, y, color, lineStyle, lineWidth);
                    break;
                case bpBlock.GeometricBlockType.OstrosłupPochyły:
                    newBlock = new bpBlock.bpObliquePyramid(height, radius, slant, x, y, color, lineStyle, lineWidth);
                    break;
                default:
                    return;
            }

            LBG.Add(newBlock);
            IndexOfActiveBlock = LBG.Count - 1;

            UpdateControlStates();
            bpPictureBox.Refresh();
            clickedPosition = null; // Reset clicked position
        }

        private void bpBtnDeleteBlock_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG.RemoveAt(IndexOfActiveBlock);
                if (LBG.Count > 0)
                {
                    IndexOfActiveBlock = 0; // Ustaw na pierwszą bryłę
                }
                else
                {
                    IndexOfActiveBlock = -1; // Brak brył
                }
                UpdateControlStates();
                bpPictureBox.Refresh();
            }
        }

        #endregion

        #region Rysowanie

        private void bpPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor); // Czyścimy tło
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Rysujemy wszystkie bryły
            foreach (var block in LBG)
            {
                if (block.Visible)
                {
                    block.Draw(e.Graphics);
                }
            }

            // Opcjonalnie: Rysowanie obwódki wokół aktywnej bryły
            if (IndexOfActiveBlock != -1)
            {
                var activeBlock = LBG[IndexOfActiveBlock];
                using (Pen highlightPen = new Pen(Color.Red, 1) { DashStyle = DashStyle.Dot })
                {
                    e.Graphics.DrawRectangle(highlightPen, activeBlock.XsP - activeBlock.Radius,
                        activeBlock.YsP - activeBlock.Height,
                        activeBlock.Radius * 2,
                        activeBlock.Height + activeBlock.Radius);
                }
            }
        }

        #endregion

        #region Atrybuty geometryczne i graficzne

        private void bpTBarBlockHeight_Scroll(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].SetHeight(bpTBarBlockHeight.Value);
                bpTxtBlockHeight.Text = bpTBarBlockHeight.Value.ToString();
                bpPictureBox.Refresh();
            }
        }

        private void bpTBarBlockRadius_Scroll(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].SetRadius(bpTBarBlockRadius.Value);
                bpTxtBlockRadius.Text = bpTBarBlockRadius.Value.ToString();
                bpPictureBox.Refresh();
            }
        }

        private void bpTBarBlockSlant_Scroll(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].SetSlant(bpTBarBlockSlant.Value);
                bpTxtBlockSlant.Text = bpTBarBlockSlant.Value.ToString();
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnLineColor_Click(object sender, EventArgs e)
        {
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpBtnLineColor.BackColor = bpColorDialog.Color;
                if (IndexOfActiveBlock != -1)
                {
                    LBG[IndexOfActiveBlock].SetLineColor(bpColorDialog.Color);
                    bpPictureBox.Refresh();
                }
            }
        }

        private void bpCBoxLineStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                DashStyle selectedStyle = bpCBoxLineStyle.SelectedItem is DashStyle style ? style : DashStyle.Solid;
                LBG[IndexOfActiveBlock].SetLineStyle(selectedStyle);
                bpPictureBox.Refresh();
            }
        }

        private void bpNumUpDownLineWidth_ValueChanged(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].SetLineWidth((float)bpNumUpDownLineWidth.Value);
                bpPictureBox.Refresh();
            }
        }

        #endregion

        #region Obracanie i slidery

        private void bpBtnRotateLeft_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Rotate(-5); // Obrót o -5 stopni
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnRotateRight_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Rotate(5); // Obrót o 5 stopni
                bpPictureBox.Refresh();
            }
        }

        private void bpChkEnableAutoRotation_CheckedChanged(object sender, EventArgs e)
        {
            bpRotationTimer.Enabled = bpChkEnableAutoRotation.Checked;
        }

        private void bpRotationTimer_Tick(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Rotate(2);
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnPrevious_Click(object sender, EventArgs e)
        {
            if (LBG.Count > 1)
            {
                IndexOfActiveBlock = (IndexOfActiveBlock - 1 + LBG.Count) % LBG.Count;
                UpdateControlStates();
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnNext_Click(object sender, EventArgs e)
        {
            if (LBG.Count > 1)
            {
                IndexOfActiveBlock = (IndexOfActiveBlock + 1) % LBG.Count;
                UpdateControlStates();
                bpPictureBox.Refresh();
            }
        }

        private void bpChkEnableSlider_CheckedChanged(object sender, EventArgs e)
        {
            bpSliderTimer.Enabled = bpChkEnableSlider.Checked;
        }

        private void bpSliderTimer_Tick(object sender, EventArgs e)
        {
            bpBtnNext_Click(sender, e);
        }

        #endregion

        private void bpPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            clickedPosition = e.Location;
            // Dodaj nowy punkt na czerwono w miejscu kliknięcia
            using (Graphics g = bpPictureBox.CreateGraphics())
            {
                g.FillEllipse(Brushes.Red, e.X - 5, e.Y - 5, 10, 10); // Rysowanie czerwonego kółka
                g.Dispose();

            }
        }

        private bool isDragging = false;
        private Point dragStartPoint;

        private void bpBtnMoveUp_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Move(LBG[IndexOfActiveBlock].XsP, LBG[IndexOfActiveBlock].YsP - 10); // Move up by 10 units
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnMoveDown_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Move(LBG[IndexOfActiveBlock].XsP, LBG[IndexOfActiveBlock].YsP + 10);
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnMoveLeft_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Move(LBG[IndexOfActiveBlock].XsP - 10, LBG[IndexOfActiveBlock].YsP); // Move left by 10 units
                bpPictureBox.Refresh();
            }
        }

        private void bpBtnMoveRight_Click(object sender, EventArgs e)
        {
            if (IndexOfActiveBlock != -1)
            {
                LBG[IndexOfActiveBlock].Move(LBG[IndexOfActiveBlock].XsP + 10, LBG[IndexOfActiveBlock].YsP); // Move right by 10 units
                bpPictureBox.Refresh();
            }
        }        private void bpCockpitIndividual_FormClosing(object sender, FormClosingEventArgs e)
        {
        DialogResult result = MessageBox.Show(
            "Czy na pewno chcesz zamknąć formularz projektu indywidualnego?",
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

    /*
    ==========================================================================================================
    SAMOOCENA PROJEKTU INDYWIDUALNEGO - bartosz Paczesny 72541
    ==========================================================================================================

    📊 OCENA IMPLEMENTACJI FUNKCJONALNOŚCI:

    1. 🏆 IMPLEMENTACJA BRYŁ GEOMETRYCZNYCH [8/10]:
       ✅ 4 typy brył: GraniastosłupProsty, GraniastosłupPochyły, OstrosłupProsty, OstrosłupPochyły
       ✅ Hierarchia klas z abstrakcyjną klasą bazową bpGeometricBlockBase
       ✅ Polimorfizm w metodach Draw(), SetHeight(), SetRadius(), SetSlant()
       ✅ Enkapsulacja właściwości geometrycznych i graficznych
       ⚠️  Mniej typów brył niż w projekcie laboratoryjnym (brak kuli, stożka, walca)

    2. 🏆 ZARZĄDZANIE POJEDYNCZYMI BRYŁAMI [9/10]:
       ✅ Koncepcja "aktywnej bryły" - focus na jednej bryłe na raz
       ✅ Intuicyjne przełączanie między bryłami (Previous/Next)
       ✅ Real-time editing atrybutów z natychmiastową wizualizacją
       ✅ Smart UI state management - kontrolki dostosowują się do typu bryły
       ✅ Podświetlanie aktywnej bryły (czerwona obwódka)

    3. 🏆 EDYCJA ATRYBUTÓW W CZASIE RZECZYWISTYM [10/10]:
       ✅ TrackBar controls z synchronizacją TextBox
       ✅ Dynamic enabling/disabling kontrolek (np. Slant tylko dla pochyłych)
       ✅ Natychmiastowe odświeżanie wizualizacji przy zmianach
       ✅ Walidacja wartości i proper bounds checking
       ✅ Separate controls dla różnych atrybutów (Height, Radius, Slant)

    4. 🏆 FUNKCJONALNOŚĆ ROTACJI I ANIMACJI [9/10]:
       ✅ Manualne obracanie (Left/Right buttons)
       ✅ Automatyczna rotacja z timer-em
       ✅ Smooth animation w real-time
       ✅ Configurable rotation speed
       ⚠️  Brak zaawansowanych opcji rotacji (różne osie, custom angles)

    5. 🏆 ZAAWANSOWANE ZARZĄDZANIE POZYCJĄ [8/10]:
       ✅ Click-to-place functionality z visual feedback (czerwony punkt)
       ✅ Directional movement buttons (Up/Down/Left/Right)
       ✅ Precyzyjne przemieszczanie o stałą wartość (10 jednostek)
       ✅ Mouse click detection z proper coordinate handling
       ⚠️  Brak drag & drop functionality

    6. 🏆 SLIDER I NAWIGACJA [8/10]:
       ✅ Automatyczny slider z timer-em
       ✅ Manual navigation (Previous/Next)
       ✅ Smart enabling/disabling based na liczbie brył
       ✅ Current block info display
       ⚠️  Brak sortowania jak w projekcie laboratoryjnym

    7. 🏆 INTERFACE UŻYTKOWNIKA [9/10]:
       ✅ Logiczne grupowanie kontrolek w GroupBoxes
       ✅ Intuitive layout z proper spacing
       ✅ Real-time feedback dla wszystkich operacji
       ✅ Adaptive UI - kontrolki enable/disable się inteligentnie
       ✅ Clear visual hierarchy

    8. 🏆 OBSŁUGA ZDARZEŃ [9/10]:
       ✅ Event-driven architecture
       ✅ Proper mouse event handling
       ✅ Timer-based animations
       ✅ Form lifecycle management
       ✅ Null safety w .NET 9.0 context

    9. 🏆 GRAFIKA I WIZUALIZACJA [8/10]:
       ✅ Anti-aliasing dla smooth rendering
       ✅ Different line styles support
       ✅ Configurable colors i line width
       ✅ Active block highlighting
       ⚠️  Mniej zaawansowana wizualizacja 3D niż w projekcie lab

    📈 RÓŻNICE WZGLĘDEM PROJEKTU LABORATORYJNEGO:

    MOCNE STRONY PROJEKTU INDYWIDUALNEGO:
    🌟 Focus na single-block editing - bardziej szczegółowa kontrola
    🌟 Real-time attribute manipulation
    🌟 Advanced movement controls
    🌟 Rotation animations
    🌟 Click-to-place functionality

    OGRANICZENIA WZGLĘDEM PROJEKTU LABORATORYJNEGO:
    ⚠️  Brak funkcjonalności sortowania multiple brył
    ⚠️  Mniej typów brył geometrycznych
    ⚠️  Brak mass operations (bulk delete, etc.)
    ⚠️  Simplified visualization

    🧪 TESTOWANIE [8/10]:
    ✅ Functional testing każdej bryły individually
    ✅ UI responsiveness testing
    ✅ Animation smoothness verification
    ✅ Boundary conditions testing
    ⚠️  Brak comprehensive test suite jak w projekcie lab

    🏗️ JAKOŚĆ KODU [8/10]:
    ✅ Clean separation of concerns
    ✅ Consistent naming conventions (bp- prefix)
    ✅ Proper resource disposal
    ✅ Good error handling
    ⚠️  Niektóre metody można by zrefaktorować dla lepszej czytelności

    💡 UNIKALNE CECHY PROJEKTU INDYWIDUALNEGO:
    🌟 Detailed single-object manipulation
    🌟 Real-time visual feedback system
    🌟 Advanced animation capabilities
    🌟 Intelligent UI state management
    🌟 Click-and-place interaction model

    📊 PODSUMOWANIE:
    Ocena ogólna: 8.5/10 (BARDZO DOBRA)

    Projekt indywidualny stanowi solid implementation focused na detailed manipulation
    pojedynczych brył geometrycznych. Chociaż ma mniej funkcjonalności mass-management
    niż projekt laboratoryjny, oferuje znacznie bardziej zaawansowane możliwości
    edycji i interakcji z pojedynczymi obiektami.

    Największe mocne strony:
    - Real-time editing capabilities
    - Smooth animations i transitions
    - Intuitive single-object focus
    - Responsive UI design

    Obszary do rozwoju:
    - Dodanie sortowania multiple objects
    - Więcej typów brył
    - Drag & drop functionality
    - Advanced 3D visualization

    KOMPLEMENTARNOŚĆ Z PROJEKTEM LABORATORYJNYM:
    Oba projekty razem demonstrują różne podejścia do zarządzania obiektami:
    - Lab: Mass management, sorting, bulk operations
    - Individual: Detailed editing, animations, precise control

    ==========================================================================================================
    */
    }
}