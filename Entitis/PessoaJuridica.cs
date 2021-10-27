using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Enums.ClassesAbstratos.Entitis
{
    class PessoaJuridica : Contribuintes
    {
        public int QntFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }
        public PessoaJuridica(string nome, double rendaAnual, int qntFuncionarios) : base (nome, rendaAnual)
        {
            QntFuncionarios = qntFuncionarios;
        }

        public override double Imposto()
        {
            if (QntFuncionarios <= 10)
            {

                RendaAnual = (RendaAnual * 0.16);

            }
            else
            {
                RendaAnual = (RendaAnual * 0.14);
            }
            return RendaAnual;
        }
    }
}
