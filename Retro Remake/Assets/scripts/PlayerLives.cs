using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public GameObject explosionPrefab;
    public GameObject gameOverPanel;

    public PointManager scoreManager;
    public float explosionTime = 3f;

    public float maxIFrames;
    private float iFrameTime;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(iFrameTime > 0)
        {
            iFrameTime -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, explosionTime);
            lives -= 1;
            ShipSpawner.enemiesLeft--;
            for(int i = 0; i < livesUI.Length; i++)
            {
                if(i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                scoreManager.HighScoreUpdate();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy Projectile")
        {
            if (iFrameTime > 0)
            {
                return;
            }

            iFrameTime = maxIFrames;

            Destroy(collision.gameObject);
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(explosion, explosionTime);
            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                scoreManager.HighScoreUpdate();
            }
        }
    }
}

