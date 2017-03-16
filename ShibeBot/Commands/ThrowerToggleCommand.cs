using System;
using WPILib;
using WPILib.Commands;

namespace ShibeBot.Commands
{
	public class ThrowerToggle : Command
	{
		public ThrowerToggle()
		{
			Requires(ShibeBot.Thrower);
		}

		protected override void Initialize()
		{

		}

		protected override void Execute()
		{
			Oi.ThrowerEnabled = !Oi.ThrowerEnabled;
			if (Oi.ThrowerEnabled)
			{
				ShibeBot.Thrower.Throw();
			}
			else 
			{
				ShibeBot.Thrower.StopThrowing();
			}
			
		}

		protected override bool IsFinished()
		{
			return true;
		}

		protected override void End()
		{
		}

		protected override void Interrupted()
		{
		}
	}
}
