using System;

namespace merg.cbus
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("This is the C# CbusDefs solution.");
            Console.WriteLine("It contains the T4 templates to generate the .NET files from the cbusdefs data.");
            Console.WriteLine("Simply compiling it should be enough to generate the necessary files.");
            Console.WriteLine("Those files can then be added to your .NET project.");
            Console.WriteLine("See https://docs.microsoft.com/en-us/visualstudio/modeling/code-generation-and-t4-text-templates?view=vs-2019");
            Console.WriteLine();
            Console.WriteLine("Press <enter> to close.");
            Console.ReadLine();
		}
	}
}
