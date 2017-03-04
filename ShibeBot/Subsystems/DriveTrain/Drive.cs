using WPILib;
using WPILib.Commands;

namespace ShibeBot.Subsystems.DriveTrain
{
    public class DriveTrain : Subsystem
    {
		static RobotDrive drive = RobotMap.DriveTrain;
		private int driveSpeed;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }

		public void tankDrive(ref Joystick stick) 
		{
			Scheduler.Instance.Run();

			drive.MaxOutput = 1;

			drive.ArcadeDrive(stick.GetY(), -stick.GetX());
		}
    }
}