using ProyectoTFG.Vistas;

namespace ProyectoTFG
{
    public partial class AppShell : Shell
    {

        public static Login login;
        public static Configuracion confi;
        public static ListaIncidencias listaIncidencias;
        public static DetallesIncidencia detalles;
        public AppShell()
        {
            InitializeComponent();

            adminContent.Content = new Administacion();
            adminContent.Title = "Administración";

            confi = new Configuracion(this);
            contentConfi.Content = confi;
            contentConfi.Title = "Configuración";

            login = new Login(this, confi);
            loginPage.Content = login;
            loginPage.Title = "LogIn";

            listaIncidencias = new ListaIncidencias();
            contentTabla.Content = listaIncidencias;
            contentTabla.Title = "Tabla incidencias";

            // Crea un hilo dedicado para ejecutar el temporizador
            Thread reloj = new Thread(() =>
            {
                // Crea un temporizador que se ejecuta cada segundo
                var timer = new System.Timers.Timer(1000);
                timer.Elapsed += Timer_Elapsed;
                timer.Start();

                // Mantener el hilo vivo
                while (true)
                {
                    Thread.Sleep(1000);
                }
            });

            reloj.IsBackground = true;
            reloj.Start();
        }
       
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Actualiza la hora en la interfaz de usuario en el subproceso principal
            Device.BeginInvokeOnMainThread(() =>
            {
                hora.Text = DateTime.Now.ToString("HH:mm:ss");
                fecha.Text = DateTime.Now.ToString("dddd d MMMM/yyyy");
            });

        }

        public async void CargarLblUser()
        {
            string email = Modelos.UserLogueado.UserLog;
            int atIndex = email.IndexOf('@');

            lblFrame.Text = "@" + email.Substring(0, atIndex);

            byte[] imagen = await App.bdd.ObtenerImagenPerfil(Modelos.UserLogueado.UserLog);

            ImageSource img = ImageSource.FromStream(() => new MemoryStream(imagen));

            imgFrame.Source = img;
        }

        public async void AplicacionSiConectado()
        {
            string rol = await App.bdd.ObtenerRolUsuario(Modelos.UserLogueado.UserLog);

            string email = Modelos.UserLogueado.UserLog;
            int atIndex = email.IndexOf('@');
            string nombre = "@" + email.Substring(0, atIndex);


            DisplayAlert("", "Bienvenido " + nombre + "\n" + rol, "ok");

            shell.FlyoutBehavior = FlyoutBehavior.Flyout;

            if (rol == "Admin")
            {
                CargarLblUser();

                adminContent.IsVisible = true;

                login.IsVisible = false;

                contentConfi.IsVisible = true;

                contentIncidencias.IsVisible = true;

                contentDispositivos.IsVisible = true;

                contentTabla.IsVisible = true;

                miMenuItem.Clicked += MiMenu_Clicked;
            }

            if (rol == "Docente")
            {
                CargarLblUser();

                login.IsVisible = false;

                adminContent.IsVisible = false;

                contentConfi.IsVisible = true;

                contentIncidencias.IsVisible = true;

                contentDispositivos.IsVisible = true;

                contentTabla.IsVisible = false;

                miMenuItem.Clicked += MiMenu_Clicked;

            }

            if (rol == "Técnico")
            {
                CargarLblUser();

                login.IsVisible = false;

                adminContent.IsVisible = false;

                contentConfi.IsVisible = true;

                contentIncidencias.IsVisible = false;

                contentDispositivos.IsVisible = false;

                contentTabla.IsVisible = true;

                miMenuItem.Clicked += MiMenu_Clicked;
            }

        }
        public void AplicacionNoConectado()
        {
            shell.FlyoutBehavior = FlyoutBehavior.Disabled;

            login.IsVisible = true;

            adminContent.IsVisible = false;

            contentTabla.IsVisible = false;

            contentDispositivos.IsVisible = false;

            contentIncidencias.IsVisible = false;
        }

        private async void MiMenu_Clicked(object? sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ConfirmarSalir());
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PushModalAsync(new PerfilUser(this));
        }
    }
}
