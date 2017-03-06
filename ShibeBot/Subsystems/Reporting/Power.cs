using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Reporting
{
    class Power : Subsystem
    {
        static PowerDistributionPanel _panel = new PowerDistributionPanel(RobotMap.PrimaryPdp);

        protected override void InitDefaultCommand()
        {

        }
    }
}
