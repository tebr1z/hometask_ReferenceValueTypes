using System.Reflection;

namespace ConsoleApp19
{
    internal class Program
    {

        //Main Void
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Task 1 void


            //int[] array = { 3, -5, 8, -2, 5, -7 };

            //ConvertNegativesToPositives(ref array);

            //Console.WriteLine("Cavab: " + string.Join(", ", array));
            #endregion
            #region Task 2 Void

            //Console.WriteLine(Repeat("TT"));       
            //Console.WriteLine(Repeat("TT!", 2));    
            //Console.WriteLine(Repeat("TT!", 3));

            #endregion

            #region Task 3 Void

            //Palindrome ("aha");

            #endregion

            #region task 4 void

            //string input = "Salam DUNYA!";
            //string result = RemoveDuplicates(input);
            //Console.WriteLine(result);

            #endregion

            #region Task 5 void
            //string input = "Salam Pb301";
            //string reversed = ReverseString(input);
            //Console.WriteLine(reversed);
            #endregion

            #region Task 6 
            //    string metin = "Salam necesen pb301";
            //string word = "";

            //foreach (char car in metin)
            //{
            //    if (car != ' ')
            //    {
            //        word += car;
            //    }
            //    else
            //    {
            //        Console.WriteLine(word); 
            //            word = "";

            //        }  
            //    }


            //    Console.WriteLine(word);


            #endregion

            #region Task 8
            //string str = "Salam PB301";
            //PrintFirstFourCharacters(str);

            #endregion




        }
        //Main Void end


        #region task 1


        //static void ConvertNegativesToPositives(ref int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < 0)
        //        {
        //            array[i] *= -1;
        //        }
        //    }
        //}

        #endregion

        #region Task 2 
        //static string Repeat(string word, int count = 1)
        //{
        //    string result = "";

        //    for (int i = 0; i < count; i++)
        //    {
        //        result += word;
        //    }

        //    return result;
        //}
        #endregion

        #region Task 3
        //static void Palindrome (string word)
        //{

        //    string NewString = default;
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        NewString += word[i];
        //    }

        //    if (NewString == word)
        //    {
        //        Console.WriteLine("Palindrome`Di");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Palindrome Deyil");
        //    }
        //}

        #endregion

        #region task 4

        //static string RemoveDuplicates(string input)
        //{
        //    string result = "";

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];
        //        bool isDuplicate = false;

        //        for (int j = 0; j < result.Length; j++)
        //        {
        //            if (c == result[j])
        //            {
        //                isDuplicate = true;
        //                break;
        //            }
        //        }

        //        if (!isDuplicate)
        //        {
        //            result += c;
        //        }
        //    }

        //    return result;
        //}




        #endregion

        #region Task 5
        //static string ReverseString(string str)
        //{
        //    string reversed = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        reversed += str[i];
        //    }
        //    return reversed;
        //}
        #endregion

        //TASK 6 YUXARDADIR VOID ILE YAZLIB 7`CI  TASKI ETMEYE CALISHDIM AMMA KI, XETA ALDIGIM UCUN ELAVE ETMEDIM

        #region Task 8

        //static void PrintFirstFourCharacters (string str)
        //{

        //    int length;
        //    if (str.Length < 4)
        //    {
        //        length = str.Length;
        //    }
        //    else
        //    {
        //        length = 4;
        //    }

        //    for (int i = 0; i < length; i++)
        //    {
        //        Console.Write(str[i]);
        //    }
        //    Console.WriteLine();
        //}

    }

        #endregion











    
}



 
