namespace ProyectoTFG.Vistas;

using ProyectoTFG.Modelos;

public partial class Incidencias : ContentPage
{
    private List<Dispositivo> dispositivos = new List<Dispositivo>();
    private Dispositivo dispositivo = new Dispositivo();
    private Incidencia nuevaIncidencia;
    private NuevaIncidencia nueva;
    private byte[] imagenBytesTemp;


    public Incidencias()
    {
        InitializeComponent();

        CargarDispositivos();
    }

    private async void btnAgregarIncidencia_Clicked(object sender, EventArgs e)
    {
        dispositivo = (Dispositivo)listViewDispositivos.SelectedItem;

        if (urgenciaPicker.SelectedItem != null &&
            prioridadPicker.SelectedItem != null &&
            dispositivo != null && imagenBytesTemp != null)
        {
            nuevaIncidencia = new Incidencia
            {
                FechaInicio = DateTime.UtcNow,
                Urgencia = urgenciaPicker.SelectedItem.ToString(),
                Prioridad = prioridadPicker.SelectedItem.ToString(),
                Titulo = tituloEntry.Text,
                Descripcion = descripcionEditor.Text,
                IdDispositivo = dispositivo.Id,
                EmailTecnico = "",
                TipoDispositivo = dispositivo.Tipo,
                ImagenBinaria = imagenBytesTemp, // Asignar la imagen binaria aqu�
                Estado = "Sin resolver"
            };

            await App.bdd.InsertarIncidencia(nuevaIncidencia);

            DisplayAlert("", "Incidencia agregada", "Ok");
            LimpiarEntrys();

            // Limpiar la imagen temporal despu�s de guardar
            imagenBytesTemp = null;
        }
        else
        {
            DisplayAlert("", "Debes rellenar todos los campos", "Ok");
        }

    }
    public async void CargarDispositivos()
    {
        dispositivos.Clear();

        listViewDispositivos.ItemsSource = null;

        // Obtener urgencias desde la base de datos
        dispositivos = await App.bdd.ObtenerListaDispositivos();

        listViewDispositivos.ItemsSource = dispositivos;

    }

    public void LimpiarEntrys()
    {
        tituloEntry.Text = null;
        descripcionEditor.Text = null;
        urgenciaPicker.SelectedItem = null;
        prioridadPicker.SelectedItem = null;
        imagenInci.Source = null;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        CargarDispositivos();
        LimpiarEntrys();
    }

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        LimpiarEntrys();
    }
    private async void btnBuscar_Clicked(object sender, EventArgs e)
    {
        imagenInci.Source = "https://media.giphy.com/media/WiIuC6fAOoXD2/giphy.gif?cid=ecf05e47vni4a9wssv6ak4x463ulu3w9qtjto9fqd8bvtsqa&ep=v1_gifs_related&rid=giphy.gif&ct=g";

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
                        imagenBytesTemp = memoryStream.ToArray();

                        // Asigna temporalmente la imagen seleccionada al control de imagen
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            imagenInci.Source = ImageSource.FromStream(() => new MemoryStream(imagenBytesTemp));
                        });
                    }
                }
            }
        });
    }
}