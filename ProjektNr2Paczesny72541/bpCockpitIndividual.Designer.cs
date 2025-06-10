namespace ProjektNr2Paczesny72541
{
    partial class bpCockpitIndividual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            bpPictureBox = new System.Windows.Forms.PictureBox();
            bpGrBoxBlockCreation = new System.Windows.Forms.GroupBox();
            bpBtnAddBlock = new System.Windows.Forms.Button();
            bpCBoxBlockType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            bpGrBoxGeometricAttributes = new System.Windows.Forms.GroupBox();
            bpTxtBlockSlant = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            bpTBarBlockSlant = new System.Windows.Forms.TrackBar();
            bpTxtBlockRadius = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            bpTBarBlockRadius = new System.Windows.Forms.TrackBar();
            bpTxtBlockHeight = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            bpTBarBlockHeight = new System.Windows.Forms.TrackBar();
            bpGrBoxGraphicAttributes = new System.Windows.Forms.GroupBox();
            bpNumUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            bpCBoxLineStyle = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            bpBtnLineColor = new System.Windows.Forms.Button();
            bpGrBoxRotation = new System.Windows.Forms.GroupBox();
            bpChkEnableAutoRotation = new System.Windows.Forms.CheckBox();
            bpBtnRotateRight = new System.Windows.Forms.Button();
            bpBtnRotateLeft = new System.Windows.Forms.Button();
            bpGrBoxSlider = new System.Windows.Forms.GroupBox();
            bpLblCurrentBlockInfo = new System.Windows.Forms.Label();
            bpChkEnableSlider = new System.Windows.Forms.CheckBox();
            bpBtnNext = new System.Windows.Forms.Button();
            bpBtnPrevious = new System.Windows.Forms.Button();
            bpBtnDeleteBlock = new System.Windows.Forms.Button();
            bpColorDialog = new System.Windows.Forms.ColorDialog();
            bpRotationTimer = new System.Windows.Forms.Timer(components);
            bpSliderTimer = new System.Windows.Forms.Timer(components);
            bpLblBlockInfo = new System.Windows.Forms.Label();
            bpTxtBlockInfo = new System.Windows.Forms.TextBox();
            bpBtnMoveUp = new System.Windows.Forms.Button();
            bpBtnMoveDown = new System.Windows.Forms.Button();
            bpBtnMoveLeft = new System.Windows.Forms.Button();
            bpBtnMoveRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bpPictureBox).BeginInit();
            bpGrBoxBlockCreation.SuspendLayout();
            bpGrBoxGeometricAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockSlant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockHeight).BeginInit();
            bpGrBoxGraphicAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bpNumUpDownLineWidth).BeginInit();
            bpGrBoxRotation.SuspendLayout();
            bpGrBoxSlider.SuspendLayout();
            SuspendLayout();
            //
            // bpPictureBox
            //
            bpPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bpPictureBox.Location = new System.Drawing.Point(313, 14);
            bpPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpPictureBox.Name = "bpPictureBox";
            bpPictureBox.Size = new System.Drawing.Size(821, 735);
            bpPictureBox.TabIndex = 0;
            bpPictureBox.TabStop = false;
            bpPictureBox.Paint += bpPictureBox_Paint;
            bpPictureBox.MouseClick += bpPictureBox_MouseClick;
            //
            // bpGrBoxBlockCreation
            //
            bpGrBoxBlockCreation.Controls.Add(bpBtnAddBlock);
            bpGrBoxBlockCreation.Controls.Add(bpCBoxBlockType);
            bpGrBoxBlockCreation.Controls.Add(label1);
            bpGrBoxBlockCreation.Location = new System.Drawing.Point(14, 14);
            bpGrBoxBlockCreation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxBlockCreation.Name = "bpGrBoxBlockCreation";
            bpGrBoxBlockCreation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxBlockCreation.Size = new System.Drawing.Size(292, 104);
            bpGrBoxBlockCreation.TabIndex = 1;
            bpGrBoxBlockCreation.TabStop = false;
            bpGrBoxBlockCreation.Text = "Nowa bryła";
            //
            // bpBtnAddBlock
            //
            bpBtnAddBlock.Location = new System.Drawing.Point(69, 61);
            bpBtnAddBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnAddBlock.Name = "bpBtnAddBlock";
            bpBtnAddBlock.Size = new System.Drawing.Size(141, 27);
            bpBtnAddBlock.TabIndex = 2;
            bpBtnAddBlock.Text = "Dodaj nową bryłę";
            bpBtnAddBlock.UseVisualStyleBackColor = true;
            bpBtnAddBlock.Click += bpBtnAddBlock_Click;
            //
            // bpCBoxBlockType
            //
            bpCBoxBlockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            bpCBoxBlockType.FormattingEnabled = true;
            bpCBoxBlockType.Location = new System.Drawing.Point(107, 30);
            bpCBoxBlockType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpCBoxBlockType.Name = "bpCBoxBlockType";
            bpCBoxBlockType.Size = new System.Drawing.Size(177, 23);
            bpCBoxBlockType.TabIndex = 1;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 33);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Wybierz bryłę";
            //
            // bpGrBoxGeometricAttributes
            //
            bpGrBoxGeometricAttributes.Controls.Add(bpTxtBlockSlant);
            bpGrBoxGeometricAttributes.Controls.Add(label6);
            bpGrBoxGeometricAttributes.Controls.Add(bpTBarBlockSlant);
            bpGrBoxGeometricAttributes.Controls.Add(bpTxtBlockRadius);
            bpGrBoxGeometricAttributes.Controls.Add(label3);
            bpGrBoxGeometricAttributes.Controls.Add(bpTBarBlockRadius);
            bpGrBoxGeometricAttributes.Controls.Add(bpTxtBlockHeight);
            bpGrBoxGeometricAttributes.Controls.Add(label2);
            bpGrBoxGeometricAttributes.Controls.Add(bpTBarBlockHeight);
            bpGrBoxGeometricAttributes.Location = new System.Drawing.Point(14, 125);
            bpGrBoxGeometricAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxGeometricAttributes.Name = "bpGrBoxGeometricAttributes";
            bpGrBoxGeometricAttributes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxGeometricAttributes.Size = new System.Drawing.Size(292, 208);
            bpGrBoxGeometricAttributes.TabIndex = 2;
            bpGrBoxGeometricAttributes.TabStop = false;
            bpGrBoxGeometricAttributes.Text = "Atrybuty geometryczne";
            //
            // bpTxtBlockSlant
            //
            bpTxtBlockSlant.Location = new System.Drawing.Point(236, 143);
            bpTxtBlockSlant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTxtBlockSlant.Name = "bpTxtBlockSlant";
            bpTxtBlockSlant.ReadOnly = true;
            bpTxtBlockSlant.Size = new System.Drawing.Size(48, 23);
            bpTxtBlockSlant.TabIndex = 8;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 147);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 15);
            label6.TabIndex = 7;
            label6.Text = "Pochylenie";
            //
            // bpTBarBlockSlant
            //
            bpTBarBlockSlant.Location = new System.Drawing.Point(83, 143);
            bpTBarBlockSlant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTBarBlockSlant.Maximum = 50;
            bpTBarBlockSlant.Minimum = -50;
            bpTBarBlockSlant.Name = "bpTBarBlockSlant";
            bpTBarBlockSlant.Size = new System.Drawing.Size(146, 45);
            bpTBarBlockSlant.TabIndex = 6;
            bpTBarBlockSlant.Scroll += bpTBarBlockSlant_Scroll;
            //
            // bpTxtBlockRadius
            //
            bpTxtBlockRadius.Location = new System.Drawing.Point(236, 88);
            bpTxtBlockRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTxtBlockRadius.Name = "bpTxtBlockRadius";
            bpTxtBlockRadius.ReadOnly = true;
            bpTxtBlockRadius.Size = new System.Drawing.Size(48, 23);
            bpTxtBlockRadius.TabIndex = 5;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 91);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Promień";
            //
            // bpTBarBlockRadius
            //
            bpTBarBlockRadius.Location = new System.Drawing.Point(83, 88);
            bpTBarBlockRadius.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTBarBlockRadius.Maximum = 200;
            bpTBarBlockRadius.Minimum = 10;
            bpTBarBlockRadius.Name = "bpTBarBlockRadius";
            bpTBarBlockRadius.Size = new System.Drawing.Size(146, 45);
            bpTBarBlockRadius.TabIndex = 3;
            bpTBarBlockRadius.Value = 50;
            bpTBarBlockRadius.Scroll += bpTBarBlockRadius_Scroll;
            //
            // bpTxtBlockHeight
            //
            bpTxtBlockHeight.Location = new System.Drawing.Point(236, 32);
            bpTxtBlockHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTxtBlockHeight.Name = "bpTxtBlockHeight";
            bpTxtBlockHeight.ReadOnly = true;
            bpTxtBlockHeight.Size = new System.Drawing.Size(48, 23);
            bpTxtBlockHeight.TabIndex = 2;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 36);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Wysokość";
            //
            // bpTBarBlockHeight
            //
            bpTBarBlockHeight.Location = new System.Drawing.Point(83, 32);
            bpTBarBlockHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTBarBlockHeight.Maximum = 300;
            bpTBarBlockHeight.Minimum = 20;
            bpTBarBlockHeight.Name = "bpTBarBlockHeight";
            bpTBarBlockHeight.Size = new System.Drawing.Size(146, 45);
            bpTBarBlockHeight.TabIndex = 0;
            bpTBarBlockHeight.Value = 100;
            bpTBarBlockHeight.Scroll += bpTBarBlockHeight_Scroll;
            //
            // bpGrBoxGraphicAttributes
            //
            bpGrBoxGraphicAttributes.Controls.Add(bpNumUpDownLineWidth);
            bpGrBoxGraphicAttributes.Controls.Add(label5);
            bpGrBoxGraphicAttributes.Controls.Add(bpCBoxLineStyle);
            bpGrBoxGraphicAttributes.Controls.Add(label4);
            bpGrBoxGraphicAttributes.Controls.Add(bpBtnLineColor);
            bpGrBoxGraphicAttributes.Location = new System.Drawing.Point(14, 339);
            bpGrBoxGraphicAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxGraphicAttributes.Name = "bpGrBoxGraphicAttributes";
            bpGrBoxGraphicAttributes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxGraphicAttributes.Size = new System.Drawing.Size(292, 133);
            bpGrBoxGraphicAttributes.TabIndex = 3;
            bpGrBoxGraphicAttributes.TabStop = false;
            bpGrBoxGraphicAttributes.Text = "Atrybuty graficzne";
            //
            // bpNumUpDownLineWidth
            //
            bpNumUpDownLineWidth.Location = new System.Drawing.Point(107, 95);
            bpNumUpDownLineWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpNumUpDownLineWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            bpNumUpDownLineWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            bpNumUpDownLineWidth.Name = "bpNumUpDownLineWidth";
            bpNumUpDownLineWidth.Size = new System.Drawing.Size(140, 23);
            bpNumUpDownLineWidth.TabIndex = 4;
            bpNumUpDownLineWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bpNumUpDownLineWidth.ValueChanged += bpNumUpDownLineWidth_ValueChanged;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 97);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 15);
            label5.TabIndex = 3;
            label5.Text = "Grubość linii";
            //
            // bpCBoxLineStyle
            //
            bpCBoxLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            bpCBoxLineStyle.FormattingEnabled = true;
            bpCBoxLineStyle.Location = new System.Drawing.Point(107, 61);
            bpCBoxLineStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpCBoxLineStyle.Name = "bpCBoxLineStyle";
            bpCBoxLineStyle.Size = new System.Drawing.Size(140, 23);
            bpCBoxLineStyle.TabIndex = 2;
            bpCBoxLineStyle.SelectedIndexChanged += bpCBoxLineStyle_SelectedIndexChanged;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 65);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Styl Linii";
            //
            // bpBtnLineColor
            //
            bpBtnLineColor.Location = new System.Drawing.Point(10, 27);
            bpBtnLineColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnLineColor.Name = "bpBtnLineColor";
            bpBtnLineColor.Size = new System.Drawing.Size(117, 27);
            bpBtnLineColor.TabIndex = 0;
            bpBtnLineColor.Text = "Zmień kolor linii";
            bpBtnLineColor.UseVisualStyleBackColor = true;
            bpBtnLineColor.Click += bpBtnLineColor_Click;
            //
            // bpGrBoxRotation
            //
            bpGrBoxRotation.Controls.Add(bpChkEnableAutoRotation);
            bpGrBoxRotation.Controls.Add(bpBtnRotateRight);
            bpGrBoxRotation.Controls.Add(bpBtnRotateLeft);
            bpGrBoxRotation.Location = new System.Drawing.Point(14, 479);
            bpGrBoxRotation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxRotation.Name = "bpGrBoxRotation";
            bpGrBoxRotation.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxRotation.Size = new System.Drawing.Size(292, 92);
            bpGrBoxRotation.TabIndex = 4;
            bpGrBoxRotation.TabStop = false;
            bpGrBoxRotation.Text = "Obracanie bryły";
            //
            // bpChkEnableAutoRotation
            //
            bpChkEnableAutoRotation.AutoSize = true;
            bpChkEnableAutoRotation.Location = new System.Drawing.Point(69, 61);
            bpChkEnableAutoRotation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpChkEnableAutoRotation.Name = "bpChkEnableAutoRotation";
            bpChkEnableAutoRotation.Size = new System.Drawing.Size(135, 19);
            bpChkEnableAutoRotation.TabIndex = 2;
            bpChkEnableAutoRotation.Text = "Automatyczny obrót";
            bpChkEnableAutoRotation.UseVisualStyleBackColor = true;
            bpChkEnableAutoRotation.CheckedChanged += bpChkEnableAutoRotation_CheckedChanged;
            //
            // bpBtnRotateRight
            //
            bpBtnRotateRight.Location = new System.Drawing.Point(152, 28);
            bpBtnRotateRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnRotateRight.Name = "bpBtnRotateRight";
            bpBtnRotateRight.Size = new System.Drawing.Size(105, 27);
            bpBtnRotateRight.TabIndex = 1;
            bpBtnRotateRight.Text = "Obróć w prawo";
            bpBtnRotateRight.UseVisualStyleBackColor = true;
            bpBtnRotateRight.Click += bpBtnRotateRight_Click;
            //
            // bpBtnRotateLeft
            //
            bpBtnRotateLeft.Location = new System.Drawing.Point(33, 28);
            bpBtnRotateLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnRotateLeft.Name = "bpBtnRotateLeft";
            bpBtnRotateLeft.Size = new System.Drawing.Size(105, 27);
            bpBtnRotateLeft.TabIndex = 0;
            bpBtnRotateLeft.Text = "Obróć w lewo";
            bpBtnRotateLeft.UseVisualStyleBackColor = true;
            bpBtnRotateLeft.Click += bpBtnRotateLeft_Click;
            //
            // bpGrBoxSlider
            //
            bpGrBoxSlider.Controls.Add(bpLblCurrentBlockInfo);
            bpGrBoxSlider.Controls.Add(bpChkEnableSlider);
            bpGrBoxSlider.Controls.Add(bpBtnNext);
            bpGrBoxSlider.Controls.Add(bpBtnPrevious);
            bpGrBoxSlider.Location = new System.Drawing.Point(14, 578);
            bpGrBoxSlider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxSlider.Name = "bpGrBoxSlider";
            bpGrBoxSlider.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpGrBoxSlider.Size = new System.Drawing.Size(292, 92);
            bpGrBoxSlider.TabIndex = 5;
            bpGrBoxSlider.TabStop = false;
            bpGrBoxSlider.Text = "Przeglądanie brył (slider)";
            //
            // bpLblCurrentBlockInfo
            //
            bpLblCurrentBlockInfo.AutoSize = true;
            bpLblCurrentBlockInfo.Location = new System.Drawing.Point(114, 33);
            bpLblCurrentBlockInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bpLblCurrentBlockInfo.Name = "bpLblCurrentBlockInfo";
            bpLblCurrentBlockInfo.Size = new System.Drawing.Size(56, 15);
            bpLblCurrentBlockInfo.TabIndex = 3;
            bpLblCurrentBlockInfo.Text = "Bryła: 0/0";
            //
            // bpChkEnableSlider
            //
            bpChkEnableSlider.AutoSize = true;
            bpChkEnableSlider.Location = new System.Drawing.Point(72, 62);
            bpChkEnableSlider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpChkEnableSlider.Name = "bpChkEnableSlider";
            bpChkEnableSlider.Size = new System.Drawing.Size(137, 19);
            bpChkEnableSlider.TabIndex = 2;
            bpChkEnableSlider.Text = "Automatyczny pokaz";
            bpChkEnableSlider.UseVisualStyleBackColor = true;
            bpChkEnableSlider.CheckedChanged += bpChkEnableSlider_CheckedChanged;
            //
            // bpBtnNext
            //
            bpBtnNext.Location = new System.Drawing.Point(195, 28);
            bpBtnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnNext.Name = "bpBtnNext";
            bpBtnNext.Size = new System.Drawing.Size(88, 27);
            bpBtnNext.TabIndex = 1;
            bpBtnNext.Text = "Następny";
            bpBtnNext.UseVisualStyleBackColor = true;
            bpBtnNext.Click += bpBtnNext_Click;
            //
            // bpBtnPrevious
            //
            bpBtnPrevious.Location = new System.Drawing.Point(10, 28);
            bpBtnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnPrevious.Name = "bpBtnPrevious";
            bpBtnPrevious.Size = new System.Drawing.Size(88, 27);
            bpBtnPrevious.TabIndex = 0;
            bpBtnPrevious.Text = "Poprzedni";
            bpBtnPrevious.UseVisualStyleBackColor = true;
            bpBtnPrevious.Click += bpBtnPrevious_Click;
            //
            // bpBtnDeleteBlock
            //
            bpBtnDeleteBlock.Location = new System.Drawing.Point(72, 718);
            bpBtnDeleteBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnDeleteBlock.Name = "bpBtnDeleteBlock";
            bpBtnDeleteBlock.Size = new System.Drawing.Size(152, 27);
            bpBtnDeleteBlock.TabIndex = 6;
            bpBtnDeleteBlock.Text = "Usuń aktywną bryłę";
            bpBtnDeleteBlock.UseVisualStyleBackColor = true;
            bpBtnDeleteBlock.Click += bpBtnDeleteBlock_Click;
            //
            // bpRotationTimer
            //
            bpRotationTimer.Interval = 50;
            bpRotationTimer.Tick += bpRotationTimer_Tick;
            //
            // bpSliderTimer
            //
            bpSliderTimer.Interval = 1000;
            bpSliderTimer.Tick += bpSliderTimer_Tick;
            //
            // bpLblBlockInfo
            //
            bpLblBlockInfo.AutoSize = true;
            bpLblBlockInfo.Location = new System.Drawing.Point(14, 681);
            bpLblBlockInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bpLblBlockInfo.Name = "bpLblBlockInfo";
            bpLblBlockInfo.Size = new System.Drawing.Size(117, 15);
            bpLblBlockInfo.TabIndex = 7;
            bpLblBlockInfo.Text = "Info o aktywnej bryle";
            //
            // bpTxtBlockInfo
            //
            bpTxtBlockInfo.Location = new System.Drawing.Point(132, 677);
            bpTxtBlockInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpTxtBlockInfo.Name = "bpTxtBlockInfo";
            bpTxtBlockInfo.ReadOnly = true;
            bpTxtBlockInfo.Size = new System.Drawing.Size(173, 23);
            bpTxtBlockInfo.TabIndex = 8;
            //
            // bpBtnMoveUp
            //
            bpBtnMoveUp.Location = new System.Drawing.Point(313, 755);
            bpBtnMoveUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnMoveUp.Name = "bpBtnMoveUp";
            bpBtnMoveUp.Size = new System.Drawing.Size(88, 27);
            bpBtnMoveUp.TabIndex = 3;
            bpBtnMoveUp.Text = "Up";
            bpBtnMoveUp.UseVisualStyleBackColor = true;
            bpBtnMoveUp.Click += bpBtnMoveUp_Click;
            //
            // bpBtnMoveDown
            //
            bpBtnMoveDown.Location = new System.Drawing.Point(409, 755);
            bpBtnMoveDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnMoveDown.Name = "bpBtnMoveDown";
            bpBtnMoveDown.Size = new System.Drawing.Size(88, 27);
            bpBtnMoveDown.TabIndex = 4;
            bpBtnMoveDown.Text = "Down";
            bpBtnMoveDown.UseVisualStyleBackColor = true;
            bpBtnMoveDown.Click += bpBtnMoveDown_Click;
            //
            // bpBtnMoveLeft
            //
            bpBtnMoveLeft.Location = new System.Drawing.Point(505, 755);
            bpBtnMoveLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnMoveLeft.Name = "bpBtnMoveLeft";
            bpBtnMoveLeft.Size = new System.Drawing.Size(88, 27);
            bpBtnMoveLeft.TabIndex = 5;
            bpBtnMoveLeft.Text = "Left";
            bpBtnMoveLeft.UseVisualStyleBackColor = true;
            bpBtnMoveLeft.Click += bpBtnMoveLeft_Click;
            //
            // bpBtnMoveRight
            //
            bpBtnMoveRight.Location = new System.Drawing.Point(601, 755);
            bpBtnMoveRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bpBtnMoveRight.Name = "bpBtnMoveRight";
            bpBtnMoveRight.Size = new System.Drawing.Size(88, 27);
            bpBtnMoveRight.TabIndex = 6;
            bpBtnMoveRight.Text = "Right";
            bpBtnMoveRight.UseVisualStyleBackColor = true;
            bpBtnMoveRight.Click += bpBtnMoveRight_Click;
            //
            // bpCockpitIndividual
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 788);
            Controls.Add(bpTxtBlockInfo);
            Controls.Add(bpLblBlockInfo);
            Controls.Add(bpBtnDeleteBlock);
            Controls.Add(bpGrBoxSlider);
            Controls.Add(bpGrBoxRotation);
            Controls.Add(bpGrBoxGraphicAttributes);
            Controls.Add(bpGrBoxGeometricAttributes);
            Controls.Add(bpGrBoxBlockCreation);
            Controls.Add(bpPictureBox);
            Controls.Add(bpBtnMoveUp);
            Controls.Add(bpBtnMoveDown);
            Controls.Add(bpBtnMoveLeft);
            Controls.Add(bpBtnMoveRight);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Text = "Projekt Indywidualny Nr 2 - bartosz Paczesny 72541";
            FormClosing += bpCockpitIndividual_FormClosing;
            Load += bpCockpitIndividual_Load;
            ((System.ComponentModel.ISupportInitialize)bpPictureBox).EndInit();
            bpGrBoxBlockCreation.ResumeLayout(false);
            bpGrBoxBlockCreation.PerformLayout();
            bpGrBoxGeometricAttributes.ResumeLayout(false);
            bpGrBoxGeometricAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockSlant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpTBarBlockHeight).EndInit();
            bpGrBoxGraphicAttributes.ResumeLayout(false);
            bpGrBoxGraphicAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bpNumUpDownLineWidth).EndInit();
            bpGrBoxRotation.ResumeLayout(false);
            bpGrBoxRotation.PerformLayout();
            bpGrBoxSlider.ResumeLayout(false);
            bpGrBoxSlider.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox bpPictureBox;
        private System.Windows.Forms.GroupBox bpGrBoxBlockCreation;
        private System.Windows.Forms.Button bpBtnAddBlock;
        private System.Windows.Forms.ComboBox bpCBoxBlockType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bpGrBoxGeometricAttributes;
        private System.Windows.Forms.TrackBar bpTBarBlockHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bpTxtBlockHeight;
        private System.Windows.Forms.TextBox bpTxtBlockRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar bpTBarBlockRadius;
        private System.Windows.Forms.GroupBox bpGrBoxGraphicAttributes;
        private System.Windows.Forms.Button bpBtnLineColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bpCBoxLineStyle;
        private System.Windows.Forms.NumericUpDown bpNumUpDownLineWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox bpGrBoxRotation;
        private System.Windows.Forms.Button bpBtnRotateLeft;
        private System.Windows.Forms.Button bpBtnRotateRight;
        private System.Windows.Forms.CheckBox bpChkEnableAutoRotation;
        private System.Windows.Forms.GroupBox bpGrBoxSlider;
        private System.Windows.Forms.Button bpBtnPrevious;
        private System.Windows.Forms.Button bpBtnNext;
        private System.Windows.Forms.CheckBox bpChkEnableSlider;
        private System.Windows.Forms.Label bpLblCurrentBlockInfo;
        private System.Windows.Forms.Button bpBtnDeleteBlock;
        private System.Windows.Forms.ColorDialog bpColorDialog;
        private System.Windows.Forms.Timer bpRotationTimer;
        private System.Windows.Forms.Timer bpSliderTimer;
        private System.Windows.Forms.TextBox bpTxtBlockSlant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar bpTBarBlockSlant;
        private System.Windows.Forms.Label bpLblBlockInfo;
        private System.Windows.Forms.TextBox bpTxtBlockInfo;
        private System.Windows.Forms.Button bpBtnMoveUp;
        private System.Windows.Forms.Button bpBtnMoveDown;
        private System.Windows.Forms.Button bpBtnMoveLeft;
        private System.Windows.Forms.Button bpBtnMoveRight;
    }
}