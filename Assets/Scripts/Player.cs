using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public int tokens;

    public UIDocument gui;
    public Counter tokenCounterGUI;

    // Start is called before the first frame update
    void Start()
    {
        tokenCounterGUI = gui.GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToken(int value = 1){
        tokens += value;
        Debug.Log("Tokens: " + tokens);
        // Debug.Log("I got a token");
        tokenCounterGUI.RefreshCounter(tokens);
    }
}
