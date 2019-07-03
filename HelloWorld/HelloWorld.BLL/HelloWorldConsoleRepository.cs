using System;

namespace HelloWorld.BLL
{
    public class HelloWorldConsoleRepository : IHelloWorldRepository
    {
        public void Write()
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }
}
