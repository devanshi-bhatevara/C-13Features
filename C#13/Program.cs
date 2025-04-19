using CSharp13;

//**************************** Escape sequence \e ****************************
EscapeSequence.Run();
Console.WriteLine();

//**************************** Implicit Index Access ****************************
ImplicitIndexAccess implicitIndexAccess = new ImplicitIndexAccess();
implicitIndexAccess.Run();
Console.WriteLine();

//**************************** Dedicated lock object ****************************
Locks.Run();
Console.WriteLine();

//****************************Params Collection****************************
ParamsCollection.Run();
Console.WriteLine();

//**************************** Search values ****************************
SearchValuesDemo.Run();
Console.WriteLine();

//**************************** UUID Generation ****************************
UUIDGeneration.Run();
Console.WriteLine();

//**************************** Tasks When Each ****************************
WhenEach.Run();

Console.ReadLine();

