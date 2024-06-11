using ProyectoTFG.Modelos;

namespace ProyectoTFG.Vistas;

public partial class PerfilUser : ContentPage
{
    private readonly AppShell shell;

    public PerfilUser(AppShell appShell)
    {
        InitializeComponent();

        shell = appShell;

        CargarImagenUser();

        CargarEntrys();
    }

    public async void CargarImagenUser()
    {
        imagenPerfil.Source = await App.bdd.ObtenerImagen(UserLogueado.UserLog);
    }

    private async void btnBuscar_Clicked(object sender, EventArgs e)
    {
        imagenPerfil.Source = "https://media.giphy.com/media/WiIuC6fAOoXD2/giphy.gif?cid=ecf05e47vni4a9wssv6ak4x463ulu3w9qtjto9fqd8bvtsqa&ep=v1_gifs_related&rid=giphy.gif&ct=g";

        // Ejecuta el código de selección y procesamiento en un hilo aparte
        await Task.Run(async () =>
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                var filePath = result.FullPath; // Obtener la ruta completa de la imagen

                // Guardar la URL de la imagen en la base de datos
                await GuardarUrl(filePath);
            }

            // Después de un retraso de 2 segundos, actualizar la interfaz de usuario debe hacerse en el hilo principal
            await Task.Delay(2500);

            // se ejecute en el hilo principal
            Device.BeginInvokeOnMainThread(() =>
            {
                CargarImagenUser();
            });
        });

    }

    private async Task GuardarUrl(string imagenUrl)
    {
        await App.bdd.GuardarImagen(UserLogueado.UserLog, imagenUrl);
    }

    private async void btnVolver_Clicked(object sender, EventArgs e)
    {
        shell.CargarLblUser();

        await Navigation.PopModalAsync();
    }

    public async void CargarEntrys()
    {
        emailEntry.Text = UserLogueado.UserLog;
    }

    private async void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string email = UserLogueado.UserLog;
        string nuevaContraseña = passEntry.Text;

        // Verificar que el email y la nueva contraseña no sean nulos o vacíos
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nuevaContraseña))
        {
            await DisplayAlert("Error", "Por favor, ingrese un email y una nueva contraseña válidos.", "OK");
            return;
        }

        bool resultado = await App.bdd.ActualizarContraseñaUsuario(email, nuevaContraseña);

        if (resultado)
        {
            await DisplayAlert("Éxito", "Contraseña actualizada correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Error", "No se pudo actualizar la contraseña. Verifique el correo electrónico.", "OK");
        }

    }

}