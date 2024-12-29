using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //.net uygulamalarıtemel olarak, program kodu, veri ve meta datadan oluşur. Metadata, veri hakkında veri olarak tanımlanır ve programın binary dosyalarının(exe veya dll) içine gömülür. 
            //Attributelar(Nitelikler) ile programımıza ve onun elemanlarına derleyici direktifleri(yönetmen)(compiler Instractions) ve diğer metadata bilgilerini ekleyebiliriz. 
            //Attribute'lar:
            //- Sınıflara
            //- Sınıf Üyelerine(field, functions, constructor)
            //- Arayüzlere
            //- Enumlara
            //Eklenebilirler. 

            #endregion

            #region Kullanım

            Test test = new Test();
            test.Metot_A();
            test.Metot_B();
            test.Metot_C();

            //Console.ReadKey();

            #endregion
        }
    }

    class Test
    {
        public void Metot_A()
        {
            Console.WriteLine("Metot A'dan Merhaba");
        }
        [Conditional("DEBUG")]//Üstüne konduğu şeyi debug modda çalıştırır.
        public void Metot_B()
        {
            Console.WriteLine("Metot b'den Merhaba");
        }
        public void Metot_C()
        {
            Console.WriteLine("Metot C'den Merhaba");
        }
    }
}
