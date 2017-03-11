using ShibeBot.Commands;
using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Lifter
{
    public class Lifter : Subsystem
    {
		// Change this thing later
		private static VictorSP LifterMotor = new VictorSP(0);
        protected override void InitDefaultCommand()
        {
            SetDefaultCommand(new ClimbCommand());
        }

		public void Climb(Joystick stick) {

			double max = 1 - stick.GetRawAxis(XboxMap.RightTrigger);
			LifterMotor.Set((max) * stick.GetRawAxis(XboxMap.LeftTrigger));

		}
    }
}