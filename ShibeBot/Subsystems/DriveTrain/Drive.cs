using ShibeBot.Commands;
using WPILib;
using WPILib.Commands;

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

		public void TankDrive(Joystick joystick) 
		{
			_drive.MaxOutput = 1 - joystick.GetRawAxis(XboxMap.RightTrigger);

			_drive.ArcadeDrive(joystick.GetY(), -joystick.GetX());
		}
    }
}