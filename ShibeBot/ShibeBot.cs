using System.Threading;
using WPILib;
using WPILib.Commands;
using WPILib.LiveWindow;
using ShibeBot.Subsystems.DriveTrain;
using CSCore;
using OpenCvSharp;

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
