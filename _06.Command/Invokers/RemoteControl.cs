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
        private ICommand _undoCommand;

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

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOnButton(int slot)
        {
            var command = _onCommands[slot];
            command.Execute();
            _undoCommand = command;
        }
        public void PressOffButton(int slot)
        {
            var command = _offCommands[slot];
            command.Execute();
            _undoCommand = command;
        }

        public void PressUndoButton()
        {
            _undoCommand.Undo();
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