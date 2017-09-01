using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class GunPartMod : GunPart {

        private DamageType damageType;
        

        /**
         * Creates a blank GunPartMod
        */
        public GunPartMod() {
            damageType = DamageType.Kinetic;
        }

        /**
         * Creates a randomly generated GunPartMod
        */
        public GunPartMod(int level) {
            //TODO random generation
            //Damage Type Tiers?
        }

        public GunPartMod(DamageType damageType) {
        	this.damageType = damageType;
        	
        }

        public DamageType GetDamageType() {
            return damageType;
        }

        public void SetDamageType(DamageType damageType) {
            this.damageType = damageType;
        }
    }
}