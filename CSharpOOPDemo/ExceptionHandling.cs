using System;
using System.IO;
namespace CSharpOOPDemo
{
    class ExceptionHandling
    {
        public static void Main()
        {
            StreamReader streamReader = null;
            try
            {
                // This line will throw FileNotFoundException
                streamReader = new StreamReader("C:\\NonExistingFile.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            // This catch block handles only FileNotFoundException
            catch (FileNotFoundException fileNotFoundException)
            {
                // Log or email the exception
                // Code to log or email exception details


                // Display meaningful error message to the end user
                Console.WriteLine("Please check if the file \"{0}\" is present", fileNotFoundException.FileName);
            }
            // This catch block handles all the other exceptions
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}