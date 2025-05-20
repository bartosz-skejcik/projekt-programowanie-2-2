namespace ProjektNr2Paczesny72541;

public partial class bpCockpitLaboratory : Form
{
    public bpCockpitLaboratory()
    {
        InitializeComponent();
    }

    private void bpCockpitLaboratory_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Show confirmation dialog
        DialogResult result = MessageBox.Show(
            "Czy na pewno chcesz zamknąć formularz projektu laboratoryjnego?", 
            "Potwierdzenie zamknięcia",
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            // User confirmed - create and show the main cockpit form
            bpCockpit cockpitForm = new bpCockpit();
            cockpitForm.Show();
            // Don't cancel closing - let this form close
        }
        else
        {
            // User declined - cancel the close operation
            e.Cancel = true;
        }
    }
}
