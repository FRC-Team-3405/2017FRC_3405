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

		private double _left = 1;
		private double _right = 1;

		// Are we throwing?


        protected override void InitDefaultCommand()
        {
            
        }

		public void Throw(Joystick controller)
		{
			double leftRate = LeftEncoder.GetRate();
			double rightRate = RightEncoder.GetRate();

			if (leftRate > rightRate)
			{
				// Decrement left side
			}
			else if (leftRate < rightRate) 
			{
				// Decrement right side
			}

			Right.Set(_right);
			Left.Set(_left);
		}

    }
}