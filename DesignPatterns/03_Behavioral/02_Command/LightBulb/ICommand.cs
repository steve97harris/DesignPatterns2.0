﻿using System;
using DesignPatterns._Factory;

namespace DesignPatterns._03_Behavioral._02_Command.LightBulb
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }

    public class TurnOn : ICommand        // Creating class TurnOn belonging to ICommand
    {
        private Bulb mBulb;        

        public TurnOn(Bulb bulb)        // Constructor
        {
            this.mBulb = bulb ?? throw new ArgumentNullException("bulb", "Bulb cannot be null");
        }
        public void Execute()        // Function to execute the command TurnOn() 
        {
            mBulb.TurnOn();
        }

        public void Undo()
        {
            mBulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }
    }

    public class TurnOff : ICommand
    {
        private Bulb mBulb;

        public TurnOff(Bulb bulb)
        {
            this.mBulb = bulb ?? throw new ArgumentNullException("bulb", "Bulb cannot be null");
        }
        public void Execute()
        {
            mBulb.TurnOff();
        }

        public void Undo()
        {
            mBulb.TurnOn();
        }

        public void Redo()
        {
            Execute();
        }
    }
}