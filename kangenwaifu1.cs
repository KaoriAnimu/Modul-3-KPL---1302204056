using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_1302204056
{
    internal class kangenwaifu1
    {
        enum State { Exit, XButton, WButton };

        public static void Start ()
        {
            Console.WriteLine (" Enter State ") ;

            State state = State.XButton ;

            while (state != State.Exit)
            {
                string command = Console.ReadLine () ; // saya masih kurang paham kenapa ini masih dianggap converting null bang
                switch (command)
                {
                    
                    case "WButton":
                        Console.WriteLine (" Take off position ") ;
                        Console.WriteLine () ;
                        break ;

                    case "XButton":
                        Console.WriteLine (" Landing Position ") ;
                        Console.WriteLine () ;
                        break ;

                    case "Exit":
                        state = State.Exit ;
                        break ;

                    default:
                        Console.WriteLine (" Re - Enter State ") ;
                        break ;


                }

            }

        }
    }
}