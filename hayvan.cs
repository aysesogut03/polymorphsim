using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public class hayvan
    {
        public string isim { get; set; }   
        public hayvan(string isim)
        {
            this.isim = isim;
        }
        public string getIsım()
        {
            return this.isim;
        }
        public void setIsım(string isim)
        {
            this.isim = isim;
        }

        public virtual void konus()
        {
            Console.WriteLine("Hayvan konuşuyor.");
        }
    }
}
