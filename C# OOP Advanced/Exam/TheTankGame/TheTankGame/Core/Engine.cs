namespace TheTankGame.Core
{
    using Contracts;
    using IO.Contracts;
    using System.Linq;

    public class Engine : IEngine
    {
        private bool isRunning;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(
            IReader reader, 
            IWriter writer, 
            ICommandInterpreter commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;

            this.isRunning = false;
        }

        public void Run()
        {
            this.isRunning = true;

            while (this.isRunning)
            {
                var input = reader.ReadLine();
                var args = input.Split().ToList();
                var output = this.commandInterpreter.ProcessInput(args);

                if (input == "Terminate")
                {
                    this.isRunning = false;
                }

                writer.WriteLine(output);
            }
        }
    }
}