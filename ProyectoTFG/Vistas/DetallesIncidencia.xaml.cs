using ProyectoTFG.Modelos;

namespace ProyectoTFG.Vistas;

public partial class DetallesIncidencia : ContentPage
{
    
    private ListaIncidencias lista;
    private Incidencia inci;
    private Dispositivo disp;
    public DetallesIncidencia(ListaIncidencias miLista)
    {
        InitializeComponent();

        this.lista = miLista;

        CargarEntrys();

    }

    public async void CargarEntrys()
    {
        string id = lista.Idincidencia;

        inci = await App.bdd.ObtenerIncidencia(id);

        disp = await App.bdd.ObtenerDispositivo(inci.IdDispositivo);

        // Convertir los bytes de la imagen a ImageSource
        ImageSource img = ImageSource.FromStream(() => new MemoryStream(inci.ImagenBinaria));

        idEntry.Text = inci.Id;
        fechaEntry.Text = inci.FechaInicio.ToString();
        urgenciaEntry.Text = inci.Urgencia;
        imagenInci.Source = img;
        prioridadEntry.Text = inci.Prioridad;
        tituloEntry.Text = inci.Titulo;
        descripcionEntry.Text = inci.Descripcion;
        tecnicoEntry.Text = inci.EmailTecnico;
        estadoEntry.Text = inci.Estado;
        idDispEntry.Text = inci.IdDispositivo;
        tipoDispEntry.Text = disp.Tipo;
        ubicacionEntry.Text = disp.Ubicacion;
        fechaFinEntry.Text = inci.FechaFin.ToString();
    }

    private async void btnVolver_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}