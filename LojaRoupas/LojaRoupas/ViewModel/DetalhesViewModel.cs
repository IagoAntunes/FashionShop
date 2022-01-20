using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaRoupas.ViewModel
{
    public class DetalhesViewModel
    {
        public string Nome { get; set; }
        public DetalhesViewModel(Roupa roupa)
        {
            this.Nome = roupa.Nome;
        }
    }
}
