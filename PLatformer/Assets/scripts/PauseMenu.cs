using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if we press the excape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //pause the game
            //make the pause menu appear
            GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }

    }
    public void QuitGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void Resume()
    {
        //resume the game
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
    
}
