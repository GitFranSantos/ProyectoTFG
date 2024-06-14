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
        byte[] imagen = await App.bdd.ObtenerImagenPerfil(Modelos.UserLogueado.UserLog);

        ImageSource img = ImageSource.FromStream(() => new MemoryStream(imagen));

        imagenPerfil.Source = img;
    }

    private async void btnBuscar_Clicked(object sender, EventArgs e)
    {
        imagenPerfil.Source = "https://media.giphy.com/media/WiIuC6fAOoXD2/giphy.gif?cid=ecf05e47vni4a9wssv6ak4x463ulu3w9qtjto9fqd8bvtsqa&ep=v1_gifs_related&rid=giphy.gif&ct=g";

        // Ejecuta el c�digo de selecci�n y procesamiento en un hilo aparte
        await Task.Run(async () =>
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images
            });

            if (result != null)
            {
                using (var stream = await result.OpenReadAsync())
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        var imagenBytes = memoryStream.ToArray();

                        // Asigna temporalmente la imagen seleccionada al control de imagen
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            imagenPerfil.Source = ImageSource.FromStream(() => new MemoryStream(imagenBytes));
                        });

                        await App.bdd.GuardarImagen(UserLogueado.UserLog, imagenBytes);
                    }
                }
            }
        });

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
        string nuevaContrase�a = passEntry.Text;

        // Verificar que el email y la nueva contrase�a no sean nulos o vac�os
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nuevaContrase�a))
        {
            await DisplayAlert("Error", "Por favor, ingrese un email y una nueva contrase�a v�lidos.", "OK");
            return;
        }

        bool resultado = await App.bdd.ActualizarContrase�aUsuario(email, nuevaContrase�a);

        if (resultado)
        {
            await DisplayAlert("�xito", "Contrase�a actualizada correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Error", "No se pudo actualizar la contrase�a. Verifique el correo electr�nico.", "OK");
        }
    }
}