using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLab11._1
{
    public class Class
    {
        public int First { get; set; } = 0;
        public int Second { get; set; } = 0;

        public double Result()
        {
            return First * Second * 1 / 2;
        }

        public string Print()
        {
            return $"Площадь прямоугольного треуголинка равна : {Result():F2}";
        }
    }
}
