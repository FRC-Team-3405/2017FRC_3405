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

    public class Oi
	{
		public Joystick Pilot;
		public Joystick Copilot;

		public Joystick StationLeft;
		public Joystick StationRight;

	    public JoystickButton PilotTrigger;

		public Oi() {
			Pilot = new Joystick(HidMap.PilotXbox);
			//Copilot = new Joystick(HidMap.CoPilotXbox);
			//StationRight = new Joystick(HidMap.DriverStationRht);
			//StationLeft = new Joystick(HidMap.DriverStationLeft);
			//PilotTrigger = new JoystickButton(Pilot, XboxMap.AButton);
            //PilotTrigger.WhenPressed(new DriveCommand());
		}

        void Rumble(Controller controller)
        {

        }


    }
}
