/*
 * Zechariah Burrus
 * Assignment 6
 * Causes the enemies to chase you
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIController : MonoBehaviour {
    public Transform Player;
    int moveSpeed = 4;
    int MinDist = 1;

    // Update is called once per frame
    void Update() {
        transform.LookAt(Player);

        if(Vector3.Distance(transform.position, Player.position) >= MinDist) {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
