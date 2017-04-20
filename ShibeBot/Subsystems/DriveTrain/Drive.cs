using System.Media;
using ShibeBot.Commands;
using ShibeBot.OperatorInteface;
using CTRE;
using WPILib;
using WPILib.Commands;
using WPILib.SmartDashboard;

namespace ShibeBot.Subsystems.DriveTrain
{
    public class DriveTrain : Subsystem
    {
		
		private static readonly Talon LeftPrimary = new Talon(0);
        private static readonly Talon RightPrimary = new Talon(1);
        private static readonly Talon LeftSecondary = new Talon(2);
		private static readonly Talon RightSecondary = new Talon(3);

		public RobotDrive _drive = new RobotDrive(LeftPrimary, LeftSecondary, RightPrimary, LeftSecondary);
		private int _driveSpeed;

        protected override void InitDefaultCommand()
        {
           SetDefaultCommand(new DriveCommand());
        }

        private double leftX = 0;
        private double leftY = 0;
        private double rightX = 0;
        private double rightY = 0;

		public void Drive(Joystick stick)
		{
			_drive.MecanumDrive_Cartesian(stick.GetX(), stick.GetY(), 1);
		}

        private void AutoLerp(Joystick stick, double amount)
        {
            leftX = Lerp(leftX, stick.GetRawAxis(XboxMap.LeftX), amount);
            leftY = Lerp(leftY, stick.GetRawAxis(XboxMap.LeftY), amount);
            rightX = Lerp(rightX, stick.GetRawAxis(XboxMap.RightX), amount);
            rightY = Lerp(rightY, stick.GetRawAxis(XboxMap.RightY), amount);
            SmartDashboard.PutNumber("Left X", leftX);
            SmartDashboard.PutNumber("Left Y", leftY);
            SmartDashboard.PutNumber("Right X", rightX);
            SmartDashboard.PutNumber("Right Y", rightY);
        }

        private double Lerp(double first, double second, double amount)
        {
            return (1 - amount) * first + amount * second;
        }
    }
}