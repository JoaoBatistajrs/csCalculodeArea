using System;


namespace CalculoArea
{  
    public class CalculoArea
    {
	   
		public CalculoArea()
        {
            this.Altura = 0;
            this.Base = 0;
        }
        //Base do objeto
        private double baseObj;

        public double Base
        {
            get { 
                return baseObj; 
                } 
            set { 
                if (value >= 0) baseObj = value; 
                else baseObj = 0;
                }
        }

        //Altura do objeto
        private double alturaObj;


        public double Altura
        {
            get { 
                return alturaObj; 
                }
            set { 
                if( value >= 0) alturaObj = value; 
                else alturaObj =0;
                }
        }

        //Calculo de altura vezes base;
        public double Area
        {
            get { return alturaObj*baseObj; }
        }   

        public void exibeDados()
        {
            Console.WriteLine("Base informada: " + this.Base);
            Console.WriteLine("Altura informada: " + this.Altura);
            Console.WriteLine("De acordo com as informações inseridas, a Area do seu Objeto é: "+ this.Area);
        }

	}
}
