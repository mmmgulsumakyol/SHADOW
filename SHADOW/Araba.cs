using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHADOW
{
    internal class Araba
    {
        public decimal Fiyat {  get; set; }
        public string Model {  get; set; }
        public void ArabaBilgi()
        {
            Console.WriteLine("Arabanın Fiyatı:" + Fiyat + "Arabanın Modeli:" + Model);
        }
    }
}
