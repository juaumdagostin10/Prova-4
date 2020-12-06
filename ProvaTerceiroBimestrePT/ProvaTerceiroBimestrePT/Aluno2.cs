using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTerceiroBimestrePT
{
    public class Aluno2
    {
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public String Curso { get; set; }
        public Double Nota { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return "Nome:" + Nome + ", " +
                   "Sobrenome:" + Sobrenome + ", " +
                   "Curso:" + Curso + ", " +
                   "Nota do Curso:" + Nota + ", " +
                   "Data:" + Data;
        }
    }
}
