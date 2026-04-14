namespace EserciziListe2
{
    internal class Program
    {
        static List<int> IndiceEsplosivo(List<int> liste)
        {
            for(int i = liste.Count -1; i >= 0; i--)
            {
                if(liste[i] == i)
                {
                    liste.RemoveAt(i);
                }
            }

            return liste;
        }
        static List<int> Rotazione(List<int> liste, int spostamenti)
        {
            for(int i = 0;  i < spostamenti; i++)
            {
                liste.Insert(0, liste[liste.Count - 1]);
                liste.RemoveAt(5);
            }

            return liste;
        }
        static void frequenza(List<int> liste)
        {
            int a = 0, max = -10000, num = 0;

            for(int i = 0; i < liste.Count; i++)
            {
                a = 0;

                for(int j = 0; j < liste.Count; j++)
                {
                    if (liste[i] == liste[j])
                    {
                        a++;
                        
                    }
                }

                if(max < a)
                {
                    max = a;
                    num = i;
                }
            }

            Console.Write("Il numero " + liste[num] + " è il piu ripetuto. ");
            Console.WriteLine("Si ripete " + max + " volte");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1");
            List<int> valori = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            IndiceEsplosivo(valori);

            foreach (int i in valori)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Esercizio 2");
            Console.WriteLine("Dimmi il numero di spostamenti");
            int spostamenti = Convert.ToInt32(Console.ReadLine());

            List<int> Numeri = new List<int>() { 1, 2, 3, 4, 5 };
            Rotazione(Numeri, spostamenti);

            foreach (int i in Numeri)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Esercizio 3");
            List<int> NumeriR = new List<int>() { 4, 2, 4, 2, 3, 2, 4, 1, 2, 4, 2 };
            frequenza(NumeriR);
        }
    }
}
