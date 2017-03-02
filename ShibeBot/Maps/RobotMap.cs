using System.Net;
using System.Runtime.InteropServices;
using WPILib;
using WPILib.Interfaces;

namespace ShibeBot
{
    public class RobotMap
    {
		//JoyStick


        //Encoders
        public static Encoder DriveTrainLeftQuadrature = new Encoder(0, 1);
        public static Encoder DriveTrainRightQuadrature = new Encoder(1, 2);
        public static Encoder ThrowerLeftQuadrature = new Encoder(3, 4);
        public static Encoder ThrowerRightQuadrature = new Encoder(5, 6);

        //Motors
        public static ISpeedController DriveTrainLeftPrimary = new TalonSRX(0);
        public static ISpeedController DriveTrainLeftSecondary = new TalonSRX(1);
        public static ISpeedController DriveTrainRightPrimary = new TalonSRX(2);
        public static ISpeedController DriveTrainRightSecondary = new TalonSRX(3);
        public static ISpeedController TowerCollector = new Talon(4);
        public static ISpeedController HopperMotor = new Spark(5);
        public static ISpeedController ThrowerLoader = new Talon(6);
        public static ISpeedController ThrowerLeft = new Talon(7);
        public static ISpeedController ThrowerRight = new Talon(8);
        public static ISpeedController LifterMotor = new Talon(9);

        //Potentiometer
        public static AnalogPotentiometer ThrowerAngle = new AnalogPotentiometer(0);

        //Drive Systems
        public static RobotDrive DriveTrain = new RobotDrive(DriveTrainLeftPrimary, DriveTrainLeftSecondary, DriveTrainRightPrimary, DriveTrainRightSecondary);

        //Pneumatics
        public const int PrimaryPCM = 0;
        public static Compressor Compressor = new Compressor(PrimaryPCM);
        public static DoubleSolenoid DriveShfiter = new DoubleSolenoid(0, 1);
        public static DoubleSolenoid GearHolder = new DoubleSolenoid(2, 3);
        public static DoubleSolenoid GearAux = new DoubleSolenoid(4, 5);
        public static DoubleSolenoid AuxClamp = new DoubleSolenoid(6, 7);

        //Reporting
        public const int PrimaryPDP = 0;
        public static PowerDistributionPanel Panel = new PowerDistributionPanel(PrimaryPDP);

        //Analog
        public static AnalogInput Pressure = new AnalogInput(1);

        //Environment
        public static ADXRS450_Gyro Gyro = new ADXRS450_Gyro(SPI.Port.OnboardCS0);
    }
}
