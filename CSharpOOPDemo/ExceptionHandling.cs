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
                Test();
            }
            catch (Exception ex)
            {

                throw;
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

        private static void Test()
        {
            try
            {
                int[] collection = new int[5];
                collection[0] = 1;
                collection[1] = 1;
                collection[2] = 1;
                collection[3] = 1;
                collection[4] = 0;

                int operator1 = 20;
                for (int i = 0; i < collection.Length; i++)
                {
                    var temp = collection[i];
                    Console.WriteLine(operator1 / temp);


                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Exception exception = new Exception("exception", ex);
                throw exception;
            }
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (Exception)
            {

            }
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