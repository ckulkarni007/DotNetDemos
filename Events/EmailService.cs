using System;

namespace Events
{
    public class EmailService
    {
        public void EventOccuredHandler(object sender, VideoArgs eventArgs)
        {
            Console.WriteLine($" {eventArgs.Video.Name} ideo Email has been sent successfully");
        }
    }
   
}
