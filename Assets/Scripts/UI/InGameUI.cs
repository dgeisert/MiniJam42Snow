using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void UpdateScore(float val)
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(val / 60) + ": " + ((Mathf.FloorToInt(val % 60) < 10) ? "0" : "") + Mathf.FloorToInt(val % 60);
    }
    public void EndGame(bool victory)
    {
        gameObject.SetActive(false);
    }
}