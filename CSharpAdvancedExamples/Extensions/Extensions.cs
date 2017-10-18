using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvancedExamples.Extensions
{
    public class Extensions
    {
        //Usado para classes que nao podem ser herdadas (ex: String)
        public void UsageExtensions()
        {
            string post = "Essa é uma frase supostamente grande para um titulo de post";
            Console.WriteLine(post.Shorten(5));
        }
    }

    //Sempre static
    public static class StringExtensions
    {
        //Sempre static
        //this é a propria propriedade que esta extendendo (nesse caso uma string)
        //depois vem os parametros
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException("numberOfWords deve ser maior ou igual a zero");

            if (numberOfWords == 0) return string.Empty;

            var words = str.Split(' ');

            if (words.Length <= numberOfWords) return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
