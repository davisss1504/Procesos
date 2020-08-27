using System;
namespace SpecFlowProject1.Steps
{
    public class Estudiante
    {
        public double primeraNota { get; set; }
        public double segundaNota { get; set; }
        public double terceraNota { get; set; }

        public double promedioFinal()
        {
            return (primeraNota + segundaNota + terceraNota) / 3;
        }

        public double promedioFinal(double note1, double note2, double note3)
        {
            return (note1 + note2 + note3) / 3;
        }
    }

}


