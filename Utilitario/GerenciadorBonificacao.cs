using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        public double totalBonificacao { get; private set; }

        public void registrar(Funcionario funcionario) {
            this.totalBonificacao += funcionario.GetBonificacao();
        }
    }
}
