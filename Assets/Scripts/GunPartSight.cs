using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartSight : GunPart {

    	private ZoomMode zoomMode;
    	private float accuracyBoost;

    	/**
         * Creates a blank GunPartSight
        */
        public GunPartSight() {
            zoomMode = ZoomMode.Iron;
            accuracyBoost = 1.0f;
        }

        /**
         * Creates a randomly generated GunPartSight
        */
        public GunPartSight(int level) {
            //TODO random generation
            //Zoom Mode Tiers?
            //Minimum Accuracy Boost = 1.0?
            //Maximum Accuracy Boost = 2.0?
        }

        public GunPartSight(ZoomMode zoomMode, float accuracyBoost) {
        	this.zoomMode = zoomMode;
        	this.accuracyBoost = accuracyBoost;
        }

        public ZoomMode getZoomMode() {
            return zoomMode;
        }

        public void setZoomMode(ZoomMode zoomMode) {
            this.zoomMode = zoomMode;
        }

        public float getAccuracyBoost() {
            return accuracyBoost;
        }

        public void setAccuracyBoost(float accuracyBoost) {
            this.accuracyBoost = accuracyBoost;
        }
    }
}