using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjectionSample.BetterSample
{
    public class Car : ICar
    {
        public int Id  {  get; set; }
        public string Brand { get; set; }
        public string Modell { get; set; }
        public DateTime BuildingYear { get; set; }

        public Car()
        {

        }

        public void StarteMotor()
        {
            //Mach irgendwas
        }
    }
}
