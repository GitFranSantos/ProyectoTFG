using Microsoft.Maui.Controls;
using ProyectoTFG.Modelos;

namespace ProyectoTFG.Vistas;

public partial class ListaIncidencias : ContentPage
{
    private List<Incidencia> incidencias = new List<Incidencia>();
    private List<Incidencia> incidenciasDesc;
    private List<Incidencia> incidenciasAux = new List<Incidencia>();
    private Grid filaSeleccionada;
    private Incidencia inci;
    private IncidenciasResueltas inciResuelta;
    Thread hilo;
    public string EstadoActual { get; set; }
    private bool pulsadoFecha = true;
    private bool pulsadoPrio = true;
    private bool pulsadoUrgen = true;
    private bool pulsadoEstado = true;

    private bool MensajeMostrado = false;

    private List<string> IdsAntes = new List<string>();
    private List<string> IdsActuales = new List<string>();

    private List<string> NuevosIds;

    public string Idincidencia { get; set; }

    public ListaIncidencias()
    {
        InitializeComponent();

        App.PaginaActual = this;
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        hilo = new Thread(async () =>
        {
            while (true)
            {
                if (App.PaginaActual is ListaIncidencias)
                {
                    // Obtener la lista de incidencias actualizada
                    incidenciasAux = await App.bdd.ObtenerListaIncidencias();
                    incidenciasAux = await App.bdd.OrdenarFechaDesc(incidencias);
                    // Actualizar ids actuales
                    IdsActuales = incidenciasAux.Select(x => x.Id).ToList();
                    await App.bdd.ActualizarIdsIncidenciasActuales(UserLogueado.UserLog, IdsActuales);

                    // Obtener ids antes
                    IdsAntes = await App.bdd.ObtenerIdsIncidenciasAntes(UserLogueado.UserLog);

                    // Actualizar ids actuales
                    NuevosIds = incidenciasAux.Select(x => x.Id).ToList();

                    // Comparar idsAntes con nuevosIdsActuales
                    if (SonIguales(IdsAntes, NuevosIds) == false)
                    {
                        // Lista auxiliar para nuevos IDs
                        NuevosIds = NuevosIds.Except(IdsAntes).ToList();

                        if (NuevosIds.Count > 0 && MensajeMostrado == false)
                        {
                            MensajeMostrado = true;
                            Device.BeginInvokeOnMainThread(async () =>
                            {
                                if (NuevosIds.Count == 1)
                                {
                                    await DisplayAlert("", $"Tienes {NuevosIds.Count} incidencia nueva", "ok");
                                    await TextToSpeech.SpeakAsync($"{NuevosIds.Count} nueva incidencia");
                                }
                                else
                                {
                                    await DisplayAlert("", $"Tienes {NuevosIds.Count} incidencias nuevas", "ok");
                                    await TextToSpeech.SpeakAsync($"{NuevosIds.Count} nuevas incidencias");
                                }
                            });

                            // Actualizar la lista de incidencias mostrada en la UI
                            Dispatcher.Dispatch(() =>
                            {
                                collectionView.ItemsSource = incidenciasAux;
                            });
                        }
                    }

                }
                await Task.Delay(500);
            }
        });

        hilo.Start();
    }
    // Función para comparar dos listas de strings y determinar si son iguales
    bool SonIguales(List<string> lista1, List<string> lista2)
    {
        return new HashSet<string>(lista1).SetEquals(lista2);
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        App.PaginaActual = this;

        // Aquí cargamos las incidencias desde la base de datos
        incidencias = await ObtenerIncidenciasDesdeBDD();

        incidencias = await App.bdd.OrdenarFechaDesc(incidencias);

        IdsActuales = incidencias.Select(x => x.Id).ToList();

        collectionView.ItemsSource = incidencias;
    }
    protected override async void OnDisappearing()
    {
        base.OnDisappearing();
        App.PaginaActual = null;

        MensajeMostrado = false;

        await App.bdd.ActualizarIdsIncidenciasAntes(UserLogueado.UserLog, IdsActuales);

    }

    public async Task OnAppClosing()
    {

        MensajeMostrado = false;

        await App.bdd.ActualizarIdsIncidenciasAntes(UserLogueado.UserLog, IdsActuales);

    }

    private async Task<List<Incidencia>> ObtenerIncidenciasDesdeBDD()
    {
        incidencias = await App.bdd.ObtenerListaIncidencias();
        return incidencias;
    }

    private async void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = (RadioButton)sender;

