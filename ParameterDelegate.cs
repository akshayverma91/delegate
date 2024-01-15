namespace DelegateProgramExample
{
    public class ParameterDelegate
    {
        public delegate void DelegateParam(string str);

        static void InvokeDelegate(DelegateParam del)
        {
            del("Hello World");
        }

        public static void CallDelegate()
        {
            DelegateParam delParam = ClassA.MethodA;
            InvokeDelegate(delParam);

            delParam = ClassB.MethodB;
            InvokeDelegate(delParam);

            delParam = (string msg) => Console.WriteLine($"Call lamda expresion: {msg}");
            InvokeDelegate(delParam);
            
        }

    }

    internal class ClassA
    {
        internal static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    internal class ClassB
    {
        internal static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}