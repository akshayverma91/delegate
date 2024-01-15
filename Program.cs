// See https://aka.ms/new-console-template for more information
using DelegateProgramExample;

Console.WriteLine("Delegate examples:");

// Delegateusing Standard function
DelegateWithStandardFunction.CallDelegate();

// Delegateusing Anonymous method
DelegateWithAnonymousMethod.CallDelegate();

// Delegate Lamda Expression
DelegateWithLamdaExpression.CallDelegate();

// Delegate Lamda statment
DelegateWithLamdaStatement.CallDelegate();

// Passing Delegate as parameter
ParameterDelegate.CallDelegate();

// Multicast delegate
DelegateProgramExample.MulticastDelegate.CallDelegate();

// Build In delegate

// FuncDelegate
FuncDelegate.CallFuncDelegate();
FuncDelegate.CallFuncDelegateWithAnonymousMethod();
FuncDelegate.CallFuncDelegateWithLamdaExpression();

// ActionDelegate
ActionDelegate.CallActionDelegate();
ActionDelegate.CallActionDelegateWithAnonymousMethod();
ActionDelegate.CallActionDelegateWithLamdaExpression();

// Predicate Delegate
PredicateDelegate.CallPredicateDelegate();
PredicateDelegate.CallPredicateDelegateWithAnonymousMethod();
PredicateDelegate.CallPredicateDelegateWithLamdaExpression();

