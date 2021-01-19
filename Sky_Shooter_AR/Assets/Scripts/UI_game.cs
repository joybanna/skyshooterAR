using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_game : MonoBehaviour
{
    public GameObject UIpause;
    public GameObject UIend;
    // Start is called before the first frame update
    void Start()
    {
        //UIpause = GameObject.FindGameObjectWithTag("UI_pause");
       // UIend = GameObject.FindGameObjectWithTag("UI_end");

        UIend.SetActive(false);
        UIpause.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        UIpause.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ContinueGame()
    {
        UIpause.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
