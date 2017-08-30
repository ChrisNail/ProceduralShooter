using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartStock : GunPart {

		private float stabilityBoost;
    	private float accruacyBoost;

    	/**
         * Creates a blank GunPartStock
        */
        public GunPartStock() {
            stabilityBoost = 1.0f;
            accruacyBoost = 1.0f;
        }

        /**
         * Creates a randomly generated GunPartStock
        */
        public GunPartStock(int level) {
            //TODO random generation
            //Minimum Stability Boost = 1.0?
            //Maximum Stability Boost = 2.0?
            //Minimum Accuracy Boost = 1.0?
            //Maximum Accuracy Boost = 2.0?
        }

        public GunPartStock(float stabilityBoost, float accruacyBoost) {
        	this.stabilityBoost = stabilityBoost;
        	this.accruacyBoost = accruacyBoost;
        }

        public float getStabilityBoost() {
        	return stabilityBoost;
        }

        public void setStabilityBoost(float stabilityBoost) {
        	this.stabilityBoost = stabilityBoost;
        }

        public float getAccuracyBoost() {
        	return accruacyBoost;
        }

        public void setAccuracyBoost(float accruacyBoost) {
        	this.accruacyBoost = accruacyBoost;
        }
    }
}