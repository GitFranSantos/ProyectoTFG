using ProyectoTFG.Modelos;
using ProyectoTFG.BBDD;
using System.Runtime.CompilerServices;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using System.Reflection;

namespace ProyectoTFG.Vistas;

public partial class Administacion : ContentPage
{
    private List<Usuario> listaUsers;
    private List<Usuario> usuariosFiltrados;
    public Administacion()
	{
		InitializeComponent();

        CargarListView();
    }

    private async void btnGuardar_Clicked(object sender, EventArgs e)
    {
        ActualizarListView();

        try
        {
            bool emailValido = await App.bdd.EmailValido(emailEntry.Text);
            bool existeEmail = await App.bdd.ExisteEmail(emailEntry.Text);
            var imagenPorDefecto = CargarImagenPorDefecto();

            if (emailValido && !existeEmail && rolPicker.SelectedItem != null && passwordEntry.Text != null)
            {
                Usuario nuevoUsuario = new Usuario
                {
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text,
                    Rol = rolPicker.SelectedItem.ToString(),
                    Tema = "",
                    TamFuente = 15,
                    FilasAntes = 0,
                    FilasActuales = 0,
                    IdsActuales = new List<string>(),
                    IdsAntes = new List<string>(),
                    ImagenPerfil = imagenPorDefecto
                };

                await App.bdd.InsertarUsuario(nuevoUsuario);

                DisplayAlert("", "Insertado con éxito", "ok");
            }
            else
            {
                DisplayAlert("", "Rellena todos los campos", "ok");
            }
        }
        catch
        {
            DisplayAlert("", "El email ya existe o no es valido", "ok");
        }


        CargarListView();

        LimpiarEntrys();
    }

    // Método para cargar la imagen desde los recursos y convertirla a byte[]
    private byte[] CargarImagenPorDefecto()
    {
        var assembly = typeof(App).GetTypeInfo().Assembly;
        var resourceName = "ProyectoTFG.Resources.Images.dotnet_bot.png";

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                // Manejar el caso donde el recurso no se encontró
                DisplayAlert("", $"No se encontró el recurso: {resourceName}", "ok");
                return null;
            }
        }
    }

    private async void btnBorrar_Clicked(object sender, EventArgs e)
    {
        ActualizarListView();

        // Obtener el usuario seleccionado del ListView
        if (listViewUsuarios.SelectedItem != null)
        {

            // Obtener el correo electrónico del usuario seleccionado
            Usuario email = (Usuario)listViewUsuarios.SelectedItem;


            // Eliminar el usuario de la base de datos
            bool eliminado = await App.bdd.EliminarUsuario(email.Email);

            if (eliminado)
            {
                // Usuario eliminado correctamente
                DisplayAlert("", $"Usuario con correo {email.Email} eliminado exitosamente.", "ok");
            }
            else
            {
                // No se encontró ningún usuario con el correo electrónico proporcionado
                DisplayAlert("", "No se encontró ningún usuario con el correo electrónico proporcionado", "ok");
            }
        }
        else
        {
            // No se ha seleccionado ningún usuario
            DisplayAlert("", "No se ha seleccionado ningún usuario para eliminar.", "ok");
        }

        CargarListView();
    }

    public void ActualizarListView()
    {
        listaUsers.Clear();
        listViewUsuarios.ItemsSource = null;
    }

    public async void CargarListView()
    {
        listaUsers = new List<Usuario>();

        listaUsers = await App.bdd.ObtenerListaUsuarios();

        listViewUsuarios.ItemsSource = listaUsers;
    }


    private async void btnGuardarCambios_Clicked(object sender, EventArgs e)
    {
        ActualizarListView();

        string email = entryEmailEdit.Text;
        string nuevaContraseña = entryNuevaPass.Text;

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

        entryNuevaPass.Text = null;

        CargarListView();
    }

    private void listViewUsuarios_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Usuario usuario = listViewUsuarios.SelectedItem as Usuario;

        entryEmailEdit.Text = usuario.Email;
        entryPassEdit.Text = usuario.Password;
    }

    public void LimpiarEntrys()
    {
        emailEntry.Text = null;
        passwordEntry.Text = null;
        rolPicker.SelectedItem = null;
        entryNuevaPass.Text = null;
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        listViewUsuarios.SelectedItem = null;

        entryEmailEdit.Text = null;

        entryPassEdit.Text = null;

        LimpiarEntrys();

    }

    private async void entryBuscar_TextChanged(object sender, TextChangedEventArgs e)
    {
        string textoBusqueda = entryBuscar.Text;

        if (string.IsNullOrEmpty(textoBusqueda))
        {
            usuariosFiltrados = listaUsers;
        }
        else
        {
            var usuariosFiltradosLista = await App.bdd.ObtenerUsuariosFiltrados(textoBusqueda);
            usuariosFiltrados = new List<Usuario>(usuariosFiltradosLista);
        }

        listViewUsuarios.ItemsSource = usuariosFiltrados;
    }
}