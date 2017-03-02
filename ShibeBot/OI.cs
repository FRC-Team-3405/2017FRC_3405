using WPILib;
using WPILib.Buttons;

namespace ShibeBot
{
    enum Controller
    {
        Pilot,
        CoPilot
    };

    public class OI
    {
        public Joystick pilot = new Joystick(HIDMap.PilotXbox);
        public Joystick copilot = new Joystick(HIDMap.CoPilotXbox);

        public Joystick stationLeft = new Joystick(HIDMap.DriverStationLeft);
        public Joystick stationRight = new Joystick(HIDMap.DriverStationRight);

        void Rumble(Controller _controller)
        {
            
        }
    }
}
