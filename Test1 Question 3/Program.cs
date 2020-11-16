using System;


namespace Numbers
{
    class Words
    {

        private static string CapitalizeFirstWord(string sentence)

        {
            
        }
      

        static void Main(string[] args)
        {
            string inputString = “I hope you had a good weekend ?”;

            string capitalString = Words.CapitalizeFirstWord(inputString);

            Console.WriteLine(capitalString);
        }
    }

}