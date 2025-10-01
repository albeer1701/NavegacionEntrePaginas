namespace NavegacionEntrePaginas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pagina1), typeof(Pagina1));
            Routing.RegisterRoute(nameof(PagOpciones), typeof(PagOpciones));
        }
    }
}
