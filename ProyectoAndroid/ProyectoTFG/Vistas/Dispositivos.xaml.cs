namespace ProyectoTFG.Vistas;

using Microsoft.Maui.Controls;
using ProyectoTFG.Modelos;

public partial class Dispositivos : ContentPage
{
    private List<Fabricante> fabricantes = new List<Fabricante>();
    private List<TipoDispositivo> tipos = new List<TipoDispositivo>();
    private List<Ubicacion> ubicaciones = new List<Ubicacion>();
    public Dispositivos()
    {
        InitializeComponent();

        CargarFabs();
        CargarTipos();
        CargarUbi();
    }

    private async void CargarTipos()
    {
        tipos.Clear();

        // Obtener urgencias desde la base de datos
        tipos = await App.bdd.ObtenerListaTipos();

        // Asignar las urgencias al Picker
        foreach (var tipo in tipos)
        {
            if(tipos.IndexOf(tipo) == 0)
            {
                tipoPicker.Items.Add("Otro...");
                tipoPicker.Items.Add(tipo.TiposDisp);
            }
            else
            {
                tipoPicker.Items.Add(tipo.TiposDisp);
            }
        }
    }
    private async void CargarFabs()
    {
        fabricantes.Clear();

        // Obtener urgencias desde la base de datos
        fabricantes = await App.bdd.ObtenerListaFabs();

        // Asignar las urgencias al Picker
        foreach (var fab in fabricantes)
        {
            if (fabricantes.IndexOf(fab) == 0)
            {
                fabPicker.Items.Add("Otro...");
                fabPicker.Items.Add(fab.NombreFabricante);
            }
            else
            {
                fabPicker.Items.Add(fab.NombreFabricante);
            }
        }
    }
    private async void CargarUbi()
    {
        ubicaciones.Clear();

        // Obtener urgencias desde la base de datos
        ubicaciones = await App.bdd.ObtenerListaUbi();

        // Asignar las urgencias al Picker
        foreach (var ubicacion in ubicaciones)
        {
            if (ubicaciones.IndexOf(ubicacion) == 0)
            {
                ubicacionPicker.Items.Add("Otra...");
                ubicacionPicker.Items.Add(ubicacion.NombreUbicacion);
            }
            else
            {
                ubicacionPicker.Items.Add(ubicacion.NombreUbicacion);
            }
        }
    }
    private async void btnAgregarDispositivo_Clicked(object sender, EventArgs e)
    {
        if( ubicacionPicker.SelectedItem != null &&
            estadoPicker.SelectedItem != null &&
            tipoPicker.SelectedItem != null &&
            fabPicker.SelectedItem != null &&
            modeloEntry.Text != null && modeloEntry.Text != "" &&
            comentariosEditor.Text != null && comentariosEditor.Text != "") 
        {
            Dispositivo nuevoDispositivo = new Dispositivo
            {
                Ubicacion = ubicacionPicker.SelectedItem.ToString(),
                Estado = estadoPicker.SelectedItem.ToString(),
                Tipo = tipoPicker.SelectedItem.ToString(),
                Fabricante = fabPicker.SelectedItem.ToString(),
                Modelo = modeloEntry.Text,
                Comentarios = comentariosEditor.Text
            };

            await App.bdd.InsertarDispositivo(nuevoDispositivo);

            DisplayAlert("", "Dispositivo insertado correctamente", "OK");
        }
        else
        {
            DisplayAlert("", "Debes rellenar todos los campos", "Ok");
        }

    }

    private async void guardarTipo_Clicked(object sender, EventArgs e)
    {
        tipoPicker.SelectedIndexChanged -= tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged -= fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged -= ubicacionPicker_SelectedIndexChanged;

        tipos.Clear();

        tipoPicker.Items.Clear();

        try
        {
            if (tipoEntry.Text != null && tipoEntry.Text != "" && await App.bdd.ExisteTipo(tipoEntry.Text.ToLower()) == false)
            {
                TipoDispositivo nuevoTipo = new TipoDispositivo
                {
                    TiposDisp = tipoEntry.Text.ToLower(),
                };

                await App.bdd.InsertarTipo(nuevoTipo);
                DisplayAlert("", "Insertado", "ok");
            }
            else
            {
                DisplayAlert("", "El tipo ya existe o está vacio", "ok");
            }
        }
        catch (Exception ex) 
        {

            DisplayAlert("", "El tipo introducido ya existe", "ok");
        
        }

        CargarTipos();

        tipoEntry.Text = null;

        tipoPicker.SelectedIndexChanged += tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged += fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged += ubicacionPicker_SelectedIndexChanged;
    }

