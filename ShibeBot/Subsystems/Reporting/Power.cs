using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Reporting
{
    class Power : Subsystem
    {
        static PowerDistributionPanel _panel = RobotMap.Panel;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}
