﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_and_fire_system
{
    public class SmokeDetector : ISensorOperation
    {
        private bool burn;
        SayValue ValueForSmokeDetector; 
        SayValueForRoom ValueFromSmokeDetector;

        public SmokeDetector(bool _burn, SayValue ValueForSmokeDetector, SayValueForRoom ValueFromSmokeDetector)
        {
            burn = _burn;
            this.ValueForSmokeDetector = ValueForSmokeDetector;
            this.ValueFromSmokeDetector = ValueFromSmokeDetector;
        }

        public void SetNewValueBurn(bool newBurn)
        {
            this.burn = newBurn;
        }

        public bool CollectInformation()
        {
            ValueForSmokeDetector();
            return burn;
        }

        public void EnableProtection()
        {
            burn = false;
            ValueFromSmokeDetector(burn);
        }
    }
}
