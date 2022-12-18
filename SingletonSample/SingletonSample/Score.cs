using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    public class Score
    {

        private static Score instance;
        private Score() { }
        public int Number { set; get; }

        public static Score GetInstance()
        {
            if (instance == null)
            {
                instance = new Score();
            }
            return instance;
        }
    }
}
