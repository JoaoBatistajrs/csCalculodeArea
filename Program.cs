using System;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo retangulo = new Retangulo();    
            Console.WriteLine();        
            Console.WriteLine("Esta é sua cálculadora de áreas");
            Console.WriteLine("Por favor informe a Base para qual deseja realizar o calculo: ");
            retangulo.Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ótimo, obrigado. Agora informe a Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();    
            retangulo.exibeDados();
            Console.ReadKey();
        }
    }
}
