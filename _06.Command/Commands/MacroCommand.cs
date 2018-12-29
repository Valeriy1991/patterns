using System;
using _06.Command.Commands.Abstract;

namespace _06.Command.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = _commands.Length; i > 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}