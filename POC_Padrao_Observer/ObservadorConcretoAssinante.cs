using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Padrao_Observer
{
    class ObservadorConcretoAssinante:IObservador 
    {
        private SujeiroConcretoEditora sujeitoConcretoEditora;

        public ObservadorConcretoAssinante(SujeiroConcretoEditora o)
        {
            sujeitoConcretoEditora = o;
            sujeitoConcretoEditora.RegistrarObservador(this);
        }
        public void Atualizar(ISujeito sujeito)
        {
            if (sujeito == sujeitoConcretoEditora)
            {
                Console.WriteLine("[Aviso] - A editora alterou seu estado para: "+ sujeitoConcretoEditora.ObterEdicao());
            }
        }
    }
}
