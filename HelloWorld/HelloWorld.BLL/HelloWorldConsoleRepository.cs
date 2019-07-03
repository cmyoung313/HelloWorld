using System;
using HelloWorld.DAL;

namespace HelloWorld.BLL
{
    public class HelloWorldConsoleRepository : IHelloWorldRepository
    {
        private IHelloWorldData _helloWorldData;
        
        public HelloWorldConsoleRepository()
        {
            _helloWorldData = new DAL.HelloWorldData();
        }

        public HelloWorldConsoleRepository(IHelloWorldData helloWorldData)
        {
            _helloWorldData = helloWorldData;
        }

        public string Write()
        {
            Console.WriteLine(_helloWorldData.GetOutputString());
            return _helloWorldData.GetOutputString();
        }
    }
}
