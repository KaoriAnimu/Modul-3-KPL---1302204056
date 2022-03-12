using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_1302204056
{
    internal class penmalming1
    {
        private string[] fruitcode = {
            " A00 ", " B00 ", " C00 ", " D00 ", " E00 ", " F00 ", " H00 ", " I00 ", " J00 ", " K00 ", " L00 ", " M00 ", " O00 "
        };

        private string[] fruitname = { 
            " Apel ", " Aprikot ", " Alpukat ", " Pisang ", " Paprika ", " Blackberry ", " Ceri ", " Kelapa ", " Jagung ", " Kurma ", " Durian ", " Anggur ", " Melon ", " Semangka " 
        } ;

        

        public void getPenmalming1()
        {
            int panjang = fruitname.Length ;

            for (int i = 0; i < panjang; i++)
            {
                Console.WriteLine(fruitname[i] + " " + fruitcode[i]) ;
            }
        }


    }
}