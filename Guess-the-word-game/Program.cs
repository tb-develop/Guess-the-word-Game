namespace Guess_the_word_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prvi igralec vnese besedo

            Console.WriteLine("Vpišite besedo s petimi črkami: ");
            string ugibanaBeseda = "";
            string uporabnikovaBeseda = "";
            int steviloPoskusov = 0;

            while (ugibanaBeseda.Length != 5)
            {
                ugibanaBeseda = Console.ReadLine();

                if (ugibanaBeseda.Length != 5)
                {
                    Console.WriteLine("Napaka, ponovno vnesite besedo, ki ima 5 črk: ");
                }
            }

            Console.Clear();

            // Drugi igralec ugiba besedo

            Console.WriteLine("Ugibana beseda: " + ugibanaBeseda[0]);

            while (uporabnikovaBeseda != ugibanaBeseda)
            {
                Console.WriteLine("Vnesite besedo: ");
                uporabnikovaBeseda = Console.ReadLine();
                steviloPoskusov++;

                if (uporabnikovaBeseda.Length != ugibanaBeseda.Length)
                {
                    Console.WriteLine("Vnesite besedo s 5 črkami: ");
                    continue;
                }

                Console.WriteLine("Črke v besedi: ");

                for (int i = 0; i <= ugibanaBeseda.Length - 1; i++)
                {
                    for (int j = 0; j <= uporabnikovaBeseda.Length - 1; j++)
                    {
                        if (ugibanaBeseda[i] == uporabnikovaBeseda[j])
                        {
                            Console.Write(ugibanaBeseda[i]);
                        }
                    }
                }
                Console.WriteLine();


                Console.WriteLine("Črke na pravem mestu: ");

                for (int p = 0; p <= uporabnikovaBeseda.Length - 1; p++)
                {
                    if (ugibanaBeseda[p] == uporabnikovaBeseda[p])
                    {
                        Console.WriteLine(uporabnikovaBeseda[p]);
                    }
                }
            }

            Console.WriteLine($"Čestitamo! Uganili ste pravilno besedo v {steviloPoskusov} poskusih.");
        }
    }
}
