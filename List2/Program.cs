using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kahve listeniz kaç elemanlı olsun");//Kulanıcıdan istediği kadar kahve olusturması için eleman değişkeni aldık
            int eleman=Convert.ToInt32(Console.ReadLine());

            ArrayList Kahve=new ArrayList();//Arraylistimiz

            Console.WriteLine("Kahve isimlerini giriniz.");
            for (int i = 1; i <=eleman; i++)//Dongümüzü girdiğimiz eleman kadar donderiyoruz
            {   
                string kahveler=Console.ReadLine();//Kahveler değişkenini Kahve arrayimizin içine atayark dongu her donduğunde girdiğimiz kahveleri kaydedecek
                
                Kahve.Add(kahveler);//Arrayimizin içine girdiğimiz kahve isimlerini kaydediyoruz
            }

            Console.Clear();

            Console.WriteLine("kahveleriniz : ");

            foreach(string kahveler in Kahve)//Ekrana bastırma
            {
                Console.WriteLine(kahveler);
            }
            Console.ReadKey();
        }
    }
}
