using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string firstLevel;
    
    public Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<PlayButton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }
}
