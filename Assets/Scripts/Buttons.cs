using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public int gameStartScene;

    public void startgame()
    {
        SceneManager.LoadScene(gameStartScene);
    }
}
