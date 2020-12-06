using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTerceiroBimestrePT
{
    class LerNumericos
    {
        static public Int32 LeFloat(String valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                //MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
                throw e;
            }
        }
    }
}
