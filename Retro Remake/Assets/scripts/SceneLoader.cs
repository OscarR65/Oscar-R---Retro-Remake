using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1;
    }

 
    
}
