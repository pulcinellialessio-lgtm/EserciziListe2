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
        static int frequenza(List<int> liste)
        {
            int a = 0, max = -10000, num = 0;

            for(int i = 0; i < liste.Count; i++)
            {
                for(int j = 0; j < liste.Count; j++)
                {
                    if (liste[i] == liste[j])
                    {
                        a++;
                        num = j;
                    }
                }

                if(max < a)
                {
                    max = a;
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> valori = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };
            IndiceEsplosivo(valori);

            Console.Write("Esercizio 1");
            foreach (int i in valori)
            {
                Console.WriteLine(i);
            }





            List<int> NumeriR = new List<int>() { 4, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9 };
        }
    }
}
