using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Thrower
{
    public class Thrower : Subsystem
    {
        private static ISpeedController left = RobotMap.ThrowerLeft;
        private static ISpeedController right = RobotMap.ThrowerRight;
        private static Encoder leftEncoder = RobotMap.ThrowerLeftQuadrature;
        private static Encoder rightEncoder = RobotMap.ThrowerRightQuadrature;
        private static AnalogPotentiometer angle = RobotMap.ThrowerAngle;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}