﻿using System;

namespace task_DEV_3
{
    public class Engine
    {
        double _power;
        double _volume;
        string _typeOfEngine;
        string _serialNumber;
        public Engine(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Power = power;
            Volume = volume;
            TypeOfEngine = typeOfEngine;
            SerialNumber = serialNumber;
        }
        public double Power
        {
            get { return _power; }
            set
            {
                CheckNullOrEmpty(value);
                _power = value;
            }
        }
        public double Volume
        {
            get { return _volume; }
            set
            {
                CheckNullOrEmpty(value);
                _volume = value;
            }
        }
        public string TypeOfEngine
        {
            get { return _typeOfEngine; }
            set
            {
                CheckNullOrEmpty(value);
                _typeOfEngine = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                CheckNullOrEmpty(value);
                _serialNumber = value;
            }
        }
        private void CheckNullOrEmpty(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            if (value.GetType() == typeof(string) && (string)value == string.Empty)
            {
                throw new FormatException();
            }
        }
    }
}
