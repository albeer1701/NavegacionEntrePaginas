namespace NavegacionEntrePaginas;

public partial class PagOpciones : ContentPage
{
	public PagOpciones()
	{
		InitializeComponent();
	}

    private async void OnOpcionesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagOpciones());}
}