using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;
using System;
using System.Threading;

namespace ShibeBot.Subsystems.Thrower
{
    public class Thrower : Subsystem
    {
        private static readonly ISpeedController Left = new Talon(RobotMap.ThrowerLeft);
        private static readonly ISpeedController Right = new Talon(RobotMap.ThrowerRight);
		private static readonly ISpeedController Loader = new Talon(RobotMap.ThrowerLoader);
        private static readonly Encoder LeftEncoder = new Encoder(RobotMap.ThrowerLeftQuadratureA, RobotMap.ThrowerLeftQuadratureB);
        private static readonly Encoder RightEncoder = new Encoder(RobotMap.ThrowerRightQuadratureA, RobotMap.ThrowerRightQuadratureB);
		private static readonly AnalogOutput AngleOutput = new AnalogOutput(RobotMap.ThrowerAngle);
        private static readonly AnalogPotentiometer Angle = new AnalogPotentiometer(RobotMap.ThrowerAngle, 360);

		// Speed constant

		private double _left = 1;
		private double _right = 1;

		public Thrower() 
		{
			Loader.Set(-.5);
		}


        protected override void InitDefaultCommand()
        {
            
        }

		//public void Throw(Joystick controller)
		//{
		//	double leftRate = LeftEncoder.GetRate();
		//	double rightRate = RightEncoder.GetRate();

		//	if (leftRate > rightRate)
		//	{
		//		// Decrement left side
		//	}
		//	else if (leftRate < rightRate) 
		//	{
		//		// Decrement right side
		//	}

		//	Right.Set(_right);
		//	Left.Set(_left);
		//}

		public void CalcAngle(double distance, double height)
		{
			double angle = Math.Atan2(height, distance);
			double distanceToTurn = (Angle.Get() - angle) / 360;
            AngleOutput.SetVoltage(distanceToTurn);
		}

		public void Throw() { 
			Left.Set(1);
			Right.Set(1);
			Thread.Sleep(200);
			Loader.Set(1);
		}

		public void StopThrowing() 
		{
			Left.Set(0);
			Right.Set(0);
			Loader.Set(-1);
		}
    }
}