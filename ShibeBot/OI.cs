using WPILib;
using WPILib.Buttons;
using ShibeBot.Commands;
using ShibeBot.OperatorInteface;

namespace ShibeBot
{
    enum Controller
    {
        Pilot,
        CoPilot
    };

    public enum DriveStyle
    {
        Arcade,
        Tank
    }

    public enum Gear
    {
        Low,
        High
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
        public static JoystickButton PilotSwitch = new JoystickButton(Pilot, XboxMap.StartButton);

        //Pilot Variables
        public static DriveStyle DriveStyle = DriveStyle.Arcade;
        public static Gear ShifterGear = Gear.Low;

        //Co-Pilot Systems
        public static JoystickButton TurnOnCollector = new JoystickButton(Copilot, XboxMap.AButton);
        public static JoystickButton TurnOnThrower = new JoystickButton(Copilot, XboxMap.BButton);
        public static JoystickButton TurnOffCollector = new JoystickButton(Copilot, XboxMap.XButton);
        public static JoystickButton TurnOffThrower = new JoystickButton(Copilot, XboxMap.YButton);
        public static JoystickButton CoPilotSwitch = new JoystickButton(Copilot, XboxMap.StartButton);
        // public static JoystickButton PistonOperations = new JoystickButton(Copilot, XboxMap.);

        //Co-Pilot Variables
        public static bool CollectorEnabled = false;
	    public static bool ThrowerEnabled = false;
	    public static bool HooperStirEnabled = false;
	    public static bool HopperFeedEnabled = false;
        public static bool IsFacingTarget = false;

        public Oi() {
			//Copilot = new Joystick(HidMap.CoPilotXbox);
			//StationRight = new Joystick(HidMap.DriverStationRht);
			//StationLeft = new Joystick(HidMap.DriverStationLeft);
			//PilotTrigger = new JoystickButton(Pilot, XboxMap.AButton);

            //Pilot togglables
            ArcadeToggle.WhenPressed(new ArcadeEnable());
            TankToggle.WhenPressed(new TankEnable());

			HigherGear.WhenPressed(new ShiftUpCommand());
			LowerGear.WhenPressed(new ShiftDownCommand());

			//Co-Pilot togglables
			TurnOnThrower.WhenPressed(new ThrowerOnCommand());
			TurnOffThrower.WhenPressed(new ThrowerOffCommand());

			TurnOnCollector.WhenPressed(new CollectorOnCommand());
			TurnOffCollector.WhenPressed(new CollectorOffCommand());

            PilotSwitch.WhenPressed(new PilotSwitchCommand());

        }

        public static void InvertControllers()
        {
            JoysticksSwitched = !JoysticksSwitched;
            int temp;
            temp = HidMap.CoPilotXbox;
            HidMap.CoPilotXbox = HidMap.PilotXbox;
            HidMap.PilotXbox = temp;
        }

        void Rumble(Controller controller)
        {

        }
	}
}
