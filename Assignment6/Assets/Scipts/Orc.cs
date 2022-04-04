/*
 * Zechariah Burrus
 * Assignment 6
 * Generic Orc enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy {
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake() {
        base.Awake();
        health = 250;
        GameManager.Instance.score += 10;
    }

    protected override void Attack(int amount) {
        Debug.Log("ORC Attacks!");
    }

    public override void takeDamage(int amount) {
        Debug.Log("You took " + amount + " points of damage!");
    }
}
