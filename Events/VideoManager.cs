using System;
using System.Threading;

namespace Events
{
    public class Video
    {
        public string Name;
    }

    public class VideoArgs : EventArgs
    {
        public Video Video;
    }
    public class VideoManager
    {
        //1. Create a delegate
        //2. Create an event based on the delegate
        //3. Raise an event.
        public delegate void EventOccuredHandler(object sender, VideoArgs eventArgs);

        public event EventOccuredHandler OnEncodingCompletion;

        public void EncodeVideo()
        {
            Console.WriteLine("Encoding the video started");
            Thread.Sleep(2000);
            Console.WriteLine("Encoding the video is complete");
            OnEncodingCompletion(this, new VideoArgs() {  Video = new Video { Name = "C# Video" } });
        }

    }
}
