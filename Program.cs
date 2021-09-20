using System;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalculoArea calculoArea = new CalculoArea();    
            Console.WriteLine();        
            Console.WriteLine("Esta é sua cálculadora de áreas");
            Console.WriteLine("Por favor informe a Base para qual deseja realizar o calculo: ");
            calculoArea.Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ótimo, obrigado. Agora informe a Altura: ");
            calculoArea.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();    
            calculoArea.exibeDados();
            Console.ReadKey();
        }
    }
}
