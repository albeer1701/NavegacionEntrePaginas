﻿namespace NavegacionEntrePaginas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpcionesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagOpciones());
        }

        private async void OnCargarPartidaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina1());
        }
    }

}
