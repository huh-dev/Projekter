﻿global using Types;

namespace Types
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Code setup
            Code code = new Code(
                @"C# is a strongly typed language. 
                Every variable and constant has a type, as does every expression that evaluates to a value. 
                Every method declaration specifies a name, the type and kind (value, reference, or output) 
                for each input parameter and for the return value. 
                The .NET class library defines built-in numeric types and complex types that represent 
                a wide variety of constructs. These include the file system, network connections, 
                collections and arrays of objects, and dates. 
                A typical C# program uses types from the class library and user-defined types that model 
                the concepts that are specific to the program's problem domain.
                ");
            Console.WriteLine(code.count);
        }
    }
}
