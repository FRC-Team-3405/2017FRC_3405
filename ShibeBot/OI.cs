using WPILib;
using WPILib.Buttons;
using ShibeBot.Commands;
using ShibeBot.OperatorInteface;

namespace ShibeBot
{

    public enum DriveStyle
    {
        Arcade,
        Tank
    }


    public enum ToggleField
    {
        DriveStyle
    }

    public class Oi
    {
        public static bool JoysticksSwitched = false;

		public static Joystick Pilot = new Joystick(HidMap.PilotXbox);
        public static Joystick Copilot = new Joystick(HidMap.CoPilotXbox);

        //Pilot Systems
        public static JoystickButton ArcadeToggle = new JoystickButton(Pilot, XboxMap.AButton);
        public static JoystickButton TankToggle = new JoystickButton(Pilot, XboxMap.XButton);
		public static JoystickButton HigherGear = new JoystickButton(Pilot, XboxMap.RightBumper);
        public static JoystickButton LowerGear = new JoystickButton(Pilot, XboxMap.LeftBumper);
        public static JoystickStick LeftStick = new JoystickStick(Pilot, XboxMap.LeftX, XboxMap.LeftY);
        public static JoystickStick RightStick = new JoystickStick(Pilot, XboxMap.RightX, XboxMap.RightY);

        //Pilot Variables
        public static DriveStyle DriveStyle = DriveStyle.Arcade;


        //Co-Pilot Variables
	    public static bool CollectorEnabled = false;
	    public static bool ThrowerEnabled = false;
	    public static bool HooperStirEnabled = false;
	    public static bool HopperFeedEnabled = false;

        public Oi() {
            
        }

	}
}
