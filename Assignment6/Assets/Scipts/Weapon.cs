/*
 * Zechariah Burrus
 * Assignment 6
 * Generic weapon
 */

using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake() {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy) {
        Debug.Log("Enemy eats a weapon!");
    }

    public void Recharge() {
        Debug.Log("Rechargin weapon.");
    }
}
