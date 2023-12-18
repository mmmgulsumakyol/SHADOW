using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHADOW
{
    internal class Bmw:Araba
    {
        public int KapiSayisi { get; set; }
        public int KoltukSayisi {  get; set; }
        public int Yili {  get; set; }
        public new void ArabaBilgi() 
        {
            Console.WriteLine("KApı Sayısı" + 4 + "Koltuk Sayısı:" + 5 + "Araba Yılı:" + 2010);
        }
        
    }
  
}
