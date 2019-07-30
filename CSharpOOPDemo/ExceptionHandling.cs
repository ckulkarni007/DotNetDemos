using System;
using System.IO;
namespace CSharpOOPDemo
{
    class ExceptionHandling
    {
        public static void Main()
        {
            

            try
            {
                string[] collection = new string[5];
                collection[0] = "Chiatnaya";
                collection[1] = "Chiatnaya";
                collection[2] = "Chiatnaya";
                collection[3] = "Chiatnaya";
                collection[4] = null;

                int operator1 = 20;
                for (int i = 0; i < collection.Length; i++)
                {
                    var temp = collection[i] ?? string.Empty;

                    Console.WriteLine(temp);


                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("divide by zero occured");
            }           
            catch (IndexOutOfRangeException ex)
            {
                
            }
            catch (Exception)
            {

            }

            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader("C:\\NonExistingFile.txt");
            //    Console.WriteLine(streamReader.ReadToEnd());
            //}
            //// This catch block handles only FileNotFoundException
            ////catch (FileNotFoundException fileNotFoundException)
            ////{
            ////    Console.WriteLine("Please check if the file \"{0}\" is present", fileNotFoundException.FileName);
            ////}
            ////// This catch block handles all the other exceptions
            //catch (FileNotFoundException exception)
            //{
                 
            //}
            //finally
            //{
            //    if (streamReader != null)
            //    {
            //        streamReader.Close();
            //    }
            //}
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string name)
        {
            if(name != "Chaitanya")
            {
                throw new Exception(name);
            }
        }
    }
}