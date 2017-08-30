using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartTrigger : GunPart {

    	private float rateOfFire;
    	private FiringMode firingMode;

    	/**
         * Creates a blank GunPartTrigger
        */
        public GunPartTrigger() {
            rateOfFire = 1.0f;
            firingMode = FiringMode.Single;
        }

        /**
         * Creates a randomly generated GunPartTrigger
        */
        public GunPartTrigger(int level) {
            //TODO random generation
            //Minimum Rate of Fire = 1.0?
            //Maximum Rate of Fire = 30.0?
            //Firing Mode Tiers?
        }

        public GunPartTrigger(float rateOfFire, FiringMode firingMode) {
        	this.rateOfFire = rateOfFire;
        	this.firingMode = firingMode;
        }

        public float getRateOfFire() {
        	return rateOfFire;
        }

        public void setRateOfFire(float rateOfFire) {
        	this.rateOfFire = rateOfFire;
        }

        public FiringMode getFiringMode() {
        	reutrn firingMode;
        }

        public void setFiringMode(FiringMode firingMode) {
        	this.firingMode = firingMode;
        }
    }
}