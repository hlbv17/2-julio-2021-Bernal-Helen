using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Leccion1HLBV.control
{
    class ValidacionHLBV
    {
        
        internal bool EsEntero(string valor)
        {
            bool flag = true;
            int x = 0;
            try
            {
                x = Convert.ToInt32(valor);
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
                flag = false;
            }
            return flag;
        }

        internal int AEntero(string valor)
        {
            int x = 0;
            try
            {
                x = Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error: se esperaba un número entero");
            }
            return x;
        }
    }
}
