using _06.Command.Commands.Abstract;

namespace _06.Command.Invokers
{
    public class SimpleRemoteControl
    {
        private ICommand _command;

        public SimpleRemoteControl()
        {
            
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressTheButton()
        {
            _command.Execute();
        }
    }
}