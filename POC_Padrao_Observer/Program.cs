using System;

namespace POC_Padrao_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SujeiroConcretoEditora editora = new SujeiroConcretoEditora();

            ObservadorConcretoAssinante assinante1 = new ObservadorConcretoAssinante(editora);
            ObservadorConcretoAssinante assinante2 = new ObservadorConcretoAssinante(editora);
            ObservadorConcretoAssinante assinante3 = new ObservadorConcretoAssinante(editora);
            ObservadorConcretoAssinante assinante4 = new ObservadorConcretoAssinante(editora);
            ObservadorConcretoAssinante assinante5 = new ObservadorConcretoAssinante(editora);

            editora.AlterarEdicao();

            editora.AlterarEdicao();

            Console.ReadKey();
        }
    }
}
