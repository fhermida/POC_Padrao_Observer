using System;

namespace POC_Padrao_Observer
{
    interface ISujeito
    {
        void RegistrarObservador(IObservador o);
        void RemoverObservador(IObservador o);
        void NotificarObservadores();
    }
}
