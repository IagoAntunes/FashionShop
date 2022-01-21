using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace LojaRoupas.ViewModel
{
    public class ComprasViewModel
    {
        public ObservableCollection<Roupa> ListaRoupas { get; set; }
        public ObservableCollection<RoupaRecomendado> ListaRecomendados { get; set; }
        public Command btnBuscar;
        public ComprasViewModel()
        {


            ListaRoupas = new ObservableCollection<Roupa>
            {
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$122.00" , Imagem = "Model1"},
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$90.99" , Imagem = "Model2"},
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$130.99" , Imagem = "Model4"}
            };
            ListaRecomendados = new ObservableCollection<RoupaRecomendado>
            {
                new RoupaRecomendado { Nome="Casual Dress", Descricao="Modern Style", Imagem="Model1" },
                new RoupaRecomendado { Nome="Casual Dress", Descricao="Modern Style", Imagem="Model4" }
            };
        }
        private void BuscarTitulo()
        {

        }
    }
}
