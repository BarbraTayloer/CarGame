using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void PlayBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void HighscoresBtn(string scoreTable)
    {
        SceneManager.LoadScene(scoreTable);
    }

    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("clicked exit");
    }
}
