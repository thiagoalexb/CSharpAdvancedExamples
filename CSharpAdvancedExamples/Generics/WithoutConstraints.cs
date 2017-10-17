using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedExamples.Generics
{
    //Sem restricoes para os tipos de objetos(T), pode receber qualquer objeto (int, class, object, etc)
    public class WithoutConstraints<T> 
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get => throw new NotImplementedException();
        }
    }
}
