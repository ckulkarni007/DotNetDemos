using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            VideoManager videoManager = new VideoManager();
            EmailService emailSender = new EmailService();
          
            videoManager.OnEncodingCompletion += emailSender.EventOccuredHandler;

            videoManager.EncodeVideo();
            Console.ReadLine();

        }
    }
   
}
