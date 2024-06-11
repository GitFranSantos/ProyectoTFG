namespace ProyectoTFG.Vistas;

public partial class ConfirmarSalir : ContentPage
{
    public ConfirmarSalir()
    {
        InitializeComponent();
    }

    private async void btnVolver_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private void btnAceptar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }
}