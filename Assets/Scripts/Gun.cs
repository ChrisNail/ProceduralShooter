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
        //Trigger currently down
        private bool isTriggered = false;
        //Trigger was down last frame
        private bool isFiring = false;
        //The amount of shots that have been charged by the gun
        private int chargedShots = 0;
        //Amount of time before next shot
        private float speedTimer = 0.0f;
        //Player has the weapon equipped
        private bool isEquipped;

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

        }

        public void Fire(bool isTriggered) {
            if (!isTriggered) {
                isFiring = false;
            }

            if (checkSpeedTimer() && GetFiringMode().CanFire(isTriggered, isFiring)) {
                if (ConsumeAmmo()) {
                    
                }
            }


            isFiring = isTriggered;
        }

        public bool ConsumeAmmo() {
            if (ammo > GetAmmunitionType().GetConsumedAmmo()) {
                ammo -= GetAmmunitionType().GetConsumedAmmo();
                
                return true;
            }

            return false;
        }

        public bool IsFiring() {
            return isFiring;
        }

        public void SetFiring(bool isFiring) {
            this.isFiring = isFiring;
        }

        public bool ToggleIsFiring() {
            isFiring = !isFiring;

            return isFiring;
        }

        public int GetChargedShots() {
            return chargedShots;
        }

        public void SetChargedShots(int chargedShots) {
            this.chargedShots = chargedShots;
        }

        public bool CheckSpeedTimer() {
            if (speedTimer > 0.0f)
                speedTimer -= Time.deltaTime;
            if(speedTimer < 0.0f)
                speedTimer = 0.0f;
            return speedTimer == 0.0f;
        }

        public GunPartBarrel GetBarrel() {
            return barrel;
        }

        public void SetBarrel(GunPartBarrel barrel) {
            this.barrel = barrel;
        }

        public GunPartBody GetBody() {
            return body;
        }

        public void SetBody(GunPartBody body) {
            this.body = body;
        }

        public GunPartMagazine GetMagazine() {
            return magazine;
        }

        public void SetMagazine(GunPartMagazine magazine) {
            this.magazine = magazine;
        }

        public GunPartMod GetMod() {
            return mod;
        }

        public void SetMod(GunPartMod mod) {
            this.mod = mod;
        }

        public GunPartSight GetSight() {
            return sight;
        }

        public void SetSight(GunPartSight sight) {
            this.sight = sight;
        }

        public GunPartStock GetStock() {
            return stock;
        }

        public void SetStock(GunPartStock stock) {
            this.stock = stock;
        }

        public GunPartTrigger GetTrigger() {
            return trigger;
        }

        public void SetTrigger(GunPartTrigger trigger) {
            this.trigger = trigger;
        }

        public float GetLevel() {
            float total = 0;

            total += barrel.GetLevel();
            total += body.GetLevel();
            total += magazine.GetLevel();
            total += mod.GetLevel();
            total += sight.GetLevel();
            total += stock.GetLevel();
            total += trigger.GetLevel();

            total = total / 7.0f;
            total = Mathf.Round(total);

            return total;
        }

        /**
         * Return the total damage from body barrel
        */
        public float GetDamage() {
            return body.GetBaseDamage() * barrel.GetDamageBoost();
        }

        /**
         * Return the ammunition from body
        */
        public AmmunitionType GetAmmunitionType() {
            return body.GetAmmunitionType();
        }

        /**
         * Return damage type from mod
        */
        public DamageType GetDamageType() {
            return mod.GetDamageType();
        }

        /**
         * Return rate of fire from trigger
        */
        public float GetFireRate() {
            return trigger.GetFireRate();
        }

        /**
         * Return firing mode from trigger
        */
        public FiringMode GetFiringMode() {
            return trigger.GetFiringMode();
        }

        /**
         * Return capacity from magazine
        */
        public float GetCapacity() {
            return magazine.GetCapacity();
        }

        /**
         * Return reload speed from magazine
        */
        public float GetReloadSpeed() {
            return magazine.GetReloadSpeed();
        }

        /**
         * Return projectile speed from barrel
        */
        public float GetProjectileSpeed() {
            return barrel.GetProjectileSpeed();
        }
    }
}