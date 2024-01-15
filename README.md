### Anonymous function ###

An *anonymous* method is a method which doesn’t contain any name which is introduced in C# 2.0. It is useful when the user wants to create an inline method and also wants to pass parameter in the anonymous method like other methods. An Anonymous method is defined using the delegate keyword and the user can assign this method to a variable of the delegate type.

### version specific defination ###

An anonymous function is a function without a name that can be defined using the delegate keyword and can be assigned to a variable of delegate type

An anonymous function can be useful when you want to create an inline method and also want to pass parameters in the anonymous function like other methods

An anonymous function can have the following syntax
delegate (parameter_list) {
// Code
};

An example of an anonymous function is

public delegate void Print (int value);
static void Main (string[] args)
{
Print print = delegate(int val) {
Console.WriteLine ("Inside Anonymous method. Value: {0}", val);
};

print (100);
}

Output:
Inside Anonymous method. Value: 100

**Some important points about anonymous functions are**

They are also known as inline delegates.

They can create a delegate object without writing separate methods.

They can access variables defined in an outer function. Such variables are known as outer variables.

They can be passed as a parameter to a method that accepts the delegate as a parameter.

They can be used as event handlers.

Anonymous functions have some limitations, such as
They cannot contain jump statements like goto, break or continue.

They cannot access ref or out parameters of an outer method.

They cannot have or access unsafe code.

They cannot be used on the left side of the is operator.

C# 3.0 introduced the lambda expression, which also works like an anonymous function but has a more concise and expressive syntax

A lambda expression can have the following syntax

(input-parameters) => expression
// or
(input-parameters) => { <sequence-of-statements> }

An example of a lambda expression is
public delegate int Square(int num);
static void Main(string[] args)
{
Square square = x => x * x;

Console.WriteLine(square(5));
}

Output:
25


[Anonymous file reference](https://www.c-sharpcorner.com/article/advanced-features-in-c-sharp/)

[Basic of delegate](https://www.tutorialsteacher.com/csharp/csharp-delegates)

[Delegate as parameter](https://www.delftstack.com/howto/csharp/how-to-pass-a-method-as-a-parameter-in-csharp/)