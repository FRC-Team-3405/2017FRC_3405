using System.Collections.Generic;
using ShibeBot.Maps;
using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;
using ShibeBot.Subsystems.Reporting.PowerDistribution;

namespace ShibeBot.Subsystems.Reporting
{
    public class Power : Subsystem
    {
        static PowerDistributionPanel _panel = new PowerDistributionPanel(RobotMap.PrimaryPdp);

        private List<PowerChannel> channels;

        protected override void InitDefaultCommand()
        {
            channels = new List<PowerChannel> {
                new PowerChannel(PowerMap.DriveTrainLeftPrimaryPowerPort, PowerMap.DriveTrainLeftPrimaryPowerName),
                new PowerChannel(PowerMap.DriveTrainLeftSecondaryPowerPort, PowerMap.DriveTrainLeftSecondaryPowerName),
                new PowerChannel(PowerMap.DriveTrainRightPrimaryPowerPort, PowerMap.DriveTrainRightPrimaryPowerName),
                new PowerChannel(PowerMap.DriveTrainRightSecondaryPowerPort, PowerMap.DriveTrainRightSecondaryPowerName)
            };
        }

        public void Update()
        {
            foreach (PowerChannel channel in channels)
            {
                
            }
        }
    }
}
