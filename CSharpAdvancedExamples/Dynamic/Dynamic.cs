using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedExamples.Dynamic
{
    public class Dynamic
    {
        //Dynamic só ve o tipo da propriedade, metodo etc quando o projeto esta rodando (run-time)
        //Como se fosse uma variavel em javascript
        public void UsageDynamic()
        {
            dynamic name = "Thiago"; //Aqui é uma string em run-time
            //name++ Vai dar erro porque ainda é uma string, mas só em tempo de execução
            name = 10; //Aqui se torna um int
        }
        
    }
}
