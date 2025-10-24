using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLoadsStart : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("StartScene");
    }
}
