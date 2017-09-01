using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartBody : GunPart {

        private float baseDamage;
        private AmmunitionType ammunitionType;

        /**
         * Creates a blank GunPartBody
        */
        public GunPartBody() {
            baseDamage = 0.0f;
            ammunitionType = AmmunitionType.Bullet;
        }

        /**
         * Creates a randomly generated GunPartBody
        */
        public GunPartBody(int level) {
            //TODO random generation
            //Minimum Base Damage = 1?
            //Maximum Base Damage = 50?
            //Ammunition Type tiers?
        }

        public GunPartBody(AmmunitionType ammunitionType, float baseDamage) {
        	this.ammunitionType = ammunitionType;
        	this.baseDamage = baseDamage;
        }

        public float GetBaseDamage() {
        	return baseDamage;
        }

        public void SetBaseDamage(float baseDamage) {
        	this.baseDamage = baseDamage;
        }

        public AmmunitionType GetAmmunitionType() {
        	return ammunitionType;
        }

        public void SetAmmunitionType(AmmunitionType ammunitionType) {
        	this.ammunitionType = ammunitionType;
        }
    }
}