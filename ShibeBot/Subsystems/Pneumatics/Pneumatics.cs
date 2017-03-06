﻿using System.Diagnostics;
using ShibeBot.Commands;
using WPILib;
using WPILib.Commands;
using WPILib.SmartDashboard;

namespace ShibeBot.Subsystems.Pneumatics
{

    public class Pneumatics : Subsystem
    {
        static readonly Compressor Compressor = new Compressor(RobotMap.PrimaryPcm);
        static readonly DoubleSolenoid Shifter = new DoubleSolenoid(RobotMap.ShifterExtend, RobotMap.ShifterRetract);
        static readonly DoubleSolenoid GearHolder = new DoubleSolenoid(RobotMap.GearDoorsExtend, RobotMap.GearDoorsRetract);
        static readonly DoubleSolenoid GearMech = new DoubleSolenoid(RobotMap.GearGrabberMechExtend, RobotMap.GearGrabberMechRetract);
        static readonly DoubleSolenoid GearClamp = new DoubleSolenoid(RobotMap.GearClampExtend, RobotMap.GearClampRetract);


        protected override void InitDefaultCommand()
        {
            SetDefaultCommand(new GrabGearCommand());
            Compressor.Enabled();
            Compressor.ClosedLoopControl = RobotMap.ClosedLoopControl;
        }

        public void CompressorOn()
        {
            Compressor.Start();
        }

        public void CompressorOff()
        {
            Compressor.Stop();
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
				Shifter.Set(DoubleSolenoid.Value.Forward);
				Oi.ShifterGear = Gear.High;
			}
		}

		public void ShiftDown() 
		{
			if (Oi.ShifterGear != Gear.Low) 
			{
				Shifter.Set(DoubleSolenoid.Value.Reverse);
				Oi.ShifterGear = Gear.Low;
			}
		
		}
        private void StepOne()
        {
            GearHolder.Set(DoubleSolenoid.Value.Reverse);   
            GearMech.Set(DoubleSolenoid.Value.Forward);
            GearClamp.Set(DoubleSolenoid.Value.Reverse);
        }

        private void StepTwo()
        {
            GearClamp.Set(DoubleSolenoid.Value.Forward);
        }

        private void StepThree()
        {
            GearMech.Set(DoubleSolenoid.Value.Reverse);
        }

        private void StepFour()
        {
            GearHolder.Set(DoubleSolenoid.Value.Forward);
            GearClamp.Set(DoubleSolenoid.Value.Forward);
        }
    }
}