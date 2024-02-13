using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vebaglacikullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen yaşınızı giriniz");
            int yas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen cinsiyetinizi giriniz (erkek-kız)");
            string cinsiyet = Console.ReadLine();

            if (yas >= 20 && cinsiyet == "erkek")
            {
                Console.WriteLine("Askere gidebilirsiniz");
            }
            else
            {
                Console.WriteLine("Askerlik şartlarını sağlamadığınızdan dolayı askere gidemezsiniz");
            }

            Console.ReadLine();
        }
    }
}