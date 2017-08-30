using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartMagazine : GunPart {

    	private float capacity;
    	private float reloadSpeed;

    	/**
         * Creates a blank GunPartMagazine
        */
        public GunPartMagazine() {
            capacity = 1.0f;
            reloadSpeed = 1.0f;
        }

        /**
         * Creates a randomly generated GunPartMagazine
        */
        public GunPartMagazine(int level) {
            //TODO random generation
            //Minimum Capacity = 1
            //Maximum Capacity = 30?
        }

        public GunPartMagazine(float capacity, float reloadSpeed) {
        	this.capacity = capacity;
        	this.reloadSpeed = reloadSpeed;
        }

        public float getCapacity() {
        	return capacity;
        }

        public void setCapacity(float capacity) {
        	this.capacity = capacity;
        }

        public float getReloadSpeed() {
        	return reloadSpeed;
        }

        public void setReloadSpeed(float reloadSpeed) {
        	this.reloadSpeed = reloadSpeed;
        }
    }
}