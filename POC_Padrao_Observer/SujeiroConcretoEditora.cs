using System;
using System.Collections.Generic;

namespace POC_Padrao_Observer
{
    internal class SujeiroConcretoEditora : ISujeito
    {
        private readonly List<IObservador> Observadores = new List<IObservador>();
        private bool _novaEdicao;

        public void RegistrarObservador(IObservador o)
        {
            Observadores.Add(o);
        }

        public void RemoverObservador(IObservador o)
        {
            Observadores.Remove(o);
        }

        public void NotificarObservadores()
        {
            foreach (var o in Observadores)
            {
                o.Atualizar(this);
            }
        }

        public void AlterarEdicao()
        {
            if (_novaEdicao)
                _novaEdicao = false;
            else
                _novaEdicao = true;

            NotificarObservadores();
        }

        public Boolean ObterEdicao()
        {
            return _novaEdicao;
        }
    }
}
