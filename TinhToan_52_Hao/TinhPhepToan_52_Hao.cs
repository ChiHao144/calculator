using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToan_52_Hao
{
    public class TinhPhepToan_52_Hao
    {
        private int a_52_Hao, b_52_Hao;
        public TinhPhepToan_52_Hao(int a_52_Hao, int b_52_Hao)
        {
            this.a_52_Hao = a_52_Hao;
            this.b_52_Hao = b_52_Hao;
        }
        public int Execute_52_Hao(string CalSymbol)
        {
            int result_52_Hao = 0;
            switch(CalSymbol) 
            {
                case "+":
                    result_52_Hao = this.a_52_Hao + this.b_52_Hao;
                    break;
                case "-":
                    result_52_Hao = this.a_52_Hao - this.b_52_Hao;
                    break;
                case "*":
                    result_52_Hao = this.a_52_Hao * this.b_52_Hao;
                    break;
                case "/":
                    result_52_Hao = this.a_52_Hao / this.b_52_Hao;
                    break;

            }
            return result_52_Hao;
        }
    }
}
