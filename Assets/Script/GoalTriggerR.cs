﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GoalTriggerR : MonoBehaviour 
{
    private int count;
    private int goalCount;
    public Text countText;
    public Text winText;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

        if (other.gameObject.CompareTag("GoalR"))
        {
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            goalCount++;
            if (goalCount>=4)
            {
                winText.text = "Win!";
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Score:" + count.ToString();
    }
}
