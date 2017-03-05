using WPILib;
using WPILib.Commands;
using ShibeBot.Commands;

namespace ShibeBot.Subsystems.Tower
{
    public class Collector : Subsystem
    {
		private static Talon CollectorMotor = new Talon(RobotMap.TowerCollector);
        protected override void InitDefaultCommand()
        {
			SetDefaultCommand(new CollectorCommand());
        }

		public void Collect()
		{
			CollectorMotor.Set(1);
		}

		public void StopCollect() 
		{
			CollectorMotor.Set(0);
		}
    }
}