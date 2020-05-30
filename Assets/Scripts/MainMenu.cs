using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //file handles scenes changing and quiting and playing the game
    public void playGame(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
