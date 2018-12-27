using System.Text;
using _06.Command.Commands;
using _06.Command.Commands.Abstract;

namespace _06.Command.Invokers
{
    public class RemoteControl
    {
        public const int MaxCommandsCount = 7;

        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[MaxCommandsCount];
            _offCommands = new ICommand[MaxCommandsCount];

            var noCommand = new NoCommand();
            for (int i = 0; i < MaxCommandsCount; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOnButton(int slot)
        {
            _onCommands[slot].Execute();
        }
        public void PressOffButton(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var messageBuilder = new StringBuilder();
            messageBuilder.Append("\n----- Remote control -----\n");
            for (int i = 0; i < MaxCommandsCount; i++)
            {
                messageBuilder.Append(
                    $"[slot {i}] on: {_onCommands[i].GetType().Name}   off: {_offCommands[i].GetType().Name}");
                messageBuilder.AppendLine();
            }

            return messageBuilder.ToString();
        }
    }
}