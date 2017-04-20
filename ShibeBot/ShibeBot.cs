using WPILib;
using WPILib.Commands;
using WPILib.LiveWindow;
using ShibeBot.Subsystems.DriveTrain;
using CSCore;

namespace ShibeBot
{
    public class ShibeBot : IterativeRobot
    {
        public static Oi Oi;

        public static DriveTrain DriveTrain = new DriveTrain();

        public override void RobotInit()
        {
            Oi = new Oi();
			UsbCamera camera = CameraServer.Instance.StartAutomaticCapture();
			camera.SetResolution(640, 480);
			// Get a CvSink. This will capture Mats from the Camera
			CvSink cvSink = CameraServer.Instance.GetVideo();
			// Setup a CvSource. This will send images back to the dashboard
			CvSource outputStream = CameraServer.Instance.PutVideo("Rectangle", 640, 480);
        }

        public override void DisabledPeriodic()
        {
            Scheduler.Instance.Run();
        }

        public override void AutonomousInit()
        {
        }

        public override void AutonomousPeriodic()
        {
            Scheduler.Instance.Run();
        }

        public override void TeleopInit()
        {
        }

        public override void DisabledInit()
        {

        }

        private double flot = 0;
        public override void TeleopPeriodic()
        {
            Scheduler.Instance.Run();
            Joystick stick = Oi.Pilot;
            //train._drive.ArcadeDrive(1, 1);

            stick.SetRumble(RumbleType.LeftRumble, stick.GetRawAxis(XboxMap.LeftTrigger));
            stick.SetRumble(RumbleType.RightRumble, stick.GetRawAxis(XboxMap.RightTrigger));


        }

        public override void TestPeriodic()
        {
            LiveWindow.Run();
        }
    }
}
