namespace ProyectoTFG

{

    using ProyectoTFG.BBDD;
    using ProyectoTFG.Modelos;
    using ProyectoTFG.Vistas;

    public partial class App : Application
    {

        public static MongoDB bdd;
        public static Page PaginaActual { get; set; }

        public App()
        {
            InitializeComponent();

            bdd = new MongoDB();

            MainPage = new AppShell();
        }

        public async void OnAppClosing()
        {
            // Encuentra la página ListaIncidencias para ejecutar el método
            if (MainPage is NavigationPage navigationPage && navigationPage.CurrentPage is ListaIncidencias listaIncidenciasPage)
            {
                await listaIncidenciasPage.OnAppClosing();
            }
        }
    }
}
