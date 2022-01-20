using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LojaRoupas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        public Detalhes(Roupa roupa)
        {
            InitializeComponent();
            BindingContext = new ViewModel.DetalhesViewModel(roupa);
        }
    }
}