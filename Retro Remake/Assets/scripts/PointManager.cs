using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    public GameObject levelChange;

    

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    private void Update()
    {
        if(ShipSpawner.enemiesLeft == 0)
        {
            Time.timeScale = 0;
            levelChange.SetActive(true);
        }
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
   
    }


    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", score);

            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", score);

        }
       
        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();

    } 


}
