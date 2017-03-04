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
        public static int DriveTrainLeftPrimary = 0;
        public static int DriveTrainLeftSecondary = 1;
        public static int DriveTrainRightPrimary = 2;
        public static int DriveTrainRightSecondary = 3;
        public static int TowerCollector = 4;
        public static int HopperMotor = 5;
        public static int ThrowerLoader = 6;
        public static int ThrowerLeft = 7;
        public static int ThrowerRight = 8;
        public static int LifterMotor = 9;

        //Potentiometer
        public static AnalogPotentiometer ThrowerAngle = new AnalogPotentiometer(0);

        //Drive Systems

        //Pneumatics
        public const int PrimaryPcm = 0;
        public static Compressor Compressor = new Compressor(PrimaryPcm);
        public static DoubleSolenoid DriveShfiter = new DoubleSolenoid(0, 1);
        public static DoubleSolenoid GearHolder = new DoubleSolenoid(2, 3);
        public static DoubleSolenoid GearAux = new DoubleSolenoid(4, 5);
        public static DoubleSolenoid AuxClamp = new DoubleSolenoid(6, 7);

        //Reporting
        public const int PrimaryPdp = 0;
        public static PowerDistributionPanel Panel = new PowerDistributionPanel(PrimaryPdp);

        //Analog
        public static AnalogInput Pressure = new AnalogInput(1);

        //Environment
        public static ADXRS450_Gyro Gyro = new ADXRS450_Gyro(SPI.Port.OnboardCS0);
    }
}
