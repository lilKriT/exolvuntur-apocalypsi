using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CountDown : MonoBehaviour
{
    const float countDownTime = 10.0f;
    public float timeLeft;

    public UIDocument gui;
    public Timer timerGUI;

    // Start is called before the first frame update
    void Start()
    {
        timerGUI = gui.GetComponent<Timer>();
        timeLeft = countDownTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0){
            timeLeft = countDownTime;
            Debug.Log("Cataclysm!");
        }

        timerGUI.RefreshTimer(timeLeft);
    }
}
