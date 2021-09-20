using System;


namespace CalculoArea
{  
    public class Retangulo
    {
	   
		public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }
        //Base do retângulo
        private double baseRet;

        public double Base
        {
            get { 
                return baseRet; 
                } 
            set { 
                if (value >= 0) baseRet = value; 
                else baseRet = 0;
                }
        }

        //Altura do retângulo
        private double alturaRet;


        public double Altura
        {
            get { 
                return alturaRet; 
                }
            set { 
                if( value >= 0) alturaRet = value; 
                else alturaRet =0;
                }
        }

        //Calculo de altura vezes base;
        public double Area
        {
            get { return alturaRet*baseRet; }
        }   

        public void exibeDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: "+ this.Area);
        }

	}
}
