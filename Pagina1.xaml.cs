namespace NavegacionEntrePaginas;

public partial class Pagina1 : ContentPage
{
    int count = 0;
    public Pagina1()
	{
		InitializeComponent();
	}
    private async void OnSalirClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // ← volver atrás
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Juega {count} partida";
        else
            CounterBtn.Text = $"Juega {count} partidas";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}