using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    public void OnEnable()
    {
        TimeManager.OnMinuteChanged += TimeCheck;
    }

    public void OnDisable()
    {
        TimeManager.OnMinuteChanged -= TimeCheck;
    }

    private void TimeCheck()
    {
        if(TimeManager.Minute > 35) 
        {
            gameOverText.enabled = true;
        }

    }

    void Start () 
    {
        gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
