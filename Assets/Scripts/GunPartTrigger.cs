using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartTrigger : GunPart {

    	private float fireRate;
    	private FiringMode firingMode;

    	/**
         * Creates a blank GunPartTrigger
        */
        public GunPartTrigger() {
            fireRate = 1.0f;
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

        public GunPartTrigger(float fireRate, FiringMode firingMode) {
        	this.fireRate = fireRate;
        	this.firingMode = firingMode;
        }

        public float getFireRate() {
        	return fireRate;
        }

        public void setFireRate(float fireRate) {
        	this.fireRate = fireRate;
        }

        public FiringMode getFiringMode() {
        	return firingMode;
        }

        public void setFiringMode(FiringMode firingMode) {
        	this.firingMode = firingMode;
        }
    }
}