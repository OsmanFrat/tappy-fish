using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite metalMedal, bronzeMedal, silverMedal, goldMedal;
    Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        int gameScore = GameManager.gameScore;

        if(gameScore > 0 && gameScore <= 4)
        {
            img.sprite = metalMedal;
        }
        else if(gameScore > 4 && gameScore <= 8)
        {
            img.sprite = bronzeMedal;
        }
        else if(gameScore > 8 && gameScore <= 12)
        {
            img.sprite = silverMedal;
        }
        else if(gameScore > 12)
        {
            img.sprite = goldMedal;
        }
    }
}
