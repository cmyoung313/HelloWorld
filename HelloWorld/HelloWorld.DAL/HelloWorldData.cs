namespace HelloWorld.DAL
{
    public class HelloWorldData: IHelloWorldData
    {
        private const string OutputString = "Hello Wolrd!";

        public string GetOutputString()
        {
            return OutputString;
        }
    }
}
