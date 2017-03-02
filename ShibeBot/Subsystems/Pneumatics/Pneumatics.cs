using WPILib;
using WPILib.Commands;

namespace ShibeBot.Subsystems.Pneumatics
{
    class Pneumatics : Subsystem
    {
        static Compressor compressor = RobotMap.Compressor;
        static DoubleSolenoid shifter = RobotMap.DriveShfiter;
        static DoubleSolenoid gearHolder = RobotMap.GearHolder;
        static DoubleSolenoid gearAux = RobotMap.GearAux;
        static DoubleSolenoid auxClamp = RobotMap.AuxClamp;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}