using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace DataBinding
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            GetData();
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private ObservableCollection<PersonaModel> _personas;
        public ObservableCollection<PersonaModel> Personas
        {
            get => _personas;
            set
            {
                _personas = value;
                OnPropertyChanged();
            }
        }


        public async void GetData()
        {
            var response = await _httpClient
                .GetStringAsync("https://fi.jcaguilar.dev/v1/escuela/persona");
            var personas = JsonSerializer
                .Deserialize<ObservableCollection<PersonaModel>>(response);

            Personas = personas;
        }

        private async void btnpagsig_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormPage());
        }
    }

}
