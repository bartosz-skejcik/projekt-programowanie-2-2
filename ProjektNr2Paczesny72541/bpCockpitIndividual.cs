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

        public bpCockpitIndividual()
        {
            InitializeComponent();

            // Ustawienie podwójnego buforowania dla PictureBox, aby animacje były płynne
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void bpCockpitIndividual_Load(object sender, EventArgs e)
        {
            // Inicjalizacja Rysownicy
            bpPictureBox.Image = new Bitmap(bpPictureBox.Width, bpPictureBox.Height);
            Rysownica = Graphics.FromImage(bpPictureBox.Image);

            // Wypełnienie ComboBoxów
            bpCBoxBlockType.DataSource = Enum.GetValues(typeof(bpBlock.GeometricBlockType));
            bpCBoxLineStyle.DataSource = Enum.GetValues(typeof(DashStyle));

            // Ustawienie wartości początkowych dla kontrolek
            bpTxtBlockHeight.Text = bpTBarBlockHeight.Value.ToString();
            bpTxtBlockRadius.Text = bpTBarBlockRadius.Value.ToString();
            bpTxtBlockSlant.Text = bpTBarBlockSlant.Value.ToString();

            // Zarządzanie dostępnością kontrolek
            UpdateControlStates();
        }

        #region Zarządzanie stanem kontrolek

        private void UpdateControlStates()
        {
            bool anyBlockExists = LBG.Count > 0;
            bpGrBoxGeometricAttributes.Enabled = anyBlockExists;
            bpGrBoxGraphicAttributes.Enabled = anyBlockExists;
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
            Random rand = new Random();
            int x = rand.Next(bpTBarBlockRadius.Value, bpPictureBox.Width - bpTBarBlockRadius.Value);
            int y = rand.Next(bpTBarBlockHeight.Value, bpPictureBox.Height - bpTBarBlockRadius.Value);

            var blockType = (bpBlock.GeometricBlockType)bpCBoxBlockType.SelectedItem;
            var height = bpTBarBlockHeight.Value;
            var radius = bpTBarBlockRadius.Value;
            var slant = bpTBarBlockSlant.Value;
            var color = bpBtnLineColor.BackColor;
            var lineStyle = (DashStyle)bpCBoxLineStyle.SelectedItem;
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
                    return; // Nie powinno się zdarzyć
            }

            LBG.Add(newBlock);
            IndexOfActiveBlock = LBG.Count - 1;

            UpdateControlStates();
            bpPictureBox.Refresh();
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
                LBG[IndexOfActiveBlock].SetLineStyle((DashStyle)bpCBoxLineStyle.SelectedItem);
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
            // Kliknięcie na obszar rysowania
        }
    }
}