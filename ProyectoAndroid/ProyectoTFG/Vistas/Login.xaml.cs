namespace ProyectoTFG.Vistas;

public partial class Login : ContentPage
{
    private AppShell appShellOriginal;
    private Configuracion miConfi;

    public Login()
    {

    }
    public Login(AppShell shell, Configuracion configuracion)
    {
        InitializeComponent();

        this.appShellOriginal = shell;

        this.miConfi = configuracion;

    }

    private void btnOcultar_Clicked(object sender, EventArgs e)
    {
        if (passEntry.IsPassword == true)
        {
            passEntry.IsPassword = false;

            btnOcultar.Source = "ojocerrado.png";
        }
        else
        {
            passEntry.IsPassword = true;

            btnOcultar.Source = "ojoabierto.png";
        }

    }

    private async void btnAceptar_Clicked(object sender, EventArgs e)
    {
        bool comprobarPass = await App.bdd.ComprobarPassUsuario(emailEntry.Text, passEntry.Text);

        Modelos.UserLogueado.UserLog = emailEntry.Text;

        if (comprobarPass == true && emailEntry.Text != null && passEntry.Text != null)
        {
            appShellOriginal.AplicacionSiConectado();

            miConfi.InicializarConfiguracion(emailEntry.Text);

        }
        else
        {
            DisplayAlert("", "Error con el usuario o contraseña", "cancelar");
        }

    }
}