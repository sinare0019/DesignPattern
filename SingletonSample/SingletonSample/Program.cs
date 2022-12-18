using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Score score1 = Score.GetInstance();
            Score score2 = Score.GetInstance();
            score1.Number = 5;
            //در این قسمت مشاهده میکنیم که دیگر 2 ابجکت متفاوت تعریف نشد بلکه هر دو با هم برابرند
            Console.WriteLine(score2.Number);           
            Console.ReadKey();
        }
    }
}
