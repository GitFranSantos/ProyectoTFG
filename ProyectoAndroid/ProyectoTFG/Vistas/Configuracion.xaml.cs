using ProyectoTFG.Usabilidad;

namespace ProyectoTFG.Vistas;

public partial class Configuracion : ContentPage
{
    ResourceDictionary miDic;
    ICollection<ResourceDictionary> miListaDiccionarios;

    public string TemaSeleccionado { get; set; }
    public string EmailConectado { get; set; }

    private AppShell miShell;

    public Configuracion(AppShell appShell)
    {
        InitializeComponent();

        this.miShell = appShell;

        miDic = App.Current.Resources;

        miListaDiccionarios = App.Current.Resources.MergedDictionaries;
    }

    public async void InicializarConfiguracion(string email)
    {
        string temaActual = await App.bdd.ObtenerTema(email);
        double tamLetraActual = await App.bdd.ObtenerTamFuente(email);

        switch (temaActual)
        {
            case "Tema Original":
                temaOriginalRadioButton.IsChecked = true;
                break;
            case "Tema Claro":
                temaClaroRadioButton.IsChecked = true;
                break;
            case "Tema Alto Contraste":
                temaAltoContrasteRadioButton.IsChecked = true;
                break;
            default:
                temaOriginalRadioButton.IsChecked = true;
                break;
        }

        sliderFontSize.Value = tamLetraActual;
    }

    private void sliderFontSize_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        miDic["tamLetra"] = sliderFontSize.Value;
    }

    public void SetTamLetra(int tamLetra)
    {
        miDic["tamLetra"] = tamLetra;
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // Verifica si el RadioButton ha sido marcado
        if (e.Value)
        {
            miListaDiccionarios.Clear();

            // Obtiene el RadioButton que disparó el evento
            var selectedRadioButton = sender as RadioButton;

            // Verifica el valor del RadioButton seleccionado
            if (selectedRadioButton.Value.ToString() == "Tema Original")
            {
                miListaDiccionarios.Add(new TemaOriginal());
                TemaSeleccionado = "Tema Original";
            }
            else if (selectedRadioButton.Value.ToString() == "Tema Claro")
            {
                miListaDiccionarios.Add(new TemaClaro());
                TemaSeleccionado = "Tema Claro";
            }
            else if (selectedRadioButton.Value.ToString() == "Tema Alto Contraste")
            {
                miListaDiccionarios.Add(new TemaOscuro());
                TemaSeleccionado = "Tema Alto Contraste";
            }

        }
    }

    public string GetTemaActual()
    {
        return TemaSeleccionado;
    }
    private async void btnGuardarConfi_Clicked(object sender, EventArgs e)
    {
        await App.bdd.ActualizarConfiguracionUsuario(Modelos.UserLogueado.UserLog, TemaSeleccionado, sliderFontSize.Value);

        DisplayAlert("", "Configuración Guardada", "ok");
    }
}