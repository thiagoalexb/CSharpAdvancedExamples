using System;

namespace CSharpAdvancedExamples.Events
{
    public class SMSService
    {
        public void OnVideoEnconded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Sending SMS..." + args.Video.Title);
        }
    }
}
