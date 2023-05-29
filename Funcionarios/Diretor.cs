using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public string Senha { get; set; }

        public Diretor(string nome, string cpf) 
            : base(nome, cpf, 5000) { }

        public override double GetBonificacao() 
        {
            return this.Salario * 0.5;
        }

        public override void AumentarSalario() 
        {
            this.Salario *= 1.15;
        }
    }
}
