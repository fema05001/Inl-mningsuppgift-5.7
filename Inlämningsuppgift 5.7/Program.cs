using System;
namespace Uppgift_5_7
{
    class program7
    {
        static void Main(string[] args)
        {
           
            string[] land = new string[6];
            land[1] = ("1. Kina");
            land[2] = ("2. Indien");
            land[3] = ("3. USA");
            land[4] = ("4. Indonesien");
            land[5] = ("5. Pakistan");

            Console.WriteLine("Här är en lista på världesn folkrikaste länder");
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(land[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Skriv in numret på länderna som du vill se igen separerade med ett mellanslag");
            Console.WriteLine(" ");
           string b = Console.ReadLine();
            Console.WriteLine(" ");
            string[] separation = b.Split(' ');
          
            for (int i = 0; i < separation.Length; i++)
            {
                int[] s =new int[separation.Length];
                s[i] =int.Parse((separation[i]));
               
                Console.WriteLine(land[s[i]]  );
            }
           
               
        }
    }
}