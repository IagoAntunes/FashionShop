using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LojaRoupas.ViewModel
{
    public class ComprasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Roupa> ListaRoupas { get; set; }
        public ObservableCollection<RoupaRecomendado> ListaRecomendados { get; set; }
        public ObservableCollection<Roupa> ListaFiltrada { get; set{ListaFiltrada = value; }
        public string Texto { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ComprasViewModel(string palavra)
        {
            this.Texto = palavra;
            ListaRoupas = new ObservableCollection<Roupa>
            {
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$122.00" , Imagem = "Model1"},
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$90.99" , Imagem = "Model2"},
                new Roupa{Nome = "Casual T-Shirt" , Preco = "$130.99" , Imagem = "Model4"}
            };
            ListaFiltrada = new ObservableCollection<Roupa>();
            //btnBuscar = new Command((sender) =>
            //{
            //    List<Roupa> listaTeste = new List<Roupa>();
            //    string b = Texto;
            //    foreach (var item in ListaRoupas)
            //    {
            //        if (item.Nome.Contains(((SearchBar)sender).Text))
            //        {
            //            listaTeste.Add(item);
            //        }
            //    }
            //    Preencher(listaTeste);
            //});
        }

        public ICommand btnBuscar => new Command((sender) =>
        {
            //string word = ((SearchBar)sender).Text;
            List<Roupa> listaTeste = new List<Roupa>();
            foreach (var item in ListaRoupas)
            {
                if (item.Nome.Equals(Texto))
                {
                    listaTeste.Add(item);
                    Preencher(listaTeste);
                    O
               }
            }
           //var Resultado = ListaRoupas.Where((b) => b.Nome.Contains(palavra).ToList<Roupa>();

        });

        public void PesquisarButton1(object sender, EventArgs args)
        {
            var Resultado = ListaRoupas.Where((b) => b.Nome.Contains(((SearchBar)sender).Text)).ToList<Roupa>();
            Preencher(Resultado);
        }
        public void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var Resultado = ListaRoupas.Where((b) => b.Nome.Contains(((SearchBar)sender).Text)).ToList<Roupa>();
            Preencher(Resultado);
        }

        private void Preencher(List<Roupa> resultado)
        {
            foreach (var emp in resultado)
            {
                ListaFiltrada.Add(emp);
            }
        }
    }
}
