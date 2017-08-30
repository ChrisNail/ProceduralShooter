using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartBarrel : GunPart {

        private float damageBoost;
        private float projectileSpeed;

        /**
         * Creates a blank GunPartBarrel
        */
        public GunPartBarrel() {
        	damageBoost = projectileSpeed = 1.0f;
        }

        /**
         * Creates a randomly generated GunPartBarrel
        */
        public GunPartBarrel(int level) {
            //TODO random generation
            //Minimum Damage Boost = 0.25? (Never 0)
            //Maximum Damage Boost = 4.0? (Maybe opposite of minimum)
            //Minimum Projectile Speed = 0.25?
            //Maximum Projectile Speed = 4.0?
        }

        public GunPartBarrel(float damageBoost, float projectileSpeed) {
        	this.damageBoost = damageBoost;
        	this.projectileSpeed = projectileSpeed;
        }

        public float getDamageBoost() {
        	return damageBoost;
        }

        public void setDamageBoost(float damageBoost) {
        	this.damageBoost = damageBoost;
        }

        public float getProjectileSpeed() {
        	return projectileSpeed;
        }

        public void setProjectileSpeed(float projectileSpeed) {
        	this.projectileSpeed = projectileSpeed;
        }
    }
}