using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Enums.ClassesAbstratos.Entitis
{
    class PessoaFisica : Contribuintes
    {
        public double GastosSaude { get; set; }
       
        public PessoaFisica ()
        {

        }
        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base (nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000)
            {
             
                RendaAnual = (RendaAnual * 0.15) - (GastosSaude * 0.50);
                
            }
            else
            {
                RendaAnual = (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }
            return RendaAnual;
        }
    }
}
