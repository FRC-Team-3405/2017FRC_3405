using WPILib;
using WPILib.Commands;

namespace ShibeBot.Subsystems.Pneumatics
{
    class Pneumatics : Subsystem
    {
        static Compressor _compressor = RobotMap.Compressor;
        static DoubleSolenoid _shifter = RobotMap.DriveShfiter;
        static DoubleSolenoid _gearHolder = RobotMap.GearHolder;
        static DoubleSolenoid _gearAux = RobotMap.GearAux;
        static DoubleSolenoid _auxClamp = RobotMap.AuxClamp;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}