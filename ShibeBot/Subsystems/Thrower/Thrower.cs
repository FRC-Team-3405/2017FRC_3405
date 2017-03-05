using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Thrower
{
    public class Thrower : Subsystem
    {
        private static readonly ISpeedController Left = new Talon(RobotMap.ThrowerLeft);
        private static readonly ISpeedController Right = new Talon(RobotMap.ThrowerRight);
        private static readonly Encoder LeftEncoder = new Encoder(RobotMap.ThrowerLeftQuadratureA, RobotMap.ThrowerLeftQuadratureB);
        private static readonly Encoder RightEncoder = new Encoder(RobotMap.ThrowerRightQuadratureA, RobotMap.ThrowerRightQuadratureB);
        private static readonly AnalogPotentiometer Angle = new AnalogPotentiometer(RobotMap.ThrowerAngle);

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