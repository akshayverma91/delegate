namespace DelegateProgramExample
{
    public class FuncDelegate
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        public static void CallFuncDelegate()
        {
            Func<int, int, int> del = Sum;
            Console.WriteLine($"Func delegate result: {del(1,2)}");
        }

        public static void CallFuncDelegateWithAnonymousMethod()
        {
            Func<int, int, int> del = delegate(int x, int y)
            {
                return x + y;
            };
            Console.WriteLine($"Func delegate With Anonymous Method result: {del(1,2)}");
        }

        public static void CallFuncDelegateWithLamdaExpression()
        {
            Func<int, int, int> del = (int x, int y) => x + y;
            Console.WriteLine($"Func delegate With Lamda Expression: {del(1,2)}");
        }
    }

    public class ActionDelegate
    {
        static void PrintText(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void CallActionDelegate()
        {
            Action<string> del = PrintText;
            // another way to call delegate
            // Action<string> del2 = new Action<string>(PrintText);
            // del2("Action delegate");
            del("Action delegate");
        }

        public static void CallActionDelegateWithAnonymousMethod()
        {
            Action<string> del = delegate(string str)
            {
                Console.WriteLine($"{str}");
            };
            del("Action delegate with anonymous method");
        }

        public static void CallActionDelegateWithLamdaExpression()
        {
            Action<string> del = (string str) => Console.WriteLine($"{str}");
            del("Action delegate with lamda expression");
        }
    }
    
    public class PredicateDelegate
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        public static void CallPredicateDelegate()
        {
            Predicate<string> del = IsUpperCase;
            bool result = IsUpperCase("HELLO");
            Console.WriteLine($"Predicate Delegate result: {result}");
        }

        public static void CallPredicateDelegateWithAnonymousMethod()
        {
            Predicate<string> del = delegate(string str)
            {
                return str.Equals(str.ToUpper());
            };
            bool result = del("HELLO");
            Console.WriteLine($"Predicate AnonymousMethod result: {result}");
        }
        
        public static void CallPredicateDelegateWithLamdaExpression()
        {
            Predicate<string> del = (string str) => str.Equals(str.ToUpper());
            bool result = del("HELLO");
            Console.WriteLine($"Predicate LamdaExpression result: {result}");
        }
    }
}