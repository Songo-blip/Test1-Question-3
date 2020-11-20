using System;


namespace Numbers
{
    class Words
    {

        public static string CapitalizeFirstWord(string sentence)
          
            {
                
                sentence = sentence.ToLower();
                char[] array = sentence.ToCharArray();
             
                if (array.Length >= 1)
                {
                    if (char.IsLower(array[0]))
                    {
                        array[0] = char.ToUpper(array[0]);
                    }
                }
               
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        if (char.IsLower(array[i]))
                        {
                            array[i] = char.ToUpper(array[i]);
                        }
                    }
                }
                return new string(array);
            }
        
   

     static void Main(string[] args)
        {
            string inputString = ("I hope you had a good weekend?");

            string capitalString = Words.CapitalizeFirstWord(inputString);

            Console.WriteLine(capitalString);
        }
    }

}
