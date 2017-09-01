using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public abstract class WeaponPart : Item {

    	private int level;

    	public int GetLevel() {
    		return level;
    	}

    	public void SetLevel(int level) {
    		this.level = level;
    	}
    }
}