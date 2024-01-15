// https://www.c-sharpcorner.com/article/advanced-features-in-c-sharp/

namespace DelegateProgramExample
{
    // Using delegate with a standard function
    public class DelegateWithStandardFunction
    {
        delegate void CountNumber();

        public static void CallDelegate()
        {
            CountNumber countDel = Count;
            countDel();
        }
        public static void Count()
        { 
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"DelegateWithStandardFunction loop: {i}");
            }
        }
    }

    // Using delegate as an anonymous method 
    public class DelegateWithAnonymousMethod
    {
        delegate void CountNumber();
        
        public static void CallDelegate()
        {
            CountNumber countNumberDel = delegate()
            {
                for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"DelegateWithAnonymousFunction loop: {i}");
            }
            };  
            countNumberDel();
        }
    }

    // delegate using Lamda expression
    public class DelegateWithLamdaExpression
    {
        delegate int CountTotal(int x);
        public static void CallDelegate()
        {
            CountTotal expressionLambda = (int x) => Enumerable.Range(1, x).Aggregate(0, (acc, y) => acc + y);
            Console.WriteLine($"DelegateWithLamdaExpression Total Count upto x integer: {expressionLambda(10)}");
        }
    }
    
    // delegate using Lamda statement
    public class DelegateWithLamdaStatement
    {
        delegate int CountTotal(int x);
        public static void CallDelegate()
        {
            CountTotal calculateSum = (int x) => 
            {
                int sum = 0;
            for (int i = 0; i < x; i++)
            sum += i;
            return sum;
            };
            Console.WriteLine($"DelegateWithLamdaStatement Total Sum upto x integer: {calculateSum(10)}");
        }
    }
}
