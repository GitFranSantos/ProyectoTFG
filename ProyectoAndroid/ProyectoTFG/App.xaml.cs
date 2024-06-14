namespace ProyectoTFG

{

    using ProyectoTFG.BBDD;
    using ProyectoTFG.Modelos;
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
    }
}
