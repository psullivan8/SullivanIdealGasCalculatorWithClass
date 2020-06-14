//Patrik Sullivan psullivan8@cnm.edu
//Ideal Gas Calculator With Class
//6-1-20

using System;
using System.Collections.Generic;
using System.Text;

namespace SullivanIdealGasCalculatorWithClass
{
    class IdealGas
    {
        private double mass = 0.0;

        public double GetMass()
        {
            return mass;
        }

        public void SetMass(double mass)
        {
            this.mass = mass;
            Calc();
        }

        private double vol = 0.0;

        public double GetVol()
        {
            return vol;
        }

        public void SetVol(double vol)
        {
            this.vol = vol;
            Calc();
        }

        private double temp = 0.0;

        public double GetTemp()
        {
            return temp;
        }

        public void SetTemp(double temp)
        {
            this.temp = temp;
            Calc();
        }

        private double pascals = 0;

        public double GetPressure()
        {
            return pascals;
        }

        private double molecularWeight = 0.0;

        public double GetMolecularWeight()
        {
            return molecularWeight;
        }

        public void SetMolecularWeight(double molecularWeight)
        {
            this.molecularWeight = molecularWeight;
            Calc();
        }

        private void Calc()
        {
            //TODO:  Use your constants here, too or make them class constants  -5
            //TODO:  Either way, they are constants
            // this should be in calculate method. Your get method should just have a return statement. RJG
            double celcius = temp;
            double kelvin = 0;
            double r = 8.3145;
            double n;
            n = mass / molecularWeight;
            kelvin = celcius += 273;
            //TODO: Don't need this just use the existing field. RJG
            //double pascals;
            pascals = ((n * r * kelvin) / vol);

            //this.pascals = pascals;

            //-5 code to calculate presure should be here. RJG
        }
    }
}
