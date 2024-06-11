namespace ProyectoTFG

{

    using ProyectoTFG.BBDD;
    using ProyectoTFG.Modelos;

    public partial class App : Application
    {

        public static MongoDB bdd;
        public static NuevaIncidencia nueva;

        public App()
        {
            InitializeComponent();

            bdd = new MongoDB();

            nueva = new NuevaIncidencia();

            MainPage = new AppShell();

        }
    }
}
