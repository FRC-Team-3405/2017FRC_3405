using WPILib;
using WPILib.Commands;

namespace ShibeBot.Subsystems
{
    public enum CameraTarget
    {
        Boiler,
        GearPeg
    }
    public class Camera : Subsystem
    {
        // Put methods for controlling this subsystem
        // here. Call these from Commands.
        private CameraTarget target;
        private string camAddress = "";


        protected override void InitDefaultCommand()
        {
            // Set the default command for a subsystem here.
            //SetDefaultCommand(new MySpecialCommand());
        }

        public bool SeesTape()
        {
            return false;
        }
        public CameraTarget FoundTarget()
        {
            //check shape of tape
            //set target to type
            IsBoiler();
            IsGearPeg();
            return target;
        }

        private bool IsBoiler()
        {
            //target = CameraTarget.Boiler;
            return false;
        }
        private bool IsGearPeg()
        {
            //target = CameraTarget.GearPeg;
            return false;
        }

        private void ImageProcess()
        { }
    }
}
