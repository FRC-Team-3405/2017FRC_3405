using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Thrower
{
    public class Thrower : Subsystem
    {
        //private static readonly ISpeedController _left = RobotMap.ThrowerLeft;
        //private static readonly ISpeedController _right = RobotMap.ThrowerRight;
        private static Encoder _leftEncoder = RobotMap.ThrowerLeftQuadrature;
        private static Encoder _rightEncoder = RobotMap.ThrowerRightQuadrature;
        private static AnalogPotentiometer _angle = RobotMap.ThrowerAngle;

		// Speed constant

		private const double Speed = 512;

		// Are we throwing?


        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }

		public void StartThrowing(ref Joystick controller)
		{
			if (controller.GetTrigger())
			{
				//_right.Set(Speed);
				//_left.Set(Speed);
			}
			else {
				//_right.Set(0);
				//_left.Set(0);
			}
		}

    }
}