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

        public float GetCapacity() {
        	return capacity;
        }

        public void SetCapacity(float capacity) {
        	this.capacity = capacity;
        }

        public float GetReloadSpeed() {
        	return reloadSpeed;
        }

        public void SetReloadSpeed(float reloadSpeed) {
        	this.reloadSpeed = reloadSpeed;
        }
    }
}