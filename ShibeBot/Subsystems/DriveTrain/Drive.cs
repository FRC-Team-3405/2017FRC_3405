using System.Media;
using ShibeBot.Commands;
using ShibeBot.OperatorInteface;
using WPILib;
using WPILib.Commands;
using WPILib.SmartDashboard;

namespace ShibeBot.Subsystems.DriveTrain
{
    public class DriveTrain : Subsystem
    {
        private static readonly TalonSRX LeftPrimary = new TalonSRX(0);
        private static readonly TalonSRX RightPrimary = new TalonSRX(1);
        private static TalonSRX _leftSecondary = new TalonSRX(2);
        private static TalonSRX _rightSecondary = new TalonSRX(3);

		public RobotDrive _drive = new RobotDrive(LeftPrimary, RightPrimary);
		private int _driveSpeed;

        protected override void InitDefaultCommand()
        {
           SetDefaultCommand(new DriveCommand());
        }

        private double leftX = 0;
        private double leftY = 0;
        private double rightX = 0;
        private double rightY = 0;

		public void TankDrive(Joystick stick)
		{
		    AutoLerp(stick, 0.05);
            _drive.MaxOutput = 1 - stick.GetRawAxis(XboxMap.RightTrigger);
            _drive.TankDrive(-leftY, -rightY);
		}

        public void ArcadeDrive(Joystick stick)
        {
            AutoLerp(stick, 0.05);
            _drive.MaxOutput = 1 - stick.GetRawAxis(XboxMap.RightTrigger);
            _drive.ArcadeDrive(-leftY, -leftX);
        }

        public void DriveManually(double leftSpeed, double rightSpeed)
        {
            _drive.TankDrive(leftSpeed, rightSpeed);
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