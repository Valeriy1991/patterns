using _06.Command.Commands.Abstract;
using _06.Command.Receivers;

namespace _06.Command.Commands
{
    public class LightsOnCommand : ICommand
    {
        private readonly Light _light;

        public LightsOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}