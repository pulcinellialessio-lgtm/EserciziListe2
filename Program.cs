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
        static void Main(string[] args)
        {
            List<int> valori = new List<int>() { 0, 5, 2, 8, 4, 10, 6, 7 };

            foreach(int i in valori)
            {
                Console.WriteLine(IndiceEsplosivo(valori));
            }

        }
    }
}
