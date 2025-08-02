using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (remainingTime <= 0)
        {
            remainingTime = 1;
            SceneManager.LoadScene("LoseScene");
        }



        remainingTime -= Time.deltaTime;
        //timerText.text = elapsedTime.ToString();

        int mins = Mathf.FloorToInt(remainingTime / 60);
        int secs = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{00:00}:{1:00}", mins, secs);
    }
}
