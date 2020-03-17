﻿namespace task_DEV_3
{
    public class Scooter : Vehicle
    {
        string _material;
        new public void GetInfo()
        {
            System.Console.WriteLine("Type: Scooter");
            System.Console.WriteLine("This scooter is made of " + _material);
            base.GetInfo();
        }
        public Scooter(string material, Engine engine, Transmission transmission, Chassis chassis):base(engine,transmission,chassis)
        {
            base.CheckForNullAndEmpty(material);
            _material = material;
        }
    }
}
