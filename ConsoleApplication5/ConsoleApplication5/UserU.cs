using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class UserU
    {
        public event MyEvent ev;
        string fio = "Солнцев";

        public string Fio
        {
            get { return fio; }
            set { 
                fio = value;
                ev(value);
            }
        }

        public void getInfo() {

            Console.WriteLine("Значение фамилии: " +fio);
        }

        public string getFio(string inp) {
            string temp = fio;
            fio = inp;
            return "было "+ temp + "Стало"+inp ;
        } 
    }
}
