using System.ComponentModel;

namespace ProjektNr2Paczesny72541;

partial class bpCockpitLaboratory
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        bpGrBoxBlockList = new System.Windows.Forms.GroupBox();
        bpCBoxBlockType = new System.Windows.Forms.ComboBox();
        bpGrBoxGeometricAttrs = new System.Windows.Forms.GroupBox();
        bpTBarBlockAngle = new System.Windows.Forms.TrackBar();
        bpTxtBlockAngle = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        bpNumUpDownBlockSidesNumber = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        bpTBarBlockRadius = new System.Windows.Forms.TrackBar();
        bpTxtBlockRadius = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        bpTBarBlockHeight = new System.Windows.Forms.TrackBar();
        bpTxtBlockHeight = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        bpGrBoxGraphicAttrs = new System.Windows.Forms.GroupBox();
        bpNumUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
        label5 = new System.Windows.Forms.Label();
        bpCBoxLineStyle = new System.Windows.Forms.ComboBox();
        bpTxtBlockLineColor = new System.Windows.Forms.TextBox();
        bpBtnBlockLineColor = new System.Windows.Forms.Button();
        bpPictureBox = new System.Windows.Forms.PictureBox();
        bpBtnAddSelectedBlock = new System.Windows.Forms.Button();
        bpGrBoxBlockVisibilityCriteria = new System.Windows.Forms.GroupBox();
        bpRBtnBlockSurfaceArea = new System.Windows.Forms.RadioButton();
        bpRBtnBlockVolume = new System.Windows.Forms.RadioButton();
        bpRBtnBlockHeight = new System.Windows.Forms.RadioButton();
        bpGrBoxBlockOrdering = new System.Windows.Forms.GroupBox();
        bpRBtnBlockOrderDecreasing = new System.Windows.Forms.RadioButton();
        bpRBtnBlockOrderIncreasing = new System.Windows.Forms.RadioButton();
        timer1 = new System.Windows.Forms.Timer(components);
        timer2 = new System.Windows.Forms.Timer(components);
        bpBtnRemoveFirstAddedBlock = new System.Windows.Forms.Button();
        bpBtnRemoveRecentBlock = new System.Windows.Forms.Button();
        bpBtnRemoveSelectedBlock = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        bpTxtSelectedBlock = new System.Windows.Forms.TextBox();
        bpGrBoxSlides = new System.Windows.Forms.GroupBox();
        bpRadioClock = new System.Windows.Forms.RadioButton();
        bpRadioButton = new System.Windows.Forms.RadioButton();
        bpBtnTurnOnSlider = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        bpTxtBlockNumber = new System.Windows.Forms.TextBox();
        bpBtnNext = new System.Windows.Forms.Button();
        bpBtnPrevious = new System.Windows.Forms.Button();
        bpBtnTurnOffSlider = new System.Windows.Forms.Button();
        bpGrBoxBlockList.SuspendLayout();
        bpGrBoxGeometricAttrs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockAngle).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bpNumUpDownBlockSidesNumber).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockRadius).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockHeight).BeginInit();
        bpGrBoxGraphicAttrs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bpNumUpDownLineWidth).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bpPictureBox).BeginInit();
        bpGrBoxBlockVisibilityCriteria.SuspendLayout();
        bpGrBoxBlockOrdering.SuspendLayout();
        bpGrBoxSlides.SuspendLayout();
        SuspendLayout();
        // 
        // bpGrBoxBlockList
        // 
        bpGrBoxBlockList.Controls.Add(bpCBoxBlockType);
        bpGrBoxBlockList.Location = new System.Drawing.Point(8, 7);
        bpGrBoxBlockList.Name = "bpGrBoxBlockList";
        bpGrBoxBlockList.Size = new System.Drawing.Size(185, 57);
        bpGrBoxBlockList.TabIndex = 0;
        bpGrBoxBlockList.TabStop = false;
        bpGrBoxBlockList.Text = "Lista brył obrotowych";
        // 
        // bpCBoxBlockType
        // 
        bpCBoxBlockType.FormattingEnabled = true;
        bpCBoxBlockType.Location = new System.Drawing.Point(11, 23);
        bpCBoxBlockType.Name = "bpCBoxBlockType";
        bpCBoxBlockType.Size = new System.Drawing.Size(163, 23);
        bpCBoxBlockType.TabIndex = 0;
        bpCBoxBlockType.Text = "Wybierz bryłę obrotową";
        // 
        // bpGrBoxGeometricAttrs
        // 
        bpGrBoxGeometricAttrs.Controls.Add(bpTBarBlockAngle);
        bpGrBoxGeometricAttrs.Controls.Add(bpTxtBlockAngle);
        bpGrBoxGeometricAttrs.Controls.Add(label4);
        bpGrBoxGeometricAttrs.Controls.Add(bpNumUpDownBlockSidesNumber);
        bpGrBoxGeometricAttrs.Controls.Add(label3);
        bpGrBoxGeometricAttrs.Controls.Add(bpTBarBlockRadius);
        bpGrBoxGeometricAttrs.Controls.Add(bpTxtBlockRadius);
        bpGrBoxGeometricAttrs.Controls.Add(label2);
        bpGrBoxGeometricAttrs.Controls.Add(bpTBarBlockHeight);
        bpGrBoxGeometricAttrs.Controls.Add(bpTxtBlockHeight);
        bpGrBoxGeometricAttrs.Controls.Add(label1);
        bpGrBoxGeometricAttrs.Location = new System.Drawing.Point(8, 70);
        bpGrBoxGeometricAttrs.Name = "bpGrBoxGeometricAttrs";
        bpGrBoxGeometricAttrs.Size = new System.Drawing.Size(185, 300);
        bpGrBoxGeometricAttrs.TabIndex = 1;
        bpGrBoxGeometricAttrs.TabStop = false;
        bpGrBoxGeometricAttrs.Text = "Atrybuty geometryczne";
        // 
        // bpTBarBlockAngle
        // 
        bpTBarBlockAngle.Location = new System.Drawing.Point(11, 243);
        bpTBarBlockAngle.Maximum = 360;
        bpTBarBlockAngle.Name = "bpTBarBlockAngle";
        bpTBarBlockAngle.Size = new System.Drawing.Size(116, 45);
        bpTBarBlockAngle.TabIndex = 11;
        bpTBarBlockAngle.ValueChanged += bpTBarBlockAngle_ValueChanged;
        // 
        // bpTxtBlockAngle
        // 
        bpTxtBlockAngle.Enabled = false;
        bpTxtBlockAngle.Location = new System.Drawing.Point(133, 243);
        bpTxtBlockAngle.Name = "bpTxtBlockAngle";
        bpTxtBlockAngle.Size = new System.Drawing.Size(41, 23);
        bpTxtBlockAngle.TabIndex = 10;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(11, 222);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(163, 18);
        label4.TabIndex = 9;
        label4.Text = "Kąt pochylenia bryły";
        // 
        // bpNumUpDownBlockSidesNumber
        // 
        bpNumUpDownBlockSidesNumber.Location = new System.Drawing.Point(11, 185);
        bpNumUpDownBlockSidesNumber.Name = "bpNumUpDownBlockSidesNumber";
        bpNumUpDownBlockSidesNumber.Size = new System.Drawing.Size(163, 23);
        bpNumUpDownBlockSidesNumber.TabIndex = 8;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(11, 164);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(163, 18);
        label3.TabIndex = 6;
        label3.Text = "Stopień wielokąta bryły";
        // 
        // bpTBarBlockRadius
        // 
        bpTBarBlockRadius.Location = new System.Drawing.Point(11, 116);
        bpTBarBlockRadius.Name = "bpTBarBlockRadius";
        bpTBarBlockRadius.Size = new System.Drawing.Size(116, 45);
        bpTBarBlockRadius.TabIndex = 5;
        bpTBarBlockRadius.ValueChanged += bpTBarBlockRadius_ValueChanged;
        // 
        // bpTxtBlockRadius
        // 
        bpTxtBlockRadius.Enabled = false;
        bpTxtBlockRadius.Location = new System.Drawing.Point(133, 116);
        bpTxtBlockRadius.Name = "bpTxtBlockRadius";
        bpTxtBlockRadius.Size = new System.Drawing.Size(41, 23);
        bpTxtBlockRadius.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(11, 95);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(163, 18);
        label2.TabIndex = 3;
        label2.Text = "Promień bryły";
        // 
        // bpTBarBlockHeight
        // 
        bpTBarBlockHeight.Location = new System.Drawing.Point(11, 47);
        bpTBarBlockHeight.Name = "bpTBarBlockHeight";
        bpTBarBlockHeight.Size = new System.Drawing.Size(116, 45);
        bpTBarBlockHeight.TabIndex = 2;
        bpTBarBlockHeight.ValueChanged += bpTBarBlockHeight_ValueChanged;
        // 
        // bpTxtBlockHeight
        // 
        bpTxtBlockHeight.Enabled = false;
        bpTxtBlockHeight.Location = new System.Drawing.Point(133, 47);
        bpTxtBlockHeight.Name = "bpTxtBlockHeight";
        bpTxtBlockHeight.Size = new System.Drawing.Size(41, 23);
        bpTxtBlockHeight.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(11, 26);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(163, 18);
        label1.TabIndex = 0;
        label1.Text = "Wysokość bryły";
        // 
        // bpGrBoxGraphicAttrs
        // 
        bpGrBoxGraphicAttrs.Controls.Add(bpNumUpDownLineWidth);
        bpGrBoxGraphicAttrs.Controls.Add(label5);
        bpGrBoxGraphicAttrs.Controls.Add(bpCBoxLineStyle);
        bpGrBoxGraphicAttrs.Controls.Add(bpTxtBlockLineColor);
        bpGrBoxGraphicAttrs.Controls.Add(bpBtnBlockLineColor);
        bpGrBoxGraphicAttrs.Location = new System.Drawing.Point(8, 376);
        bpGrBoxGraphicAttrs.Name = "bpGrBoxGraphicAttrs";
        bpGrBoxGraphicAttrs.Size = new System.Drawing.Size(185, 189);
        bpGrBoxGraphicAttrs.TabIndex = 1;
        bpGrBoxGraphicAttrs.TabStop = false;
        bpGrBoxGraphicAttrs.Text = "Atrybuty graficzne";
        // 
        // bpNumUpDownLineWidth
        // 
        bpNumUpDownLineWidth.Location = new System.Drawing.Point(11, 124);
        bpNumUpDownLineWidth.Name = "bpNumUpDownLineWidth";
        bpNumUpDownLineWidth.Size = new System.Drawing.Size(163, 23);
        bpNumUpDownLineWidth.TabIndex = 12;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(11, 103);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(163, 18);
        label5.TabIndex = 12;
        label5.Text = "Grubość linii";
        // 
        // bpCBoxLineStyle
        // 
        bpCBoxLineStyle.FormattingEnabled = true;
        bpCBoxLineStyle.Location = new System.Drawing.Point(11, 67);
        bpCBoxLineStyle.Name = "bpCBoxLineStyle";
        bpCBoxLineStyle.Size = new System.Drawing.Size(163, 23);
        bpCBoxLineStyle.TabIndex = 1;
        bpCBoxLineStyle.Text = "Wybierz styl linii";
        // 
        // bpTxtBlockLineColor
        // 
        bpTxtBlockLineColor.Enabled = false;
        bpTxtBlockLineColor.Location = new System.Drawing.Point(133, 29);
        bpTxtBlockLineColor.Name = "bpTxtBlockLineColor";
        bpTxtBlockLineColor.Size = new System.Drawing.Size(41, 23);
        bpTxtBlockLineColor.TabIndex = 12;
        // 
        // bpBtnBlockLineColor
        // 
        bpBtnBlockLineColor.Location = new System.Drawing.Point(11, 29);
        bpBtnBlockLineColor.Name = "bpBtnBlockLineColor";
        bpBtnBlockLineColor.Size = new System.Drawing.Size(116, 23);
        bpBtnBlockLineColor.TabIndex = 0;
        bpBtnBlockLineColor.Text = "Kolor linii";
        bpBtnBlockLineColor.UseVisualStyleBackColor = true;
        // 
        // bpPictureBox
        // 
        bpPictureBox.BackColor = System.Drawing.Color.White;
        bpPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        bpPictureBox.Location = new System.Drawing.Point(210, 36);
        bpPictureBox.Name = "bpPictureBox";
        bpPictureBox.Size = new System.Drawing.Size(726, 466);
        bpPictureBox.TabIndex = 2;
        bpPictureBox.TabStop = false;
        bpPictureBox.MouseClick += bpPictureBox_MouseClick;
        // 
        // bpBtnAddSelectedBlock
        // 
        bpBtnAddSelectedBlock.Location = new System.Drawing.Point(210, 508);
        bpBtnAddSelectedBlock.Name = "bpBtnAddSelectedBlock";
        bpBtnAddSelectedBlock.Size = new System.Drawing.Size(166, 57);
        bpBtnAddSelectedBlock.TabIndex = 3;
        bpBtnAddSelectedBlock.Text = "Dodaj wybraną bryłę";
        bpBtnAddSelectedBlock.UseVisualStyleBackColor = true;
        bpBtnAddSelectedBlock.Click += bpBtnAddSelectedBlock_Click;
        // 
        // bpGrBoxBlockVisibilityCriteria
        // 
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockSurfaceArea);
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockVolume);
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockHeight);
        bpGrBoxBlockVisibilityCriteria.Location = new System.Drawing.Point(382, 508);
        bpGrBoxBlockVisibilityCriteria.Name = "bpGrBoxBlockVisibilityCriteria";
        bpGrBoxBlockVisibilityCriteria.Size = new System.Drawing.Size(363, 57);
        bpGrBoxBlockVisibilityCriteria.TabIndex = 4;
        bpGrBoxBlockVisibilityCriteria.TabStop = false;
        bpGrBoxBlockVisibilityCriteria.Text = "Kryteria pokazu brył";
        // 
        // bpRBtnBlockSurfaceArea
        // 
        bpRBtnBlockSurfaceArea.Location = new System.Drawing.Point(234, 23);
        bpRBtnBlockSurfaceArea.Name = "bpRBtnBlockSurfaceArea";
        bpRBtnBlockSurfaceArea.Size = new System.Drawing.Size(107, 24);
        bpRBtnBlockSurfaceArea.TabIndex = 2;
        bpRBtnBlockSurfaceArea.TabStop = true;
        bpRBtnBlockSurfaceArea.Text = "Pole p. bryły";
        bpRBtnBlockSurfaceArea.UseVisualStyleBackColor = true;
        // 
        // bpRBtnBlockVolume
        // 
        bpRBtnBlockVolume.Location = new System.Drawing.Point(121, 23);
        bpRBtnBlockVolume.Name = "bpRBtnBlockVolume";
        bpRBtnBlockVolume.Size = new System.Drawing.Size(107, 24);
        bpRBtnBlockVolume.TabIndex = 1;
        bpRBtnBlockVolume.TabStop = true;
        bpRBtnBlockVolume.Text = "Objętość bryły";
        bpRBtnBlockVolume.UseVisualStyleBackColor = true;
        // 
        // bpRBtnBlockHeight
        // 
        bpRBtnBlockHeight.Location = new System.Drawing.Point(8, 23);
        bpRBtnBlockHeight.Name = "bpRBtnBlockHeight";
        bpRBtnBlockHeight.Size = new System.Drawing.Size(107, 24);
        bpRBtnBlockHeight.TabIndex = 0;
        bpRBtnBlockHeight.TabStop = true;
        bpRBtnBlockHeight.Text = "Wysokość bryły";
        bpRBtnBlockHeight.UseVisualStyleBackColor = true;
        // 
        // bpGrBoxBlockOrdering
        // 
        bpGrBoxBlockOrdering.Controls.Add(bpRBtnBlockOrderDecreasing);
        bpGrBoxBlockOrdering.Controls.Add(bpRBtnBlockOrderIncreasing);
        bpGrBoxBlockOrdering.Location = new System.Drawing.Point(754, 508);
        bpGrBoxBlockOrdering.Name = "bpGrBoxBlockOrdering";
        bpGrBoxBlockOrdering.Size = new System.Drawing.Size(182, 57);
        bpGrBoxBlockOrdering.TabIndex = 5;
        bpGrBoxBlockOrdering.TabStop = false;
        bpGrBoxBlockOrdering.Text = "Uporządkowanie brył";
        // 
        // bpRBtnBlockOrderDecreasing
        // 
        bpRBtnBlockOrderDecreasing.Location = new System.Drawing.Point(90, 23);
        bpRBtnBlockOrderDecreasing.Name = "bpRBtnBlockOrderDecreasing";
        bpRBtnBlockOrderDecreasing.Size = new System.Drawing.Size(74, 24);
        bpRBtnBlockOrderDecreasing.TabIndex = 1;
        bpRBtnBlockOrderDecreasing.TabStop = true;
        bpRBtnBlockOrderDecreasing.Text = "Malejąco";
        bpRBtnBlockOrderDecreasing.UseVisualStyleBackColor = true;
        // 
        // bpRBtnBlockOrderIncreasing
        // 
        bpRBtnBlockOrderIncreasing.Location = new System.Drawing.Point(10, 23);
        bpRBtnBlockOrderIncreasing.Name = "bpRBtnBlockOrderIncreasing";
        bpRBtnBlockOrderIncreasing.Size = new System.Drawing.Size(74, 24);
        bpRBtnBlockOrderIncreasing.TabIndex = 0;
        bpRBtnBlockOrderIncreasing.TabStop = true;
        bpRBtnBlockOrderIncreasing.Text = "Rosnąco";
        bpRBtnBlockOrderIncreasing.UseVisualStyleBackColor = true;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // timer2
        // 
        timer2.Interval = 300;
        timer2.Tick += timer2_Tick;
        // 
        // bpBtnRemoveFirstAddedBlock
        // 
        bpBtnRemoveFirstAddedBlock.Location = new System.Drawing.Point(210, 7);
        bpBtnRemoveFirstAddedBlock.Name = "bpBtnRemoveFirstAddedBlock";
        bpBtnRemoveFirstAddedBlock.Size = new System.Drawing.Size(166, 23);
        bpBtnRemoveFirstAddedBlock.TabIndex = 6;
        bpBtnRemoveFirstAddedBlock.Text = "Usuń pierwszą dodaną bryłę";
        bpBtnRemoveFirstAddedBlock.UseVisualStyleBackColor = true;
        // 
        // bpBtnRemoveRecentBlock
        // 
        bpBtnRemoveRecentBlock.Location = new System.Drawing.Point(382, 7);
        bpBtnRemoveRecentBlock.Name = "bpBtnRemoveRecentBlock";
        bpBtnRemoveRecentBlock.Size = new System.Drawing.Size(166, 23);
        bpBtnRemoveRecentBlock.TabIndex = 7;
        bpBtnRemoveRecentBlock.Text = "Usuń ostatnio dodaną bryłę";
        bpBtnRemoveRecentBlock.UseVisualStyleBackColor = true;
        // 
        // bpBtnRemoveSelectedBlock
        // 
        bpBtnRemoveSelectedBlock.Location = new System.Drawing.Point(554, 7);
        bpBtnRemoveSelectedBlock.Name = "bpBtnRemoveSelectedBlock";
        bpBtnRemoveSelectedBlock.Size = new System.Drawing.Size(166, 23);
        bpBtnRemoveSelectedBlock.TabIndex = 8;
        bpBtnRemoveSelectedBlock.Text = "Usuń wybraną bryłę";
        bpBtnRemoveSelectedBlock.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 10F);
        label6.Location = new System.Drawing.Point(726, 7);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(112, 23);
        label6.TabIndex = 9;
        label6.Text = "Wybrana bryła";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // bpTxtSelectedBlock
        // 
        bpTxtSelectedBlock.Location = new System.Drawing.Point(836, 7);
        bpTxtSelectedBlock.Name = "bpTxtSelectedBlock";
        bpTxtSelectedBlock.Size = new System.Drawing.Size(100, 23);
        bpTxtSelectedBlock.TabIndex = 10;
        // 
        // bpGrBoxSlides
        // 
        bpGrBoxSlides.Controls.Add(bpRadioButton);
        bpGrBoxSlides.Controls.Add(bpRadioClock);
        bpGrBoxSlides.Location = new System.Drawing.Point(942, 7);
        bpGrBoxSlides.Name = "bpGrBoxSlides";
        bpGrBoxSlides.Size = new System.Drawing.Size(173, 87);
        bpGrBoxSlides.TabIndex = 11;
        bpGrBoxSlides.TabStop = false;
        bpGrBoxSlides.Text = "Pokaz slajdów";
        // 
        // bpRadioClock
        // 
        bpRadioClock.Location = new System.Drawing.Point(10, 22);
        bpRadioClock.Name = "bpRadioClock";
        bpRadioClock.Size = new System.Drawing.Size(104, 24);
        bpRadioClock.TabIndex = 0;
        bpRadioClock.TabStop = true;
        bpRadioClock.Text = "Zegarowy";
        bpRadioClock.UseVisualStyleBackColor = true;
        // 
        // bpRadioButton
        // 
        bpRadioButton.Location = new System.Drawing.Point(10, 52);
        bpRadioButton.Name = "bpRadioButton";
        bpRadioButton.Size = new System.Drawing.Size(104, 24);
        bpRadioButton.TabIndex = 1;
        bpRadioButton.TabStop = true;
        bpRadioButton.Text = "Przyciskowy";
        bpRadioButton.UseVisualStyleBackColor = true;
        // 
        // bpBtnTurnOnSlider
        // 
        bpBtnTurnOnSlider.Location = new System.Drawing.Point(942, 100);
        bpBtnTurnOnSlider.Name = "bpBtnTurnOnSlider";
        bpBtnTurnOnSlider.Size = new System.Drawing.Size(173, 23);
        bpBtnTurnOnSlider.TabIndex = 12;
        bpBtnTurnOnSlider.Text = "Włącz slider pokazu";
        bpBtnTurnOnSlider.UseVisualStyleBackColor = true;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 10F);
        label7.Location = new System.Drawing.Point(944, 126);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(112, 23);
        label7.TabIndex = 13;
        label7.Text = "Numer bryły";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // bpTxtBlockNumber
        // 
        bpTxtBlockNumber.Location = new System.Drawing.Point(942, 160);
        bpTxtBlockNumber.Name = "bpTxtBlockNumber";
        bpTxtBlockNumber.Size = new System.Drawing.Size(173, 23);
        bpTxtBlockNumber.TabIndex = 14;
        // 
        // bpBtnNext
        // 
        bpBtnNext.Location = new System.Drawing.Point(944, 189);
        bpBtnNext.Name = "bpBtnNext";
        bpBtnNext.Size = new System.Drawing.Size(75, 23);
        bpBtnNext.TabIndex = 15;
        bpBtnNext.Text = "Następny";
        bpBtnNext.UseVisualStyleBackColor = true;
        // 
        // bpBtnPrevious
        // 
        bpBtnPrevious.Location = new System.Drawing.Point(1040, 189);
        bpBtnPrevious.Name = "bpBtnPrevious";
        bpBtnPrevious.Size = new System.Drawing.Size(75, 23);
        bpBtnPrevious.TabIndex = 16;
        bpBtnPrevious.Text = "Poprzedni";
        bpBtnPrevious.UseVisualStyleBackColor = true;
        // 
        // bpBtnTurnOffSlider
        // 
        bpBtnTurnOffSlider.Location = new System.Drawing.Point(942, 218);
        bpBtnTurnOffSlider.Name = "bpBtnTurnOffSlider";
        bpBtnTurnOffSlider.Size = new System.Drawing.Size(173, 23);
        bpBtnTurnOffSlider.TabIndex = 17;
        bpBtnTurnOffSlider.Text = "Wyłącz slider pokazu";
        bpBtnTurnOffSlider.UseVisualStyleBackColor = true;
        // 
        // bpCockpitLaboratory
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1123, 574);
        Controls.Add(bpBtnTurnOffSlider);
        Controls.Add(bpBtnPrevious);
        Controls.Add(bpBtnNext);
        Controls.Add(bpTxtBlockNumber);
        Controls.Add(label7);
        Controls.Add(bpBtnTurnOnSlider);
        Controls.Add(bpGrBoxSlides);
        Controls.Add(bpTxtSelectedBlock);
        Controls.Add(label6);
        Controls.Add(bpBtnRemoveSelectedBlock);
        Controls.Add(bpBtnRemoveRecentBlock);
        Controls.Add(bpBtnRemoveFirstAddedBlock);
        Controls.Add(bpGrBoxBlockOrdering);
        Controls.Add(bpGrBoxBlockVisibilityCriteria);
        Controls.Add(bpBtnAddSelectedBlock);
        Controls.Add(bpPictureBox);
        Controls.Add(bpGrBoxGraphicAttrs);
        Controls.Add(bpGrBoxGeometricAttrs);
        Controls.Add(bpGrBoxBlockList);
        Text = "Bryły obrotowe";
        FormClosing += bpCockpitLaboratory_FormClosing;
        bpGrBoxBlockList.ResumeLayout(false);
        bpGrBoxGeometricAttrs.ResumeLayout(false);
        bpGrBoxGeometricAttrs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockAngle).EndInit();
        ((System.ComponentModel.ISupportInitialize)bpNumUpDownBlockSidesNumber).EndInit();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockRadius).EndInit();
        ((System.ComponentModel.ISupportInitialize)bpTBarBlockHeight).EndInit();
        bpGrBoxGraphicAttrs.ResumeLayout(false);
        bpGrBoxGraphicAttrs.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)bpNumUpDownLineWidth).EndInit();
        ((System.ComponentModel.ISupportInitialize)bpPictureBox).EndInit();
        bpGrBoxBlockVisibilityCriteria.ResumeLayout(false);
        bpGrBoxBlockOrdering.ResumeLayout(false);
        bpGrBoxSlides.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button bpBtnTurnOffSlider;

    private System.Windows.Forms.Button bpBtnNext;
    private System.Windows.Forms.Button bpBtnPrevious;

    private System.Windows.Forms.TextBox bpTxtBlockNumber;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button bpBtnTurnOnSlider;

    private System.Windows.Forms.GroupBox bpGrBoxSlides;

    private System.Windows.Forms.RadioButton bpRadioButton;
    
    private System.Windows.Forms.RadioButton bpRadioClock;

    private System.Windows.Forms.GroupBox Zegar;

    private System.Windows.Forms.TextBox bpTxtSelectedBlock;

    private System.Windows.Forms.Button bpBtnRemoveSelectedBlock;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button bpBtnRemoveFirstAddedBlock;
    private System.Windows.Forms.Button bpBtnRemoveRecentBlock;

    private System.Windows.Forms.Timer timer2;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.RadioButton bpRBtnBlockSurfaceArea;

    private System.Windows.Forms.RadioButton bpRBtnBlockVolume;

    private System.Windows.Forms.RadioButton bpRBtnBlockHeight;

    private System.Windows.Forms.RadioButton bpRBtnBlockOrderIncreasing;
    private System.Windows.Forms.RadioButton bpRBtnBlockOrderDecreasing;

    private System.Windows.Forms.GroupBox bpGrBoxBlockOrdering;

    private System.Windows.Forms.GroupBox bpGrBoxBlockVisibilityCriteria;

    private System.Windows.Forms.Button bpBtnAddSelectedBlock;

    private System.Windows.Forms.PictureBox bpPictureBox;

    private System.Windows.Forms.NumericUpDown bpNumUpDownLineWidth;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.ComboBox bpCBoxLineStyle;

    private System.Windows.Forms.TrackBar bpTBarBlockHeight;

    private System.Windows.Forms.TextBox bpTxtBlockLineColor;

    private System.Windows.Forms.Button bpBtnBlockLineColor;

    private System.Windows.Forms.TrackBar bpTBarBlockAngle;
    private System.Windows.Forms.TextBox bpTxtBlockAngle;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.NumericUpDown bpNumUpDownBlockSidesNumber;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TrackBar bpTBarBlockRadius;
    private System.Windows.Forms.TextBox bpTxtBlockRadius;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox bpTxtBlockHeight;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox bpCBoxBlockType;

    private System.Windows.Forms.GroupBox bpGrBoxGraphicAttrs;

    private System.Windows.Forms.GroupBox bpGrBoxGeometricAttrs;

    private System.Windows.Forms.GroupBox bpGrBoxBlockList;

    #endregion
}