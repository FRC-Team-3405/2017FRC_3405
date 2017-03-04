using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Thrower
{
    public class Thrower : Subsystem
    {
        private static ISpeedController left = RobotMap.ThrowerLeft;
        private static ISpeedController right = RobotMap.ThrowerRight;
        private static Encoder leftEncoder = RobotMap.ThrowerLeftQuadrature;
        private static Encoder rightEncoder = RobotMap.ThrowerRightQuadrature;
        private static AnalogPotentiometer angle = RobotMap.ThrowerAngle;

		// Speed constant

		private const double speed = 512;

		// Are we throwing?


        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }

		public void startThrowing(ref Joystick controller)
		{
			if (controller.GetTrigger())
			{
				right.Set(speed);
				left.Set(speed);
			}
			else {
				right.Set(0);
				left.Set(0);
			}
		}

    }
}