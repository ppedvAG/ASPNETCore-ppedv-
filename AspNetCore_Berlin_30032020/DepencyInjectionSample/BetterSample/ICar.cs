using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjectionSample.BetterSample
{
    public interface ICar
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Modell { get; set; }
        DateTime BuildingYear { get; set; }

        void StarteMotor();
    }
}
