using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDLL3._1
{
    public class Class1
    {
        private int num1 = 5;
        private int num2 = 3;

        public void setNum1(int numero)
        {
            num1 = numero;
        }

        public void setNum2(int numero)
        {
            num2 = numero;
        }

        public int Multiplica()
        {
            return num1 * num2;
        }
    }
}
