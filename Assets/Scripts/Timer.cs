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
    }

    void Update(){
    
    }

    public void RefreshTimer(float timeLeft){
        timerLabel.text = timeLeft.ToString("F1");
    }
}
