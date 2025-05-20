namespace ProjektNr2Paczesny72541;

partial class bpCockpit
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        bpBtnIndividual = new System.Windows.Forms.Button();
        bpBtnLaboratory = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // bpBtnIndividual
        // 
        bpBtnIndividual.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        bpBtnIndividual.Location = new System.Drawing.Point(75, 273);
        bpBtnIndividual.Name = "bpBtnIndividual";
        bpBtnIndividual.Size = new System.Drawing.Size(263, 68);
        bpBtnIndividual.TabIndex = 0;
        bpBtnIndividual.Text = "Kokpit projektu Indywidualnego";
        bpBtnIndividual.UseVisualStyleBackColor = true;
        bpBtnIndividual.Click += bpBtnIndividual_Click;
        // 
        // bpBtnLaboratory
        // 
        bpBtnLaboratory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        bpBtnLaboratory.Location = new System.Drawing.Point(452, 273);
        bpBtnLaboratory.Name = "bpBtnLaboratory";
        bpBtnLaboratory.Size = new System.Drawing.Size(263, 68);
        bpBtnLaboratory.TabIndex = 1;
        bpBtnLaboratory.Text = "Kokpit projektu Laboratoryjnego";
        bpBtnLaboratory.UseVisualStyleBackColor = true;
        bpBtnLaboratory.Click += bpBtnLaboratory_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(205, 122);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(352, 47);
        label1.TabIndex = 2;
        label1.Text = "Projekt Nr. 2 Bryły Obrotowe";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // bpCockpit
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(bpBtnLaboratory);
        Controls.Add(bpBtnIndividual);
        Text = "Projekt Nr. 2 Paczesny 72541";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button bpBtnLaboratory;

    private System.Windows.Forms.Button bpBtnIndividual;

    #endregion
}