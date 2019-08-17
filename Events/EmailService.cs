using System;

namespace Events
{
    public class EmailService
    {
        public void EventOccuredHandler(object sender, VideoArgs eventArgs)
        {
            Console.WriteLine($" {eventArgs.Video.Name} video Email has been sent successfully");
        }
    }
   
}
