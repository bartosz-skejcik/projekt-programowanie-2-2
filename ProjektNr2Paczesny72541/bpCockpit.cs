namespace ProjektNr2Paczesny72541;

public partial class bpCockpit : Form
{
    public bpCockpit()
    {
        InitializeComponent();
        LayoutControls();
        this.Resize += BpCockpit_Resize;
    }

    private void BpCockpit_Resize(object sender, EventArgs e)
    {
        LayoutControls();
    }

    private void LayoutControls()
    {
        // Wyśrodkuj etykietę w poziomie
        label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        label1.Top = this.ClientSize.Height * 1 / 4;  // Pozycja na 1/4 wysokości formularza

        // Oblicz odstępy dla przycisków (układ typu space-around)
        int totalButtonWidth = bpBtnIndividual.Width + bpBtnLaboratory.Width;
        int availableSpace = this.ClientSize.Width - totalButtonWidth;
        int spacing = availableSpace / 3;  // Podziel przez 3 dla efektu space-around
        
        // Pozycjonuj pierwszy przycisk
        bpBtnIndividual.Left = spacing;
        bpBtnIndividual.Top = this.ClientSize.Height * 2 / 3;  // Pozycja na 2/3 wysokości formularza
        
        // Pozycjonuj drugi przycisk
        bpBtnLaboratory.Left = spacing * 2 + bpBtnIndividual.Width;
        bpBtnLaboratory.Top = bpBtnIndividual.Top;  // Wyrównaj z pierwszym przyciskiem
    }

    private void bpBtnIndividual_Click(object sender, EventArgs e)
    {
        // TODO: Implementacja logiki dla przycisku "Kokpit projektu Indywidualnego"
    }

    private void bpBtnLaboratory_Click(object sender, EventArgs e)
    {
        // Create and show the laboratory cockpit form
        bpCockpitLaboratory laboratoryForm = new bpCockpitLaboratory();
        laboratoryForm.Show();
        // Hide this form to prevent multiple instances
        this.Hide();
    }
}
