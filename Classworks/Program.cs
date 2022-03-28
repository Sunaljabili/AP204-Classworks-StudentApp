using System;

namespace Classworks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-4
            //string sentence = Console.ReadLine();
            //Console.WriteLine(newsentence(sentence));
            #endregion

            #region Task-2
            //Console.WriteLine(Check());
            #endregion

            #region Task-3
            //v1.1
            //FirstWord("Salam dostlar");
            //v1.2
            //info();

            #endregion

            #region Task-5
            //int[] array = { 1, 3, 5, 7, 9 };
            //int number = 10;
            //AddNumber(ref array, number);
            #endregion

            #region Task-1
            //Console.WriteLine("Bir cumle elave edin");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(MakeSentence(ref sentence)); 
            #endregion


        }

        #region Task-2
        //  2. Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini(bool) qaytaran metod
        //- İçində ən az 1 rəqəm olmalıdır
        //- İçində ən az 1 böyük hərf olmalıdır
        //- İçində ən az 1 kiçik hərf olmalıdır

        //public static bool Check()
        //{
        //    string sentence = "Bahadur123";

        //    bool hasDigit = false;
        //    bool hasUpper = false;
        //    bool hasLower = false;

        //    foreach (var item in sentence)
        //    {
        //        if (char.IsDigit(item))
        //        {
        //            hasDigit = true;
        //            continue;
        //        }
        //        if (char.IsUpper(item))
        //        {
        //            hasUpper = true;
        //            continue;
        //        }
        //        if (char.IsLower(item))
        //        {
        //            hasLower = true;
        //        }

        //    }
        //    bool result = hasDigit && hasUpper && hasLower;
        //    return result;
        //}
        #endregion

        #region Task-3
        //3. Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod
        //version-1.1
        //public static void FirstWord(string sentence)
        //{
        //    Console.WriteLine(sentence.Substring(0,sentence.IndexOf(' ')));
        //}
        //version 1.2
        //public static void info()
        //{
        //    string phrase = "Salam dunya";
        //    string[] word = phrase.Split();

        //    foreach (var item in word)
        //    {
        //        Console.WriteLine(item);
        //        break;
        //    }
        //}
        #endregion

        #region Task-4
        //4.Verilmiş string dəyərin içərisində 2 söz olmasını və hər
        //bir sözün böyük hərflə başlamasını yoxlayan metod

        //public static bool newsentence(string sentence)
        //{
        //    bool check = false;
        //    bool bigfirstsentence = false;
        //    bool bigsecondsentence = false;
        //    string[] stArr = sentence.Split();
        //    if (stArr.Length == 2)
        //    {
        //        string firstsentence = stArr[0];
        //        string secondsentence = stArr[1];
        //        if (firstsentence[0] == char.ToUpper(firstsentence[0]))
        //        {
        //            bigfirstsentence = true;

        //        }
        //        if (secondsentence[0] == char.ToUpper(secondsentence[0]))
        //        {
        //            bigsecondsentence = true;

        //        }
        //    }
        //    check = bigsecondsentence && bigfirstsentence;
        //    return check;

        #endregion

        #region Task-5
        //5. Parameter olaraq integer array variable-ı(reference) və bir integer value qəbul edən və
        //   həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.

        public static void AddNumber(ref int[] array,int number)
        {

            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        #endregion

        #region Task-1
        //public static string MakeSentence(ref string str)
        //{
        //    string newStr = "";

        //    for (int i = 0; i < str.Length; i++)
        //    {

        //        if (str[i] != ' ' || (newStr[newStr.Length - 1] != ' '))
        //        {
        //            newStr += str[i];

        //        }
        //    }
        //    str = newStr;
        //    return str;

        //}
        #endregion



    }
}
