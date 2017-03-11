using CSCore;
using OpenCvSharp;
using NetworkTables;
﻿using WPILib;
using WPILib.Commands;
using WPILib.LiveWindow;
using WPILib.SmartDashboard;
using ShibeBot.Commands;
using ShibeBot.Subsystems.DriveTrain;
using ShibeBot.Subsystems.Pneumatics;
using ShibeBot.Subsystems.Reporting;
using System.Threading;
using ShibeBot.Subsystems.Lifter;

namespace ShibeBot
{
    public class ShibeBot : IterativeRobot
    {
        public static Oi Oi;

        private const string CameraAddress = "axis-camera.local";

        public static DriveTrain DriveTrain = new DriveTrain();
        public static Pneumatics Pnuematics = new Pneumatics();
		public static Lifter Lifter = new Lifter();

        public static CameraServer CameraServer = CameraServer.Instance;

        //Reporting Subsystems (Requires Update!)
        public static Air Air = new Air();
        public static Match Match = new Match();
        public static Power Power = new Power();

		Command autonomousCommand;
		SendableChooser chooser;

        public override void RobotInit()
        {
            Oi = new Oi();
            Thread CameraThread = new Thread(() =>
			{
				UsbCamera camera = CameraServer.Instance.StartAutomaticCapture();
				camera.SetResolution(640, 480);

				CvSink CvSink = CameraServer.Instance.GetVideo();
				CvSource CvSource = CameraServer.Instance.PutVideo("Rectangle", 640, 480);
				Mat source = new Mat();

				while (true)
				{

					if (CvSink.GrabFrame(source) == 0)
					{
						CvSource.NotifyError(CvSink.GetError());
						continue;
					}
					CvSource.PutFrame(source);
	            }

            });
            CameraThread.IsBackground = true;
            CameraThread.Start();
        }

        public override void DisabledPeriodic()
        {
            Scheduler.Instance.Run();
        }

        public override void AutonomousInit()
        {
			autonomousCommand = new AutonomousCommand();

			if (autonomousCommand != null) autonomousCommand.Start();
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

            SmartDashboard.PutNumber("POV", Oi.Pilot.GetPOV(0));
			SmartDashboard.PutString("Drive Mode", Oi.DriveStyle.ToString());
			SmartDashboard.PutString("Gear", Oi.ShifterGear.ToString());

            SmartDashboard.PutData("Compressor On", new CompressorOnCommand());
            SmartDashboard.PutData("Compressor Off", new CompressorOffCommand());

            Air.Update();
            Match.Update();
            Power.Update();
        }

        public override void TestPeriodic()
        {
            LiveWindow.Run();
        }
    }
}
