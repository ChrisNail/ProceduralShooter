using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items {

    public class Gun : Weapon {

        private GunPartBarrel barrel;
        private GunPartBody body;
        private GunPartMagazine magazine;
        private GunPartMod mod;
        private GunPartSight sight;
        private GunPartStock stock;
        private GunPartTrigger trigger;

        //Amount of ammo in the magazine
        private int ammo = 0;
        //The gun has had the trigger down last frame
        private bool firing = false;
        //The amount of shots that have been charged by the gun
        private int chargedShots = 0;
        //Amount of time before next shot
        private float speedTimer = 0.0f;

        /**
         * Creates a blank Gun
        */
        public Gun() {
            barrel = new GunPartBarrel();
            body = new GunPartBody();
            magazine = new GunPartMagazine();
            mod = new GunPartMod();
            sight = new GunPartSight();
            stock = new GunPartStock();
            trigger = new GunPartTrigger();
        }

        /**
         * Creates a randomly generated Gun
        */
        public Gun(int level) {
            barrel = new GunPartBarrel(level);
            body = new GunPartBody(level);
            magazine = new GunPartMagazine(level);
            mod = new GunPartMod(level);
            sight = new GunPartSight(level);
            stock = new GunPartStock(level);
            trigger = new GunPartTrigger(level);
        }

        // Use this for initialization
        public override void Start() {

        }

        // Update is called once per frame
        public override void Update() {
            bool triggered = Input.GetButtonDown("Fire1");
            if (!triggered) {
                firing = false;
            }

            if (checkSpeedTimer()) {
                if (getFiringMode().canFire(triggered, firing)) {

                }
            }


            firing = triggered;
        }

        public bool consumeAmmo() {
            if (ammo > getAmmunitionType().getConsumedAmmo()) {
                ammo -= getAmmunitionType().getConsumedAmmo();
                
                return true;
            }

            return false;
        }

        public bool getFiring() {
            return firing;
        }

        public void setFiring(bool firing) {
            this.firing = firing;
        }

        public bool toggleFiring() {
            firing = !firing;

            return firing;
        }

        public int getChargedShots() {
            return chargedShots;
        }

        public void setChargedShots(int chargedShots) {
            this.chargedShots = chargedShots;
        }

        public bool checkSpeedTimer() {
            if (speedTimer > 0.0f)
                speedTimer -= Time.deltaTime;
            if(speedTimer < 0.0f)
                speedTimer = 0.0f;
            return speedTimer == 0.0f;
        }

        public GunPartBarrel getBarrel() {
            return barrel;
        }

        public void setBarrel(GunPartBarrel barrel) {
            this.barrel = barrel;
        }

        public GunPartBody getBody() {
            return body;
        }

        public void setBody(GunPartBody body) {
            this.body = body;
        }

        public GunPartMagazine getMagazine() {
            return magazine;
        }

        public void setMagazine(GunPartMagazine magazine) {
            this.magazine = magazine;
        }

        public GunPartMod getMod() {
            return mod;
        }

        public void setMod(GunPartMod mod) {
            this.mod = mod;
        }

        public GunPartSight getSight() {
            return sight;
        }

        public void setSight(GunPartSight sight) {
            this.sight = sight;
        }

        public GunPartStock getStock() {
            return stock;
        }

        public void setStock(GunPartStock stock) {
            this.stock = stock;
        }

        public GunPartTrigger getTrigger() {
            return trigger;
        }

        public void setTrigger(GunPartTrigger trigger) {
            this.trigger = trigger;
        }

        public float getLevel() {
            float total = 0;

            total += barrel.getLevel();
            total += body.getLevel();
            total += magazine.getLevel();
            total += mod.getLevel();
            total += sight.getLevel();
            total += stock.getLevel();
            total += trigger.getLevel();

            total = total / 7.0f;
            total = Mathf.Round(total);

            return total;
        }

        /**
         * Return the total damage from body barrel
        */
        public float getDamage() {
            return body.getBaseDamage() * barrel.getDamageBoost();
        }

        /**
         * Return the ammunition from body
        */
        public AmmunitionType getAmmunitionType() {
            return body.getAmmunitionType();
        }

        /**
         * Return damage type from mod
        */
        public DamageType getDamageType() {
            return mod.getDamageType();
        }

        /**
         * Return rate of fire from trigger
        */
        public float getFireRate() {
            return trigger.getFireRate();
        }

        /**
         * Return firing mode from trigger
        */
        public FiringMode getFiringMode() {
            return trigger.getFiringMode();
        }

        /**
         * Return capacity from magazine
        */
        public float getCapacity() {
            return magazine.getCapacity();
        }

        /**
         * Return reload speed from magazine
        */
        public float getReloadSpeed() {
            return magazine.getReloadSpeed();
        }

        /**
         * Return projectile speed from barrel
        */
        public float getProjectileSpeed() {
            return barrel.getProjectileSpeed();
        }
    }
}