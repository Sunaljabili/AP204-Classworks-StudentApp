using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qrup adini daxil edin: 2 boyuk herif 3 reqem olmalidir.");
            string groupNO = Console.ReadLine();
             while (!(groupNO.Length==5 && char.IsUpper(groupNO[0]) && char.IsUpper(groupNO[1]) && char.IsDigit(groupNO[2])&& char.IsDigit(groupNO[3]) && char.IsDigit(groupNO[4])))
             {
                Console.WriteLine("Qrup adini daxil edin: 2 boyuk herif 3 reqem olmalidir.");
                groupNO = Console.ReadLine();
             }
            Console.WriteLine("Qrupun max Telebe limitini  daxil edin 0-20 arasi");
            int groupLimit = Convert.ToInt32(Console.ReadLine());
            while (!(groupLimit > 0 && groupLimit < 20 ))
            {
                Console.WriteLine("Qrupun max Telebe limitini  daxil edin 0-20 arasi");
                groupLimit = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
