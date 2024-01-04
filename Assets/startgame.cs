using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public string levelName;

    public void loadgame()
    {
        SceneManager.LoadScene(levelName);
    }
}
