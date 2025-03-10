﻿namespace DesignPatterns._03_Behavioral._04_Iterator.RadioStation
{
    // Aggregate
    public class RadioStation
    {
        private float mFrequency;

        public RadioStation(float frequency)
        {
            this.mFrequency = frequency;
        }

        public float GetFrequency()
        {
            return mFrequency;
        }
    }
}