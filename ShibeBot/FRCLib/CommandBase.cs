using System;
using WPILib.Commands;
namespace ShibeBot
{
	public class CommandBase : Command
	{
		protected bool oneOff;
		private Action Action;


		public CommandBase(Action execute)
		{
			Action = execute;
			oneOff = true;
		}

		public CommandBase() 
		{
			oneOff = false;
		}
		protected override void Execute() 
		{
			if (oneOff) {
				Action();
			}
		}

		protected override bool IsFinished()
		{
			return oneOff;
		}
	}
}
