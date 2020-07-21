using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationProgram
{
    class Rezult
    {
        /// <summary>
        /// Результат функции в DataGrid
        /// </summary>
        public string FXYrezult { get; set; }
        /// <summary>
        /// Результатат значения X в DataGrid
        /// </summary>
        public string Xrezult { get; set; }
        /// <summary>
        /// Результатат значения Y в DataGrid
        /// </summary>
        public string Yrezult { get; set; }

        /// <summary>
        /// Результаты значений для табличного вида в DataGrid
        /// </summary>
        /// <param name="fxyrezult">Значение функции f(x,y)</param>
        /// <param name="xrezult">Значение числа x</param>
        /// <param name="yrezult">Значение числа y</param>
        public Rezult(string fxyrezult, string xrezult, string yrezult)
        {
            this.FXYrezult = fxyrezult;
            this.Xrezult = xrezult;
            this.Yrezult = yrezult;
        }
    }

}
