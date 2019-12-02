﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject victoryDisplay;
    public GameObject defeatDisplay;
    public void EndGame(bool victory = false)
    {
        gameObject.SetActive(true);
        victoryDisplay.gameObject.SetActive(victory);
        defeatDisplay.gameObject.SetActive(!victory);
        scoreText.text = Mathf.FloorToInt(Game.Score / 60) + ": " + ((Mathf.FloorToInt(Game.Score % 60) < 10) ? "0" : "") + Mathf.FloorToInt(Game.Score % 60);
    }

    public void Restart()
    {
        SceneChanger.LoadScene(Scenes.Game);
    }
    public void Menu()
    {
        SceneChanger.LoadScene(Scenes.MainMenu);
    }
}