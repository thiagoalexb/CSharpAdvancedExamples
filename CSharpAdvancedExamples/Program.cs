using CSharpAdvancedExamples.Events;
using CSharpAdvancedExamples.Helpers;
using System;

namespace CSharpAdvancedExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var generics = new Generics.Generics();
            generics.UsageGerericsWithoutConstraints();
            generics.UsageGerericsWithConstraints();

            var delegates = new Delegates.Delegates();
            delegates.UsageDelegate();

            var lambda = new LambdaExpressions.LambdaExpressions();
            lambda.Lambdas();

            var video = new Video { Title = "Test" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var smsService = new SMSService();//subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEnconded;//Assinando o evento
            videoEncoder.VideoEncoded += smsService.OnVideoEnconded;//Assinando o evento

            videoEncoder.Encode(video);

            Console.Read();
        }
    }
}