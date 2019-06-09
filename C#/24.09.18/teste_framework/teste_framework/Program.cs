using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 4.999;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado!");
                Console.WriteLine("a nota do aluno foi: " + media);
            }

            else if(media < 7 && media >= 5)
            {
                Console.WriteLine("Aluno em recuperação!");
                Console.WriteLine("a nota do aluno foi: " + media);
            }



            else
            {
                Console.WriteLine("O aluno foi reprovado!");
                Console.WriteLine("a nota do aluno foi: " + media);
            }
            Console.ReadKey();
        }
    }
}
