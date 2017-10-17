using System;

namespace CSharpAdvancedExamples.Events
{
    public class MailService
    {
        public void OnVideoEnconded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Sending email..." + args.Video.Title);
        }
    }
}
