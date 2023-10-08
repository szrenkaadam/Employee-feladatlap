using System;
using System.Collections.Generic;
using System.IO;

namespace Employee_feladatlap
{
    class Program
    {
        //8. feladat
        static double AtlagKor(List<Alkalmazottak> alkalmazott)
        {
            double Index = 0;
            for (int i = 0; i < alkalmazott.Count; i++)
            {
                Index += alkalmazott[i].Age;
            }
            double eredemeny = Index / alkalmazott.Count;
            return eredemeny;
        }

        //9. feladat
        static int BudapestenElokSzama(List<Alkalmazottak> alkalmazott)
        {
            int index = 0;
            for (int i = 0; i < alkalmazott.Count; i++)
            {
                if (alkalmazott[i].City == "Budapest")
                {
                    index++;
                }
            }
            return index;
        }

        //10. feladat
        static int LegidosebbAlkalmazott(List<Alkalmazottak> alkalmazott)
        {
            int legidosebbKora = alkalmazott[0].Age;
            for (int i = 0; i < alkalmazott.Count; i++)
            {
                if (alkalmazott[i].Age > legidosebbKora)
                {
                    legidosebbKora = alkalmazott[i].Age;
                }
            }

            return legidosebbKora;
        }
        //11

        static void HarmincEvFolotti(List<Alkalmazottak> alkalmazott)
        {
            string nev = string.Empty;
            string eldontes = string.Empty;
            string[] nevek = new string[20];
            for (int i = 0; i < alkalmazott.Count; i++)
            {
                if (alkalmazott[i].Age > 30)
                {
                     eldontes = "Van 30 év feletti alkalmazott";
                    
                    foreach (var item in nevek)
                    {

                    }
                }
            }
            Console.WriteLine(eldontes);
        }

        static void Main(string[] args)
        {
            List<Alkalmazottak> alkalmazott = new List<Alkalmazottak>();



            foreach (var item in File.ReadAllLines(@"../../../adatok.txt"))
            {
                alkalmazott.Add(new Alkalmazottak(item));
            }

            for (int i = 0; i < alkalmazott.Count; i++)
            {
                alkalmazott[i].kiir();
            }


            //A következő feladatokat a program osztályban elhelyezett statikus metódusokkal oldd meg. (Aki szeret kísérletezni, teheti ezeket a metódusokat egy újabb osztályba.) Egyes feladatokat meg lehet oldani LINQ-val is, de ha belefér az időbe, kódoljátok le hagyományosan is. Ha van olyan feladat, ami nem egyértelmű, pl. az, hogyan kell kiírni, ott rád van bízva a megoldás.

            //8.     Függvény segítségével írd ki az életkorok átlagát.
            double atlagKor = AtlagKor(alkalmazott);
            Console.WriteLine("Az alkalmazottak átlagkora: " + atlagKor);


            //9.     Függvény segítségével írd ki azon személyek számát, akiknek a városa 'Budapest'.
            double OttElok = BudapestenElokSzama(alkalmazott);
            Console.WriteLine($"A Budapesten élő alkalmazottak száma: {OttElok}");


            //10. Függvény segítségével keresd ki, majd a virtuális metódus segítségével írd ki a legidősebb személy adatait.
            int legidosebb = LegidosebbAlkalmazott(alkalmazott);
            Console.WriteLine($"A legidősebb számontartott alkalmazott kora: {legidosebb} év");


            //11. Függvény segítségével döntsd el, majd a főprogramban írd ki, hogy van-e 30 év fölötti személy, és emellett írd ki a nevét is. (Ez a függvény tehát két értéket kell, hogy generáljon, ezt egyetlen szövegként add vissza a főprogramnak, és a főprogram bontsa szét az adatokat, majd utána írja ki.)
            HarmincEvFolotti(alkalmazott);
            //12. Függvénnyel válogasd ki azon személyek nevét egy új tömbbe(nem listába), akik 30 évnél fiatalabbak.Ennek a tömbnek a hasznos tartalmát írd ki a főprogramban.

            //13. Egyetlen függvénnyel keresd meg a legfiatalabb és a legidősebb személyt. A függvénynek legyen két olyan paramétere, amiben az eredményt vissza lehet juttatni a főprogramba, és ott ki lehet írni a nevüket és a korukat. A függvény visszatérési értéke pedig képes legyen azt jelezni, hogy van-e több ugyanolyan korú legfiatalabb személy.

            //14. Készíts egy függvényt, ami átszámolja az euróban megadott havi fizetést éves fizetéssé, és az eredményt még váltsd át magyar forintba is.

            //15. Készíts egy függvényt, amelynek visszatérési értéke egy objektumokat tartalmazó lista, amelyben szerepel az 5 millió forint éves fizetés feletti munkavállalók neve és az éves fizetésük forintban. (Az átszámításhoz használd az előző feladat függvényét.)  Az elkészült listát a főprogram írja ki egy új fájlba(a virtuális metódus segítségével).

            //16. Írj egy függvényt, aminek a paramétere az eredeti adatokat tartalmazó listának megfelelő típusú.Ennek segítségével számold ki az összes alkalmazott átlagfizetését.

            //17. Készíts a főprogramban egy olyan listát, amiben csak a developer beosztásúak találhatók, minden tulajdonságukkal. Hívd meg újra a főprogramból az előző függvényt, de most ez az új lista legyen a paramétere.A főprogram írja ki a developerek átlagfizetését.

            //18. Számold ki a férfi és női alkalmazottak átlagfizetését tetszőleges módszerrel.
        }
    }
}
