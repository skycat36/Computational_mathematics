using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vich_Mat_laba_1
{
    public class Inter
    {
        public TableInterp[] tableInterp;  // Таблица узлов интерполяции
        public double ArgX;
        private int n;

        public Inter(TableInterp[] interp)
        {
            tableInterp = interp;
            n = interp.Length;
        }

        public void Set_ArgX(double ArX)   // значение в котором нужно вычислить многочлен
        {
            ArgX = ArX;
        }

        private double SigmaArgX()
        {
            double sigm = 1;
            for (int i = 0; i < this.n; i++)
            {
                sigm *= this.ArgX - tableInterp[i].x;
            }
            return sigm;
        }

        private  double SigmaBarArgXi(int key)
        {
            double sigm = 1;
            for (int i = 0; i < this.n; i++)
            {
                if (i != key )
                {
                    sigm *= tableInterp[key].x - tableInterp[i].x;
                }
            }
            return sigm;
        }

        public double LagrangInterp()
        {
            double lagr = 0;
            double sigm = SigmaArgX();

            for (int i = 0; i < this.n; i++)
            {
                lagr += (sigm * tableInterp[i].f_x) / ((this.ArgX - tableInterp[i].x) * SigmaBarArgXi(i)); //Барицентрический многочлен Лагранжа
            }

            return lagr;
        }
    }
}
