using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{  public  delegate void MyDelegate();
   public delegate string MyStringdg(string input_p);
   public delegate void MyEvent(string input_p);
    class Program
    {
        static void sayGreeting() {
            Console.WriteLine("Приветик");
        
        } 
        static void Main(string[] args)
        {
            UserU obuser = new UserU();
            Boss obboss = new Boss();
            obuser.ev += obboss.getPanic;
            //Console.WriteLine(obuser.Fio);
            obuser.Fio = "Луна";

            //MyDelegate delref = new MyDelegate(sayGreeting);
            MyStringdg strdlg;// = delegate(string inv) { return inv + "Hello world"; };
           /* MyStringdg strdlg = (a) => {
                Console.WriteLine("Лес");
                return " Кот";
                        };

            Console.WriteLine(strdlg("Луна "));*/
            
            /* delref += obuser.getInfo;
            delref += sayGreeting;
           // delref();
            foreach (MyDelegate v in delref.GetInvocationList()) {

                v();
            }
            MyStringdg strdlg = obuser.getFio;
            Console.WriteLine(strdlg("Звезда"));
            */


        }
    }
}
