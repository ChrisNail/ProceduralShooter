using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class AmmunitionType {

    	private string name;
    	private int consumedAmmo;

        public static readonly AmmunitionType Bullet = new AmmunitionType("Bullet", 1);
        public static readonly AmmunitionType Beam = new AmmunitionType("Beam", 1);
        public static readonly AmmunitionType Grenade = new AmmunitionType("Grenade", 2);
        public static readonly AmmunitionType Rocket = new AmmunitionType("Rocket", 3);

        public AmmunitionType(string name, int consumedAmmo) {
        	this.name = name;
        	this.consumedAmmo = consumedAmmo;
        }

        public string getName() {
        	return name;
        }

        public int getConsumedAmmo() {
        	return consumedAmmo;
        }
    }
}