using WPILib;
using WPILib.Buttons;
using ShibeBot.Commands;

namespace ShibeBot
{
    enum Controller
    {
        Pilot,
        CoPilot
    };

    public class OI
	{
		public Joystick pilot;
		public Joystick copilot;

		public Joystick stationLeft;
		public Joystick stationRight;

		//
		public static JoystickButton pilotTrigger;
		public OI() {
			pilot = new Joystick(HIDMap.PilotXbox);
			copilot = new Joystick(HIDMap.CoPilotXbox);
			stationRight = new Joystick(HIDMap.DriverStationRight);
			stationLeft = new Joystick(HIDMap.DriverStationLeft);
			pilotTrigger = new JoystickButton(pilot, XBOXMap.RightBumper);
			pilotTrigger.WhileHeld(new DriveCommand());
		}

        void Rumble(Controller _controller)
        {

        }


    }
}
