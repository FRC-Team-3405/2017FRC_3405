using System.Diagnostics;
using ShibeBot.Commands;
using WPILib;
using WPILib.Commands;

namespace ShibeBot.Subsystems.Pneumatics
{

    public class Pneumatics : Subsystem
    {
        static Compressor _compressor = new Compressor(RobotMap.PrimaryPcm);
        static DoubleSolenoid _shifter = new DoubleSolenoid(RobotMap.ShifterExtend, RobotMap.ShifterRetract);
        static DoubleSolenoid _gearHolder = new DoubleSolenoid(RobotMap.GearDoorsExtend, RobotMap.GearDoorsRetract);
        static DoubleSolenoid _gearMech = new DoubleSolenoid(RobotMap.GearGrabberMechExtend, RobotMap.GearGrabberMechRetract);
        static DoubleSolenoid _gearClamp = new DoubleSolenoid(RobotMap.GearClampExtend, RobotMap.GearClampRetract);


        protected override void InitDefaultCommand()
        {
            SetDefaultCommand(new GrabGearCommand());
            _compressor.Stop();
        }

        public void StepThroughPnuematics(int step)
        {
            switch (step)
            {
                case 1:
                    StepOne();
                    break;
                case 2:
                    StepTwo();
                    break;
                case 3:
                    StepThree();
                    break;
                case 4:
                    StepFour();
                    break;
            }
        }

		public void ShiftUp()
		{
			if (Oi.ShifterGear != Gear.High) 
			{
				_shifter.Set(DoubleSolenoid.Value.Forward);
				Oi.ShifterGear = Gear.High;
			}
		}

		public void ShiftDown() 
		{
			if (Oi.ShifterGear != Gear.Low) 
			{
				_shifter.Set(DoubleSolenoid.Value.Reverse);
				Oi.ShifterGear = Gear.Low;
			}
		
		}
        private void StepOne()
        {
            _gearHolder.Set(DoubleSolenoid.Value.Reverse);   
            _gearMech.Set(DoubleSolenoid.Value.Forward);
            _gearClamp.Set(DoubleSolenoid.Value.Reverse);
        }

        private void StepTwo()
        {
            _gearClamp.Set(DoubleSolenoid.Value.Forward);
        }

        private void StepThree()
        {
            _gearMech.Set(DoubleSolenoid.Value.Reverse);
        }

        private void StepFour()
        {
            _gearHolder.Set(DoubleSolenoid.Value.Forward);
            _gearClamp.Set(DoubleSolenoid.Value.Forward);
        }
    }
}