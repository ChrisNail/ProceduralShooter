using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class FiringMode {

        private FiringModeType type;

        public FiringMode(FiringModeType type) {
            this.type = type;
        }

        public bool canFire(bool triggered, bool firing) {
            switch(type) {
                case FiringModeType.Single:
                    return triggered && !firing;
                case FiringModeType.Auto:
                    return triggered;
                case FiringModeType.Charge:
                    return triggered || (!triggered && firing);
                default:
                    return false;
            }
        }

        public static readonly FiringMode Single = new FiringMode(FiringModeType.Single);
        public static readonly FiringMode Auto = new FiringMode(FiringModeType.Auto);
        public static readonly FiringMode Charge = new FiringMode(FiringModeType.Charge);

    }

    public enum FiringModeType {
        Single, Auto, Charge
    }

}