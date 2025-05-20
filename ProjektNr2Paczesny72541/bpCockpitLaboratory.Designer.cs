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
        bpTBarBlockAngle.Name = "bpTBarBlockAngle";
        bpTBarBlockAngle.Size = new System.Drawing.Size(116, 45);
        bpTBarBlockAngle.TabIndex = 11;
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
        bpGrBoxGraphicAttrs.Size = new System.Drawing.Size(185, 167);
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
        bpPictureBox.Location = new System.Drawing.Point(199, 14);
        bpPictureBox.Name = "bpPictureBox";
        bpPictureBox.Size = new System.Drawing.Size(726, 466);
        bpPictureBox.TabIndex = 2;
        bpPictureBox.TabStop = false;
        // 
        // bpBtnAddSelectedBlock
        // 
        bpBtnAddSelectedBlock.Location = new System.Drawing.Point(199, 486);
        bpBtnAddSelectedBlock.Name = "bpBtnAddSelectedBlock";
        bpBtnAddSelectedBlock.Size = new System.Drawing.Size(166, 57);
        bpBtnAddSelectedBlock.TabIndex = 3;
        bpBtnAddSelectedBlock.Text = "Dodaj wybraną bryłę";
        bpBtnAddSelectedBlock.UseVisualStyleBackColor = true;
        // 
        // bpGrBoxBlockVisibilityCriteria
        // 
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockSurfaceArea);
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockVolume);
        bpGrBoxBlockVisibilityCriteria.Controls.Add(bpRBtnBlockHeight);
        bpGrBoxBlockVisibilityCriteria.Location = new System.Drawing.Point(371, 486);
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
        bpGrBoxBlockOrdering.Location = new System.Drawing.Point(743, 486);
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
        // bpCockpitLaboratory
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(935, 550);
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
        ResumeLayout(false);
    }

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