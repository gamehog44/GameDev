﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{
    public Text rockText;
    public Text stickText;

    protected int rockNumber = 5;
    protected int stickNumber = 3;

    void Update()
    {
    }
 
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (other.CompareTag("RockPile")) {
                rockNumber++;
                rockText.text = "Rocks: " + rockNumber;
                Destroy(other.gameObject);
            }
            else if (other.CompareTag("StickPile")) {
                stickNumber++;
                stickText.text = "Sticks: " + stickNumber;
                Destroy(other.gameObject);
            }

        }
    }
}
