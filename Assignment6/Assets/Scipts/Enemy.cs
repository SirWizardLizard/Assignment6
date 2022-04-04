/*
 * Zechariah Burrus
 * Assignment 6
 * Enemy super-class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable {
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake() {
        weapon = gameObject.AddComponent<Weapon>();
        weapon.damageBonus = 10;
        speed = 5f;
        health = 100;
    }

    protected abstract void Attack(int amount);

    public abstract void takeDamage(int amount);

    void Start() {

    }
}
