using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjectionSample.AntiSample
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Modell { get; set; }
        public DateTime BuildingYear { get; set; }

        public Car()
        {

        }
        public void StarteMotor ()
        {
            // Mache irgendwas
        }
    }
}
