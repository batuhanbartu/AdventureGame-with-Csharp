using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }
        public static void gameTitle()
        {
            string art = @"
   _____       .___                    __                           ________                       
  /  _  \    __| _/__  __ ____   _____/  |_ __ _________   ____    /  _____/_____    _____   ____  
 /  /_\  \  / __ |\  \/ // __ \ /    \   __\  |  \_  __ \_/ __ \  /   \  ___\__  \  /     \_/ __ \ 
/    |    \/ /_/ | \   /\  ___/|   |  \  | |  |  /|  | \/\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
\____|__  /\____ |  \_/  \___  >___|  /__| |____/ |__|    \___  >  \______  (____  /__|_|  /\___  >
        \/      \/           \/     \/                        \/          \/     \/      \/     \/ ";

            Console.WriteLine(art);
            Console.WriteLine("Oyunuma Hoş Geldiniz.");
            Console.WriteLine("Başlamak için 'Enter'a basın.");
            Console.ReadLine();
            Console.Clear();
            first();
        }
        public static void first()
        {
            string choice;

            Console.WriteLine("Sınıfta kızgın Öğretmeninin tepende dikilmesiyle uyanırsın.");
            Console.WriteLine("Ne yaparsın?");
            Console.WriteLine("1. Ona bağır!");
            Console.WriteLine("2. Ağla");
            Console.WriteLine("3. Altına kaçır");
            Console.Write("Seçimin: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "bağır":
                    {
                        Console.WriteLine("Ayağa kalktın ve öğretmene bağırdın.");
                        Console.WriteLine("Sınıftaki diğer arkadaşların senin adına tezahürat yapar.");
                        Console.WriteLine("Müdür kargaşayı duyar ve araştırmaya gelir.");
                        Console.WriteLine("Öğretmene bağırdığını gören Müdür sana çok kötü bakar.");
                        Console.WriteLine("Devam etmek için 'Enter'a bas.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "ağla":
                    {
                        Console.WriteLine("Öğretmenin yüzü kızarır.");
                        Console.WriteLine("'Ağlamak istiyorsan koridora çık!' diye bağırır.");
                        Console.WriteLine("Devam etmek için 'Enter'a bas.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "kaçır":
                    {
                        Console.WriteLine("Öğretmenin havayı koklar, arkadaşların burnunu kapatır çünkü altına işedin.");
                        Console.WriteLine("Sen az önce...? Defol buradan! diye bağırır.");
                        Console.WriteLine("Devam etmek için 'Enter'a bas.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Girilen komut sanırım yanlış :/..");
                        Console.WriteLine("Devam etmek için 'Enter'a basın.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }
        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = { "Koridorda polislerin dolapları aradığını görüyorsun.",
            "Koridorda birinin seni takip ettiğini görüyorsun.",
            "Koridorda yangın alarmı çalıyor."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Lavoboda saklanmaya çalışır mısın?;\t Evet ya da Hayır?");
            Console.WriteLine("Kararın: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "evet" || secChoice == "e")
            {
                third();
            }
            else if (secChoice == "hayır" || secChoice == "h")
            {
                Console.WriteLine("Tam o anda okula bir roket düşer ve seni anında öldürür.");
                Console.WriteLine("Devam etmek için 'Enter'a bas.");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("Girilen komut sanırım yanlış :/..");
                Console.WriteLine("Devam etmek için 'Enter'a basın.");
                Console.ReadLine();
                second();
            }

        }
        public static void third()
        {
            int age;
            Console.WriteLine("Lavoboya daldın ve tüm arkadaşların oradaydı.");
            Console.WriteLine("'Sürpriz!' diye bağırıyorlar ve doğum günün olduğunu hatırlıyorsun.");
            Console.WriteLine("Bugün kaç yaşına girdin");
            Console.WriteLine("Yaş: ");
            int.TryParse(Console.ReadLine(), out age);

            while (age < 25)
            {
                Console.WriteLine("Cidden? Bundan daha yaşlı görünüyorsun!");
                Console.WriteLine("Gerçekten kaç yaşındasın?");
                Console.WriteLine("Yaş: ");
                int.TryParse(Console.ReadLine(), out age);
            }
            Console.WriteLine("Vay çok yaşlısın sınıfta mı kaldın!?");
            Console.WriteLine("Tekrar denemek için 'Enter'a basın.");
            Console.ReadLine();
            youWin();
        }
        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("Bir dahaki sefere daha iyi şanslar");
            Console.WriteLine("Tekrar denemek için 'Enter'a basın.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Doğum günü partin büyük dikkat çekti.");
            Console.WriteLine("Tekrar denemek için 'Enter'a bas.");
            Console.WriteLine("Hepiniz 100 yıl daha yaşayacaksınız.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}
