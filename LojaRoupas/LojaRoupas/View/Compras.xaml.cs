using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LojaRoupas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compras : ContentPage
    {
        public string palavra { get; set; }
        public Compras()
        {
            InitializeComponent();
            BindingContext = new ViewModel.ComprasViewModel();
        }
        private void GoDetalhe(object sender,EventArgs args)
        {
            Frame frameDetalhe = (Frame)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)frameDetalhe.GestureRecognizers[0];
            Roupa roupa = tapGest.CommandParameter as Roupa;
            //Navigation.PushAsync(new Paginas.Detalhes(vaga));

            App.Current.MainPage = new Detalhes(roupa);
        }
        private void TextoMudou(object sender, EventArgs args)
        {
            palavra = ((SearchBar)sender).Text;
            BindingContext = new ViewModel.ComprasViewModel(palavra);
        }

    }
}