﻿using WPILib;
using WPILib.Commands;
using WPILib.Interfaces;

namespace ShibeBot.Subsystems.Lifter
{
    class Lifter : Subsystem
    {
        static ISpeedController lifter = RobotMap.LifterMotor;

        protected override void InitDefaultCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}