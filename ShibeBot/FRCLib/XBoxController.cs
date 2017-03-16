using System;
using System.Windows;
using System.Reactive.Linq;
using WPILib;
using WPILib.Commands;
using WPILib.Buttons;

namespace ShibeBot
{
	public class XBox
	{
		private XboxController XboxController;
		public XBox(int port)
		{
			XboxController = new XboxController(port);
		}

		private void AssignCommand(int mapId, Command command) 
		{
			new JoystickButton(XboxController, mapId).WhenPressed(command);
		}

		public void OnYPressed(CommandBase command) 
		{ 
			AssignCommand(XboxMap.YButton, command);
		}

		public void OnYPressed(Action oneOff) 
		{
			AssignCommand(XboxMap.YButton, new CommandBase(oneOff));
		}

		public void OnXPressed(CommandBase command) 
		{ 
			AssignCommand(XboxMap.XButton, command);
		}
		public void OnXPressed(Action oneOff) {
			AssignCommand(XboxMap.XButton, new CommandBase(oneOff));
		}

		public void OnBPressed(CommandBase command) 
		{ 
			AssignCommand(XboxMap.BButton, command);
		}

		public void OnBPressed(Action oneOff) 
		{ 
			AssignCommand(XboxMap.YButton, new CommandBase(oneOff));
		}

		public void OnAPressed(CommandBase command) 
		{ 
			AssignCommand(XboxMap.YButton, command);
		}

		public void OnAPressed(Action oneOff) 
		{ 
			AssignCommand(XboxMap.YButton, new CommandBase(oneOff));
		}


		public double GetRightX() 
		{
			return XboxController.GetRawAxis(XboxMap.RightX);
		}
	}
}
