using System;
using System.Linq;
using System.Runtime.Versioning;
using System.Reflection;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine($".NET CLR Version: {Environment.Version}");

            var targetFramework = Assembly.GetExecutingAssembly()
                .GetCustomAttributes(typeof(TargetFrameworkAttribute), false)
                .OfType<TargetFrameworkAttribute>()
                .FirstOrDefault()?.FrameworkName;

            Console.WriteLine($"Target Framework: {targetFramework}");
        }
    }
}