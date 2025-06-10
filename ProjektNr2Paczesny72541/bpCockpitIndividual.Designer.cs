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
            this.components = new System.ComponentModel.Container();
            this.bpPictureBox = new System.Windows.Forms.PictureBox();
            this.bpGrBoxBlockCreation = new System.Windows.Forms.GroupBox();
            this.bpBtnAddBlock = new System.Windows.Forms.Button();
            this.bpCBoxBlockType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bpGrBoxGeometricAttributes = new System.Windows.Forms.GroupBox();
            this.bpTxtBlockSlant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bpTBarBlockSlant = new System.Windows.Forms.TrackBar();
            this.bpTxtBlockRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bpTBarBlockRadius = new System.Windows.Forms.TrackBar();
            this.bpTxtBlockHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpTBarBlockHeight = new System.Windows.Forms.TrackBar();
            this.bpGrBoxGraphicAttributes = new System.Windows.Forms.GroupBox();
            this.bpNumUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bpCBoxLineStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bpBtnLineColor = new System.Windows.Forms.Button();
            this.bpGrBoxRotation = new System.Windows.Forms.GroupBox();
            this.bpChkEnableAutoRotation = new System.Windows.Forms.CheckBox();
            this.bpBtnRotateRight = new System.Windows.Forms.Button();
            this.bpBtnRotateLeft = new System.Windows.Forms.Button();
            this.bpGrBoxSlider = new System.Windows.Forms.GroupBox();
            this.bpLblCurrentBlockInfo = new System.Windows.Forms.Label();
            this.bpChkEnableSlider = new System.Windows.Forms.CheckBox();
            this.bpBtnNext = new System.Windows.Forms.Button();
            this.bpBtnPrevious = new System.Windows.Forms.Button();
            this.bpBtnDeleteBlock = new System.Windows.Forms.Button();
            this.bpColorDialog = new System.Windows.Forms.ColorDialog();
            this.bpRotationTimer = new System.Windows.Forms.Timer(this.components);
            this.bpSliderTimer = new System.Windows.Forms.Timer(this.components);
            this.bpLblBlockInfo = new System.Windows.Forms.Label();
            this.bpTxtBlockInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bpPictureBox)).BeginInit();
            this.bpGrBoxBlockCreation.SuspendLayout();
            this.bpGrBoxGeometricAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockSlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockHeight)).BeginInit();
            this.bpGrBoxGraphicAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpNumUpDownLineWidth)).BeginInit();
            this.bpGrBoxRotation.SuspendLayout();
            this.bpGrBoxSlider.SuspendLayout();
            this.SuspendLayout();
            //
            // bpPictureBox
            //
            this.bpPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bpPictureBox.Location = new System.Drawing.Point(268, 12);
            this.bpPictureBox.Name = "bpPictureBox";
            this.bpPictureBox.Size = new System.Drawing.Size(704, 637);
            this.bpPictureBox.TabIndex = 0;
            this.bpPictureBox.TabStop = false;
            this.bpPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.bpPictureBox_Paint);
            this.bpPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bpPictureBox_MouseClick);
            //
            // bpGrBoxBlockCreation
            //
            this.bpGrBoxBlockCreation.Controls.Add(this.bpBtnAddBlock);
            this.bpGrBoxBlockCreation.Controls.Add(this.bpCBoxBlockType);
            this.bpGrBoxBlockCreation.Controls.Add(this.label1);
            this.bpGrBoxBlockCreation.Location = new System.Drawing.Point(12, 12);
            this.bpGrBoxBlockCreation.Name = "bpGrBoxBlockCreation";
            this.bpGrBoxBlockCreation.Size = new System.Drawing.Size(250, 90);
            this.bpGrBoxBlockCreation.TabIndex = 1;
            this.bpGrBoxBlockCreation.TabStop = false;
            this.bpGrBoxBlockCreation.Text = "Nowa bryła";
            //
            // bpBtnAddBlock
            //
            this.bpBtnAddBlock.Location = new System.Drawing.Point(59, 53);
            this.bpBtnAddBlock.Name = "bpBtnAddBlock";
            this.bpBtnAddBlock.Size = new System.Drawing.Size(121, 23);
            this.bpBtnAddBlock.TabIndex = 2;
            this.bpBtnAddBlock.Text = "Dodaj nową bryłę";
            this.bpBtnAddBlock.UseVisualStyleBackColor = true;
            this.bpBtnAddBlock.Click += new System.EventHandler(this.bpBtnAddBlock_Click);
            //
            // bpCBoxBlockType
            //
            this.bpCBoxBlockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bpCBoxBlockType.FormattingEnabled = true;
            this.bpCBoxBlockType.Location = new System.Drawing.Point(92, 26);
            this.bpCBoxBlockType.Name = "bpCBoxBlockType";
            this.bpCBoxBlockType.Size = new System.Drawing.Size(152, 21);
            this.bpCBoxBlockType.TabIndex = 1;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz bryłę";
            //
            // bpGrBoxGeometricAttributes
            //
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTxtBlockSlant);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.label6);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTBarBlockSlant);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTxtBlockRadius);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.label3);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTBarBlockRadius);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTxtBlockHeight);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.label2);
            this.bpGrBoxGeometricAttributes.Controls.Add(this.bpTBarBlockHeight);
            this.bpGrBoxGeometricAttributes.Location = new System.Drawing.Point(12, 108);
            this.bpGrBoxGeometricAttributes.Name = "bpGrBoxGeometricAttributes";
            this.bpGrBoxGeometricAttributes.Size = new System.Drawing.Size(250, 180);
            this.bpGrBoxGeometricAttributes.TabIndex = 2;
            this.bpGrBoxGeometricAttributes.TabStop = false;
            this.bpGrBoxGeometricAttributes.Text = "Atrybuty geometryczne";
            //
            // bpTxtBlockSlant
            //
            this.bpTxtBlockSlant.Location = new System.Drawing.Point(202, 124);
            this.bpTxtBlockSlant.Name = "bpTxtBlockSlant";
            this.bpTxtBlockSlant.ReadOnly = true;
            this.bpTxtBlockSlant.Size = new System.Drawing.Size(42, 20);
            this.bpTxtBlockSlant.TabIndex = 8;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pochylenie";
            //
            // bpTBarBlockSlant
            //
            this.bpTBarBlockSlant.Location = new System.Drawing.Point(71, 124);
            this.bpTBarBlockSlant.Maximum = 50;
            this.bpTBarBlockSlant.Minimum = -50;
            this.bpTBarBlockSlant.Name = "bpTBarBlockSlant";
            this.bpTBarBlockSlant.Size = new System.Drawing.Size(125, 45);
            this.bpTBarBlockSlant.TabIndex = 6;
            this.bpTBarBlockSlant.Scroll += new System.EventHandler(this.bpTBarBlockSlant_Scroll);
            //
            // bpTxtBlockRadius
            //
            this.bpTxtBlockRadius.Location = new System.Drawing.Point(202, 76);
            this.bpTxtBlockRadius.Name = "bpTxtBlockRadius";
            this.bpTxtBlockRadius.ReadOnly = true;
            this.bpTxtBlockRadius.Size = new System.Drawing.Size(42, 20);
            this.bpTxtBlockRadius.TabIndex = 5;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promień";
            //
            // bpTBarBlockRadius
            //
            this.bpTBarBlockRadius.Location = new System.Drawing.Point(71, 76);
            this.bpTBarBlockRadius.Maximum = 200;
            this.bpTBarBlockRadius.Minimum = 10;
            this.bpTBarBlockRadius.Name = "bpTBarBlockRadius";
            this.bpTBarBlockRadius.Size = new System.Drawing.Size(125, 45);
            this.bpTBarBlockRadius.TabIndex = 3;
            this.bpTBarBlockRadius.Value = 50;
            this.bpTBarBlockRadius.Scroll += new System.EventHandler(this.bpTBarBlockRadius_Scroll);
            //
            // bpTxtBlockHeight
            //
            this.bpTxtBlockHeight.Location = new System.Drawing.Point(202, 28);
            this.bpTxtBlockHeight.Name = "bpTxtBlockHeight";
            this.bpTxtBlockHeight.ReadOnly = true;
            this.bpTxtBlockHeight.Size = new System.Drawing.Size(42, 20);
            this.bpTxtBlockHeight.TabIndex = 2;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wysokość";
            //
            // bpTBarBlockHeight
            //
            this.bpTBarBlockHeight.Location = new System.Drawing.Point(71, 28);
            this.bpTBarBlockHeight.Maximum = 300;
            this.bpTBarBlockHeight.Minimum = 20;
            this.bpTBarBlockHeight.Name = "bpTBarBlockHeight";
            this.bpTBarBlockHeight.Size = new System.Drawing.Size(125, 45);
            this.bpTBarBlockHeight.TabIndex = 0;
            this.bpTBarBlockHeight.Value = 100;
            this.bpTBarBlockHeight.Scroll += new System.EventHandler(this.bpTBarBlockHeight_Scroll);
            //
            // bpGrBoxGraphicAttributes
            //
            this.bpGrBoxGraphicAttributes.Controls.Add(this.bpNumUpDownLineWidth);
            this.bpGrBoxGraphicAttributes.Controls.Add(this.label5);
            this.bpGrBoxGraphicAttributes.Controls.Add(this.bpCBoxLineStyle);
            this.bpGrBoxGraphicAttributes.Controls.Add(this.label4);
            this.bpGrBoxGraphicAttributes.Controls.Add(this.bpBtnLineColor);
            this.bpGrBoxGraphicAttributes.Location = new System.Drawing.Point(12, 294);
            this.bpGrBoxGraphicAttributes.Name = "bpGrBoxGraphicAttributes";
            this.bpGrBoxGraphicAttributes.Size = new System.Drawing.Size(250, 115);
            this.bpGrBoxGraphicAttributes.TabIndex = 3;
            this.bpGrBoxGraphicAttributes.TabStop = false;
            this.bpGrBoxGraphicAttributes.Text = "Atrybuty graficzne";
            //
            // bpNumUpDownLineWidth
            //
            this.bpNumUpDownLineWidth.Location = new System.Drawing.Point(92, 82);
            this.bpNumUpDownLineWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bpNumUpDownLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bpNumUpDownLineWidth.Name = "bpNumUpDownLineWidth";
            this.bpNumUpDownLineWidth.Size = new System.Drawing.Size(120, 20);
            this.bpNumUpDownLineWidth.TabIndex = 4;
            this.bpNumUpDownLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bpNumUpDownLineWidth.ValueChanged += new System.EventHandler(this.bpNumUpDownLineWidth_ValueChanged);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Grubość linii";
            //
            // bpCBoxLineStyle
            //
            this.bpCBoxLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bpCBoxLineStyle.FormattingEnabled = true;
            this.bpCBoxLineStyle.Location = new System.Drawing.Point(92, 53);
            this.bpCBoxLineStyle.Name = "bpCBoxLineStyle";
            this.bpCBoxLineStyle.Size = new System.Drawing.Size(121, 21);
            this.bpCBoxLineStyle.TabIndex = 2;
            this.bpCBoxLineStyle.SelectedIndexChanged += new System.EventHandler(this.bpCBoxLineStyle_SelectedIndexChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Styl Linii";
            //
            // bpBtnLineColor
            //
            this.bpBtnLineColor.Location = new System.Drawing.Point(9, 23);
            this.bpBtnLineColor.Name = "bpBtnLineColor";
            this.bpBtnLineColor.Size = new System.Drawing.Size(100, 23);
            this.bpBtnLineColor.TabIndex = 0;
            this.bpBtnLineColor.Text = "Zmień kolor linii";
            this.bpBtnLineColor.UseVisualStyleBackColor = true;
            this.bpBtnLineColor.Click += new System.EventHandler(this.bpBtnLineColor_Click);
            //
            // bpGrBoxRotation
            //
            this.bpGrBoxRotation.Controls.Add(this.bpChkEnableAutoRotation);
            this.bpGrBoxRotation.Controls.Add(this.bpBtnRotateRight);
            this.bpGrBoxRotation.Controls.Add(this.bpBtnRotateLeft);
            this.bpGrBoxRotation.Location = new System.Drawing.Point(12, 415);
            this.bpGrBoxRotation.Name = "bpGrBoxRotation";
            this.bpGrBoxRotation.Size = new System.Drawing.Size(250, 80);
            this.bpGrBoxRotation.TabIndex = 4;
            this.bpGrBoxRotation.TabStop = false;
            this.bpGrBoxRotation.Text = "Obracanie bryły";
            //
            // bpChkEnableAutoRotation
            //
            this.bpChkEnableAutoRotation.AutoSize = true;
            this.bpChkEnableAutoRotation.Location = new System.Drawing.Point(59, 53);
            this.bpChkEnableAutoRotation.Name = "bpChkEnableAutoRotation";
            this.bpChkEnableAutoRotation.Size = new System.Drawing.Size(130, 17);
            this.bpChkEnableAutoRotation.TabIndex = 2;
            this.bpChkEnableAutoRotation.Text = "Automatyczny obrót";
            this.bpChkEnableAutoRotation.UseVisualStyleBackColor = true;
            this.bpChkEnableAutoRotation.CheckedChanged += new System.EventHandler(this.bpChkEnableAutoRotation_CheckedChanged);
            //
            // bpBtnRotateRight
            //
            this.bpBtnRotateRight.Location = new System.Drawing.Point(130, 24);
            this.bpBtnRotateRight.Name = "bpBtnRotateRight";
            this.bpBtnRotateRight.Size = new System.Drawing.Size(90, 23);
            this.bpBtnRotateRight.TabIndex = 1;
            this.bpBtnRotateRight.Text = "Obróć w prawo";
            this.bpBtnRotateRight.UseVisualStyleBackColor = true;
            this.bpBtnRotateRight.Click += new System.EventHandler(this.bpBtnRotateRight_Click);
            //
            // bpBtnRotateLeft
            //
            this.bpBtnRotateLeft.Location = new System.Drawing.Point(28, 24);
            this.bpBtnRotateLeft.Name = "bpBtnRotateLeft";
            this.bpBtnRotateLeft.Size = new System.Drawing.Size(90, 23);
            this.bpBtnRotateLeft.TabIndex = 0;
            this.bpBtnRotateLeft.Text = "Obróć w lewo";
            this.bpBtnRotateLeft.UseVisualStyleBackColor = true;
            this.bpBtnRotateLeft.Click += new System.EventHandler(this.bpBtnRotateLeft_Click);
            //
            // bpGrBoxSlider
            //
            this.bpGrBoxSlider.Controls.Add(this.bpLblCurrentBlockInfo);
            this.bpGrBoxSlider.Controls.Add(this.bpChkEnableSlider);
            this.bpGrBoxSlider.Controls.Add(this.bpBtnNext);
            this.bpGrBoxSlider.Controls.Add(this.bpBtnPrevious);
            this.bpGrBoxSlider.Location = new System.Drawing.Point(12, 501);
            this.bpGrBoxSlider.Name = "bpGrBoxSlider";
            this.bpGrBoxSlider.Size = new System.Drawing.Size(250, 80);
            this.bpGrBoxSlider.TabIndex = 5;
            this.bpGrBoxSlider.TabStop = false;
            this.bpGrBoxSlider.Text = "Przeglądanie brył (slider)";
            //
            // bpLblCurrentBlockInfo
            //
            this.bpLblCurrentBlockInfo.AutoSize = true;
            this.bpLblCurrentBlockInfo.Location = new System.Drawing.Point(98, 29);
            this.bpLblCurrentBlockInfo.Name = "bpLblCurrentBlockInfo";
            this.bpLblCurrentBlockInfo.Size = new System.Drawing.Size(54, 13);
            this.bpLblCurrentBlockInfo.TabIndex = 3;
            this.bpLblCurrentBlockInfo.Text = "Bryła: 0/0";
            //
            // bpChkEnableSlider
            //
            this.bpChkEnableSlider.AutoSize = true;
            this.bpChkEnableSlider.Location = new System.Drawing.Point(62, 54);
            this.bpChkEnableSlider.Name = "bpChkEnableSlider";
            this.bpChkEnableSlider.Size = new System.Drawing.Size(127, 17);
            this.bpChkEnableSlider.TabIndex = 2;
            this.bpChkEnableSlider.Text = "Automatyczny pokaz";
            this.bpChkEnableSlider.UseVisualStyleBackColor = true;
            this.bpChkEnableSlider.CheckedChanged += new System.EventHandler(this.bpChkEnableSlider_CheckedChanged);
            //
            // bpBtnNext
            //
            this.bpBtnNext.Location = new System.Drawing.Point(167, 24);
            this.bpBtnNext.Name = "bpBtnNext";
            this.bpBtnNext.Size = new System.Drawing.Size(75, 23);
            this.bpBtnNext.TabIndex = 1;
            this.bpBtnNext.Text = "Następny";
            this.bpBtnNext.UseVisualStyleBackColor = true;
            this.bpBtnNext.Click += new System.EventHandler(this.bpBtnNext_Click);
            //
            // bpBtnPrevious
            //
            this.bpBtnPrevious.Location = new System.Drawing.Point(9, 24);
            this.bpBtnPrevious.Name = "bpBtnPrevious";
            this.bpBtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.bpBtnPrevious.TabIndex = 0;
            this.bpBtnPrevious.Text = "Poprzedni";
            this.bpBtnPrevious.UseVisualStyleBackColor = true;
            this.bpBtnPrevious.Click += new System.EventHandler(this.bpBtnPrevious_Click);
            //
            // bpBtnDeleteBlock
            //
            this.bpBtnDeleteBlock.Location = new System.Drawing.Point(62, 622);
            this.bpBtnDeleteBlock.Name = "bpBtnDeleteBlock";
            this.bpBtnDeleteBlock.Size = new System.Drawing.Size(130, 23);
            this.bpBtnDeleteBlock.TabIndex = 6;
            this.bpBtnDeleteBlock.Text = "Usuń aktywną bryłę";
            this.bpBtnDeleteBlock.UseVisualStyleBackColor = true;
            this.bpBtnDeleteBlock.Click += new System.EventHandler(this.bpBtnDeleteBlock_Click);
            //
            // bpRotationTimer
            //
            this.bpRotationTimer.Interval = 50;
            this.bpRotationTimer.Tick += new System.EventHandler(this.bpRotationTimer_Tick);
            //
            // bpSliderTimer
            //
            this.bpSliderTimer.Interval = 1000;
            this.bpSliderTimer.Tick += new System.EventHandler(this.bpSliderTimer_Tick);
            //
            // bpLblBlockInfo
            //
            this.bpLblBlockInfo.AutoSize = true;
            this.bpLblBlockInfo.Location = new System.Drawing.Point(12, 590);
            this.bpLblBlockInfo.Name = "bpLblBlockInfo";
            this.bpLblBlockInfo.Size = new System.Drawing.Size(95, 13);
            this.bpLblBlockInfo.TabIndex = 7;
            this.bpLblBlockInfo.Text = "Info o aktywnej bryle";
            //
            // bpTxtBlockInfo
            //
            this.bpTxtBlockInfo.Location = new System.Drawing.Point(113, 587);
            this.bpTxtBlockInfo.Name = "bpTxtBlockInfo";
            this.bpTxtBlockInfo.ReadOnly = true;
            this.bpTxtBlockInfo.Size = new System.Drawing.Size(149, 20);
            this.bpTxtBlockInfo.TabIndex = 8;
            //
            // bpCockpitIndividual
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.bpTxtBlockInfo);
            this.Controls.Add(this.bpLblBlockInfo);
            this.Controls.Add(this.bpBtnDeleteBlock);
            this.Controls.Add(this.bpGrBoxSlider);
            this.Controls.Add(this.bpGrBoxRotation);
            this.Controls.Add(this.bpGrBoxGraphicAttributes);
            this.Controls.Add(this.bpGrBoxGeometricAttributes);
            this.Controls.Add(this.bpGrBoxBlockCreation);
            this.Controls.Add(this.bpPictureBox);
            this.Name = "bpCockpitIndividual";
            this.Text = "Projekt Indywidualny Nr 2 - Bartłomiej Paczesny 72541";
            this.Load += new System.EventHandler(this.bpCockpitIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bpPictureBox)).EndInit();
            this.bpGrBoxBlockCreation.ResumeLayout(false);
            this.bpGrBoxBlockCreation.PerformLayout();
            this.bpGrBoxGeometricAttributes.ResumeLayout(false);
            this.bpGrBoxGeometricAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockSlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpTBarBlockHeight)).EndInit();
            this.bpGrBoxGraphicAttributes.ResumeLayout(false);
            this.bpGrBoxGraphicAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpNumUpDownLineWidth)).EndInit();
            this.bpGrBoxRotation.ResumeLayout(false);
            this.bpGrBoxRotation.PerformLayout();
            this.bpGrBoxSlider.ResumeLayout(false);
            this.bpGrBoxSlider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}