        if (e.Value)
        {
            // Obtener la fila seleccionada
            var layout = (Grid)radioButton.Parent;

            SeleccionarFila(layout);
        }
        else if (filaSeleccionada == radioButton.Parent)
        {
            DeseleccionarFila();
        }
    }
    private async void SeleccionarFila(Grid grid)
    {
        if (filaSeleccionada != null)
        {
            DeseleccionarFila();
        }
        // Establecer el nuevo color de fondo para la fila seleccionada
        grid.BackgroundColor = (Color)Application.Current.Resources["colorBotones"];

        // Mostrar todos los botones en la fila seleccionada
        foreach (var child in grid.Children)
        {
            if (child is Picker picker)
            {
                picker.IsEnabled = true;
            }
            if (child is HorizontalStackLayout horizontalStackLayout)
            {
                foreach (var stackChild in horizontalStackLayout.Children)
                {
                    if (stackChild is ImageButton boton)
                    {
                        boton.IsEnabled = true;
                    }
                }
            }

        }

        // Actualizar la referencia al elemento seleccionado
        filaSeleccionada = grid;

        // Obtener el objeto vinculado a la fila seleccionada
        inci = (Incidencia)grid.BindingContext;

        Idincidencia = inci.Id.ToString();
    }

    private void DeseleccionarFila()
    {
        if (filaSeleccionada == null) return;

        // Restablecer el color de fondo del elemento previamente seleccionado
        filaSeleccionada.BackgroundColor = (Color)Application.Current.Resources["colorTemaOriginal"];

        // Ocultar todos los botones en la fila previamente seleccionada
        foreach (var child in filaSeleccionada.Children)
        {
            if (child is RadioButton radioButton)
            {
                radioButton.IsChecked = false;
            }

            if (child is HorizontalStackLayout horizontalStackLayout)
            {
                foreach (var stackChild in horizontalStackLayout.Children)
                {
                    if (stackChild is ImageButton boton)
                    {
                        boton.IsEnabled = false;
                    }
                }
            }

            if (child is Picker picker)
            {
                picker.IsEnabled = false;
            }
        }

        filaSeleccionada = null;
    }

    private async void btnInfo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new DetallesIncidencia(this));
    }

    private async void btnBorrar_Clicked(object sender, EventArgs e)
    {
        inciResuelta = new IncidenciasResueltas
        {
            FechaInicio = inci.FechaInicio,
            FechaFin = inci.FechaFin,
            Urgencia = inci.Urgencia,
            Prioridad = inci.Prioridad,
            Titulo = inci.Titulo,
            Descripcion = inci.Descripcion,
            IdDispositivo = inci.IdDispositivo,
            EmailTecnico = inci.EmailTecnico,
            TipoDispositivo = inci.TipoDispositivo,
            ImagenBinaria = inci.ImagenBinaria, // Asignar la imagen binaria aquí
            Estado = inci.Estado
        };

        // Guardar la incidencia en la base de datos
        await App.bdd.InsertarIncidenciaResuelta(inciResuelta);

        await App.bdd.EliminarIncidencia(Idincidencia);

        incidencias.Clear();

        incidencias = await App.bdd.ObtenerListaIncidencias();

        incidencias = await App.bdd.OrdenarFechaDesc(incidencias);

        collectionView.ItemsSource = incidencias;

        IdsActuales = incidencias.Select(x => x.Id).ToList();

        await App.bdd.ActualizarIdsIncidenciasActuales(UserLogueado.UserLog, IdsActuales);

        await App.bdd.ActualizarIdsIncidenciasAntes(UserLogueado.UserLog, IdsActuales);
    }

    private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (sender is Picker picker)
        {
            var grid = (Grid)picker.Parent;

            var selectedItem = picker.SelectedItem as string;

            if (selectedItem != null)
            {
                // Almacena el estado seleccionado antes de cambiar el ItemsSource
                var estadoPrevioItem = picker.SelectedItem as string;

                // Desactiva el evento SelectedIndexChanged temporalmente
                picker.SelectedIndexChanged -= Picker_SelectedIndexChanged;

                // Obtener el objeto vinculado a la fila seleccionada
                Incidencia incidencia = (Incidencia)picker.BindingContext;

                if (incidencia != null)
                {
                    // Almacena el estado actual de la incidencia
                    EstadoActual = incidencia.Estado;

                    string idIncidencia = incidencia.Id.ToString();

                    // Conéctate a la base de datos y actualiza la incidencia
                    await App.bdd.ActualizarIncidencia(idIncidencia, selectedItem);

                    // Verifica y actualiza el ItemsSource según el estado seleccionado
                    if (selectedItem == "Sin resolver")
                    {
                        picker.SelectedIndexChanged -= Picker_SelectedIndexChanged;
                        picker.ItemsSource = new List<string> { "Sin resolver", "En curso" };
                        picker.SelectedItem = selectedItem;
                        picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
                    }
                    if (selectedItem == "En curso")
                    {
                        picker.SelectedIndexChanged -= Picker_SelectedIndexChanged;
                        picker.ItemsSource = new List<string> { "En curso", "Resuelta" };
                        picker.SelectedItem = selectedItem;
                        picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
                        await App.bdd.AsignarTecnico(idIncidencia, UserLogueado.UserLog);
                    }
                    if (selectedItem == "Resuelta")
                    {
                        picker.SelectedIndexChanged -= Picker_SelectedIndexChanged;
                        picker.ItemsSource = new List<string> { "Resuelta" };
                        picker.SelectedItem = selectedItem;
                        picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
                        // Conéctate a la base de datos y actualiza la incidencia
                        await App.bdd.ActualizarIncidenciaFin(idIncidencia, DateTime.UtcNow);

                        // Mostrar todos los botones en la fila seleccionada
                        foreach (var child in grid.Children)
                        {
                            // Buscar el botón btnBorrar por su nombre y establecer su visibilidad
                            var btnBorrar = grid.FindByName<ImageButton>("btnBorrar");

                            if (btnBorrar != null &&
                                await App.bdd.ObtenerRolUsuario(UserLogueado.UserLog) == "Admin")
                            {
                                btnBorrar.IsVisible = true;
                            }

                        }

                    }
                    // Selecciona el estado almacenado después de cambiar las opciones
                    picker.SelectedItem = estadoPrevioItem;

                }
                // Restaura el evento SelectedIndexChanged
                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            }
        }
    }

    private async void btnEstado_Clicked(object sender, EventArgs e)
    {
        if (pulsadoEstado == true)
        {
            incidenciasDesc = await App.bdd.OrdenarEstadoAsc(incidencias);

            collectionView.ItemsSource = null;

            collectionView.ItemsSource = incidenciasDesc;

            pulsadoEstado = false;
        }
        else
        {
            incidenciasDesc = await App.bdd.OrdenarEstadoDesc(incidencias);

            collectionView.ItemsSource = null;

            collectionView.ItemsSource = incidenciasDesc;

            pulsadoEstado = true;
        }
    }
}