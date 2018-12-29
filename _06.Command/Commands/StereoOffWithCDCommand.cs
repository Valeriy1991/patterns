using _06.Command.Commands.Abstract;
using _06.Command.Receivers;

namespace _06.Command.Commands
{
    public class StereoOffWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }
}