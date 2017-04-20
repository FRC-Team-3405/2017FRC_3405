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

		protected override void InitDefaultCommand()
		{
			SetDefaultCommand(new DriveCommand());
		}


		public void Drive(Joystick stick)
		{
			_drive.MecanumDrive_Cartesian(stick.GetX(), stick.GetY(), 1);
		}

    }
}