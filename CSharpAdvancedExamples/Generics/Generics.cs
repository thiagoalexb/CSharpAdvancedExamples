using CSharpAdvancedExamples.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedExamples.Generics
{

    public class Generics
    {
        public void UsageGerericsWithoutConstraints()
        {
            var numbers = new WithoutConstraints<int>();
            numbers.Add(10);
            //var number = numbers[0];

            var books = new WithoutConstraints<Book>();
            books.Add(new Book());
        }

        public void UsageGerericsWithConstraints()
        {
            var max = new MaxValue<int>();
            var bigger = max.Max(2, 3);

            var getDiscount = new DiscountCalculator<Product>();
            var discount = getDiscount.CalculateDiscount(new Product());

            var number = new Nullable<int>();
            var hasValue = number.HasValue; //false

            var number1 = new Nullable<int>(3);
            var hasValue1 = number1.HasValue;//true
        }
    }
}
