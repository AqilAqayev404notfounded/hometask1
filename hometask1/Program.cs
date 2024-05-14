using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;

namespace bbbb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string line = "------------------------";
            //string name = "Aqil";
            // int age = 20;
            // string BrithdayDate = "18.07.2004";

            // string FriendName = "Salman";
            // int FriendAge = 18;
            // string FriendBrithdayDate = "16.08.2006";

            // Console.WriteLine(name);
            // Console.WriteLine(age);
            // Console.WriteLine(BrithdayDate);  

            // Console.WriteLine(line);

            // Console.WriteLine(FriendName);
            // Console.WriteLine(FriendAge);
            // Console.WriteLine(FriendBrithdayDate);



            //int num1 = 6;
            //int num2 = 16;

            //int sum = (num1 + num2)/2;
            //Console.WriteLine(sum);

            //int Azn = 10;
            //double Usd = Azn / 1.7;
            //double Euro = Azn / 1.88;
            //double Tl = Azn / 18.97;
            //Console.WriteLine(Usd);
            //Console.WriteLine(Euro);
            //Console.WriteLine(Tl);
            //var fdh = "aaa";

            //string line = "--------------------------";
            //string name = "Aqil";
            //string name = "Aqil";
            //string name = "Aqil";
            //string soname = "Aghayev";
            //int age = 20;
            //string MyPhoneNumber = "0706721202";

            //Console.WriteLine("This is my information");
            //Console.WriteLine(line);
            //Console.WriteLine("My  name is  " + name);
            //Console.WriteLine(line);
            //Console.WriteLine("My soname is " + soname);
            //Console.WriteLine(line);
            //Console.WriteLine("My age is " + age );
            //Console.WriteLine(line);
            //Console.WriteLine( "CONTACS : " + MyPhoneNumber );

            //int x = 5;
            //x += 5;

            //Console.WriteLine(x);

            // var i = 96;
            // if (i < 65)
            // {
            //     Console.WriteLine("Kesildin");

            // }
            // if (i >= 65 && i < 85)
            // {
            //     Console.WriteLine("Adi diplom");


            // }
            // if (i >= 85 && i < 95)
            // {
            //     Console.WriteLine("Seref diplomu");


            // }
            //else
            // {
            //     Console.WriteLine("yuksek seref diplomu");
            // }


            //  string celsium = Console .ReadLine();
            //  int celsiumcost = Convert.ToInt32(celsium);

            //double faranget = celsiumcost * 1.8;
            //Console.WriteLine(faranget);


            //int num = 18;
            //string gender = "Xanim";

            //if (num > 18 && gender== "Xanim" )

            //        Console.WriteLine("Giris icaze verilir");

            //else if(num == 18 && gender == "Xanim")

            //        Console.WriteLine("Giris icaze verilmir");
            //     else
            //        Console.WriteLine("uc burdan");

            //int a = 5;
            //int b = 57;

            //a = a + b;
            //b = a - b;
            //a = a - b;


            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //int brithdate = 2004;
            //int nowDate = 2024;

            //int age = nowDate - brithdate;

            //Console.WriteLine(age);

            //int a = 345;
            //int b = a % 10;
            //int c = (a / 10) % 10;
            //int d = a / 100;
            //int sum = b + c + d;
            //Console.WriteLine(sum);
            //Console.WriteLine("teveludunuz daxil edin");
            //string input = Console.ReadLine();
            //int age = Int32.Parse(input);

            //Console.WriteLine("yasiniiz :"+ (2024 - age));


            //Console.WriteLine("reqem yaz");

            //string input = Console.ReadLine();
            //int num;
            //string input2 = Console.ReadLine();
            //int num2;



            //bool result = Int32.TryParse(input, out num);
            //bool result2 = Int32.TryParse(input, out num2);

            //if (result == false || result == false)
            //    Console.WriteLine("reqem daxil et");
            //else
            //    Console.WriteLine(num + num2);


            //int user = 23;

            //if (user <23&&user >18)
            //{
            //    Console.WriteLine("girise icaze verillir");

            //}
            //else
            //{
            //    Console.WriteLine("yasiviz catmir giris ucun");

            //}


            //int num = 45;

            //if (num%2 == 0)
            //{
            //    Console.WriteLine("cutdur");

            //}
            //else
            //{
            //    Console.WriteLine("tekdir");
            //}


            //int userAge = 19;
            //bool gender = false;

            //if (userAge >= 18 && gender == false)
            //{
            //    Console.WriteLine("gire bilersiz");
            //}
            //else
            //{
            //    Console.WriteLine("Xanim  deyilsen ya da yasin catmir");


            //}


            //int num1 = 45;
            //int num2 = 34;

            //num1 = num1 + num2;
            //num2 = num2 - num1;
            //num2 = num2 - num1;

            //Console.WriteLine(num1 );
            //Console.WriteLine(num2);


            //int a = 3;
            //int b = 9;  

            //if (a *a ==b)
            //{
            //    Console.WriteLine("kvadiratidi");
            //}
            //else
            //{
            //    Console.WriteLine("kvadrati deyil");
            //}


            //int a = 345;
            //int b = a%10;
            //int c = (a / 10) % 10;
            //int d = a / 100;
            //int sum = b+c+d;
            //Console.WriteLine(sum);


            static string TersCevir(string metin)
            {
                char[] karakterler = metin.ToCharArray(); // Metni karakter dizisine çevir
                Array.Reverse(karakterler); // Karakter dizisini ters çevir
                return new string(karakterler); // Ters çevrilmiş karakter dizisini stringe çevir ve döndür
            }
            Console.Write("Bir kelime veya cümle girin: ");
            string metin = Console.ReadLine(); // Kullanıcıdan metni al

            string tersMetin = TersCevir(metin); // Metni ters çevir

            Console.WriteLine("Ters çevrilmiş hali: " + tersMetin);




















        }
    }
}