    private async void guardarFab_Clicked(object sender, EventArgs e)
    {
        tipoPicker.SelectedIndexChanged -= tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged -= fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged -= ubicacionPicker_SelectedIndexChanged;

        fabricantes.Clear();

        fabPicker.Items.Clear();

        try
        {
            if (fabricanteEntry.Text != null && fabricanteEntry.Text != "" && await App.bdd.ExisteFab(fabricanteEntry.Text.ToLower()) == false)
            {
                Fabricante nuevoFab = new Fabricante
                {
                    NombreFabricante = fabricanteEntry.Text.ToLower(),
                };
                await App.bdd.InsertarFab(nuevoFab);
                DisplayAlert("", "Insertado", "ok");
            }
            else
            {
                DisplayAlert("", "El fabricante ya existe o está vacio", "ok");
            }
        }
        catch (Exception ex)
        {

            DisplayAlert("", "El fabricante introducido ya existe", "ok");

        }

        CargarFabs();

        fabricanteEntry.Text = null;

        tipoPicker.SelectedIndexChanged += tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged += fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged += ubicacionPicker_SelectedIndexChanged;

    }

    private async void guardarUbicacion_Clicked(object sender, EventArgs e)
    {
        tipoPicker.SelectedIndexChanged -= tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged -= fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged -= ubicacionPicker_SelectedIndexChanged;

        ubicaciones.Clear();

        ubicacionPicker.Items.Clear();

        try
        {
            if (ubicacionEntry.Text != null && ubicacionEntry.Text != "" && await App.bdd.ExisteUbi(ubicacionEntry.Text.ToUpper()) == false)
            {
                Ubicacion nuevaUbicacion = new Ubicacion
                {
                    NombreUbicacion = ubicacionEntry.Text.ToUpper(),
                };

                await App.bdd.InsertarUbi(nuevaUbicacion);
                DisplayAlert("", "Insertado", "ok");
            }
            else
            {
                DisplayAlert("", "La ubicación ya existe o está vacio", "ok");
            }
        }
        catch (Exception ex)
        {

            DisplayAlert("", "La ubicación introducida ya existe", "ok");

        }

        CargarUbi();

        ubicacionEntry.Text = null;

        tipoPicker.SelectedIndexChanged += tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged += fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged += ubicacionPicker_SelectedIndexChanged;

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LimpiarEntrys();
    }
    public void LimpiarEntrys()
    {
        tipoPicker.SelectedIndexChanged -= tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged -= fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged -= ubicacionPicker_SelectedIndexChanged;
        ubicacionEntry.Text = null;
        ubicacionPicker.SelectedItem = null;
        estadoPicker.SelectedItem = null;
        tipoEntry.Text = null;
        tipoPicker.SelectedItem = null;
        fabPicker.SelectedItem = null;
        fabricanteEntry.Text = null;
        modeloEntry.Text = null;
        comentariosEditor.Text = null;
        tipoEntry.IsVisible = false;
        guardarTipo.IsVisible = false;
        fabricanteEntry.IsVisible = false;
        guardarFab.IsVisible = false;
        ubicacionEntry.IsVisible = false;
        guardarUbicacion.IsVisible = false;
        tipoPicker.SelectedIndexChanged += tipoPicker_SelectedIndexChanged;
        fabPicker.SelectedIndexChanged += fabPicker_SelectedIndexChanged;
        ubicacionPicker.SelectedIndexChanged += ubicacionPicker_SelectedIndexChanged;
    }

    private void tipoPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tipoPicker.SelectedItem.ToString() == "Otro..." && tipoPicker.SelectedItem != null)
        {
            tipoEntry.IsVisible = true;
            guardarTipo.IsVisible = true;
        }
        else
        {
            tipoEntry.IsVisible = false;
            guardarTipo.IsVisible = false;
        }
    }

    private void fabPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (fabPicker.SelectedItem.ToString() == "Otro..." && fabPicker.SelectedItem != null)
        {
            fabricanteEntry.IsVisible = true;
            guardarFab.IsVisible = true;
        }
        else
        {
            fabricanteEntry.IsVisible = false;
            guardarFab.IsVisible = false;
        }
    }

    private void ubicacionPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ubicacionPicker.SelectedItem.ToString() == "Otra..." && ubicacionPicker.SelectedItem != null)
        {
            ubicacionEntry.IsVisible = true;
            guardarUbicacion.IsVisible = true;
        }
        else
        {
            ubicacionEntry.IsVisible = false;
            guardarUbicacion.IsVisible = false;
        }
    }
}