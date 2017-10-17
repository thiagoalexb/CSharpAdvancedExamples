using CSharpAdvancedExamples.Helpers;
using System;
using System.Threading;

namespace CSharpAdvancedExamples.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1 - Definir um delegate ( EventHandler<VideoEventArgs> )
        //2 - Definir um evento baseado no delegate
        //3 - Criar o evento

        //2 - Definir um evento baseado no delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Enconding Video...");
            Thread.Sleep(3000);

            OnVideoEnconded(video);
        }

        //3 - Criar o evento
        //Convenções: protected, virtual e void. Nome: Começando com On
        protected virtual void OnVideoEnconded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
