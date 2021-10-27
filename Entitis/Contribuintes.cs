using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Enums.ClassesAbstratos.Entitis
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuintes()
        {

        }
        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double Imposto();

    }
        

        

    
}
