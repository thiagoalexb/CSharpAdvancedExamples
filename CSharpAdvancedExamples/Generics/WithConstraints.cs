using CSharpAdvancedExamples.Helpers;
using System;

namespace CSharpAdvancedExamples.Generics
{
    //Tipos de restriçoes:
    //where T : iComparable (restricao para interface ou nao aplicavel para classes)
    //where T : Product (uma classe especifica)
    //where T : struct (value type: int, DateTime etc.)
    //where T : class (qualquer classe)
    //where T : new() (um objeto que tenha um construtor padrao)

    public class MaxValue<T> where T : IComparable
    {
        //Possui os métodos da interface IComparable
        public T Max(T a, T b) => a.CompareTo(b) > 0 ? a : b;
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        //Recebe a classe product e tem acesso a todos as 
        //propriedades e metodos dessa classe e suas sub classes (caso haja herança)
        public float CalculateDiscount(TProduct product) => product.Price;
    }

    public class Nullable<T> where T : struct
    {
        //Classe já existente em c#.
        //value types não podem ser nulos
        private object _value;

        public Nullable() { }

        public Nullable(T value) => _value = value;

        public bool HasValue => _value != null;

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T); //Devolve o valor padrao do tipo por ex: int retorna 0 ou bool retorno false
        }
    }

    public class Constructor<T> where T : new()
    {
        public void DoSomething(T value)
        {
            //Pode-se instanciar
            var obj = new T();
        }
    }

    //Pode-se passar mais de uma restricao
    public class MoreThenOneConstraints<T> where T : Product, new()
    {
        public void DoSomething(T value)
        {
            var product = new T();
            var price = product.Price;
        }
    }
}
