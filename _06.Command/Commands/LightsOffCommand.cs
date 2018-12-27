using _06.Command.Commands.Abstract;
using _06.Command.Receivers;

namespace _06.Command.Commands
{
    public class LightsOffCommand : ICommand
    {
        private readonly Light _light;

        public LightsOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}