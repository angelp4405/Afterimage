using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string firstLevel = "1";
    public string settings;
    
    public Button playButton;
    public Button settingButton;
    public GameObject SettingsUI;

    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();
        settingButton = GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void SettingsToggler()
    {
        if(SettingsUI.activeSelf == false)
        {
            SettingsUI.SetActive(true);
        }
    }
   
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
       
    }
}
