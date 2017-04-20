using WPILib;
using WPILib.Buttons;
using ShibeBot.Commands;
using ShibeBot.OperatorInteface;

namespace ShibeBot
{
	public class Oi
	{
		public static Joystick Pilot = new Joystick(HidMap.PilotXbox);

		public Oi()
		{

		}

	}
}