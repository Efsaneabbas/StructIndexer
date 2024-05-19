namespace StructIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:\n" +
                    "1. Kitab elave et.\n" +
                    "2. Butun kitablarin siyahisina bax.\n" +
                    "3. Ada gore axtaris et.\n" +
                    "4. Kitabi sil.\n" +
                    "5. Value deyerine gore axtaris et.\n" +
                    "0. Proqrami bitir.");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Kitabin adini daxil edin:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Yazicinin adini daxil edin:");
                    string authorName = Console.ReadLine();



                }




     
            }   
    }
}
