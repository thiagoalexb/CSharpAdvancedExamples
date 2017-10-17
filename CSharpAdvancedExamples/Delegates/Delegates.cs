using CSharpAdvancedExamples.Helpers;
using System;

namespace CSharpAdvancedExamples.Delegates
{
    //Delegate é um objeto que sabe como chamar um método ou um grupo de métodos
    //é a referencia ou um ponteiro para uma função
    //Usado para deixar softwares mais extensiveis e flexiveis
    public class Delegates
    {
        //Handler após o nome do método é uma convenção da MS
        //Pode se usar declarando como na linha abaixo ou usar o Action(nao retorna nada) ou o Func(retorna algo)
        //public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }

        public void UsageDelegate()
        {
            var filters = new PhotoFilter();
            //Se nao usar o action usaria:
            //PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;//necessario usar p += e nao usa o ()
            filterHandler += filters.Resize;
            filterHandler += AnotherFilter;

            Process("photox.jpg", filterHandler);
        }

        //Posso criar outros filtros sem alterar outras classes e mandar para o delegates
        //Método precisam seguir a mesma assinatura do delegate (retorno e parametros)
        //Isso o torna extensivel
        public void AnotherFilter(Photo photo)
        {
            System.Console.WriteLine("Custom Filter");
        }
    }
}
