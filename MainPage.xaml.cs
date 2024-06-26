namespace AlgoritmoTablas
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            ScrollView scrollView = new ScrollView();
            Content = scrollView;

            StackLayout stackLayout = new StackLayout();
            scrollView.Content = stackLayout;

            for (int numero=1; numero <= 10; numero++)
            {
                Label TituloTabla = new Label();
                TituloTabla.Text = $"Tabla Del {numero}";
                stackLayout.Children.Add(TituloTabla);

                for(int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    int resultado = numero * multiplicador;
                    Label lineaTabla = new Label();
                    lineaTabla.Text=$"{numero}x{multiplicador}={resultado}";
                    stackLayout.Children.Add(lineaTabla);
                }

                stackLayout.Children.Add(new Label { Text = "" });
            }


        }

    }

}
