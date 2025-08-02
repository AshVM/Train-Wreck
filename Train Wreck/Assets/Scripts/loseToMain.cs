using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseToMain : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("MainScene");
    }
}
