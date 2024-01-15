namespace DelegateProgramExample
{
    public class MulticastDelegate
    {
        public delegate void DelegateMulticast(string msg);

        public static void CallDelegate()
        {
            DelegateMulticast delMulti1 = ClassA.MethodA;
            DelegateMulticast delMulti2 = ClassB.MethodB;

            DelegateMulticast delMulti = delMulti1 + delMulti2;
            delMulti("Hello World"); 

            DelegateMulticast delMulti3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            delMulti += delMulti3;
            delMulti("Hello World");

            delMulti = delMulti - delMulti2;

            delMulti -= delMulti1;

            delMulti("Hello World");
            
        }
    }
}