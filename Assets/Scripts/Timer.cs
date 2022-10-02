using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    private Label timerLabel;

    void OnEnable(){
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        timerLabel = rootVisualElement.Q<Label>("TimerLabel");
        // Debug.Log("Counter");
        // player = GameObject.Find("Player");
    }

    void Update(){
        Debug.Log("!");
    }

    public void RefreshTimer(float timeLeft){
        timerLabel.text = timeLeft.ToString("F1");
    }
}
