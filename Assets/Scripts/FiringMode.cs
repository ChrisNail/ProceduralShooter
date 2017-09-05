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

        public bool CanFire(bool isTriggered, bool wasTriggered) {
            switch(type) {
                case FiringModeType.Single:
                    return isTriggered && !wasTriggered;
                case FiringModeType.Auto:
                    return isTriggered;
                case FiringModeType.Charge:
                    return !isTriggered && wasTriggered;
                default:
                    return false;
            }
        }

        public bool CanCharge(bool isTriggered, bool wasTriggered) {
            switch(type) {
                case FiringModeType.Charge:
                    return isTriggered;
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