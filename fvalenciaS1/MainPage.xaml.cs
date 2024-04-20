namespace fvalenciaS1
{
    public partial class MainPage : ContentPage
    {
        private string nombre, apellido;
        private int edad;
        private double  aporte;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CalcularBtn_Clicked(object sender, EventArgs e)
        {
            nombre = TxtNombre.Text;
            apellido = TxtApellido.Text;
            edad = Convert.ToInt32(TxtEdad.Text);
            aporte = Convert.ToInt32(TxtSalario.Text) * 0.0945;


            await DisplayAlert("Alerta", "Bienvenido " + nombre + " " + apellido + "\n" +
                "tienes " + edad + " años" + "\n" +
                "Tu aporte mensual es $ " + aporte, "Cerrar");

            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEdad.Text = "";
            TxtSalario.Text = "";

        }
    }

}
