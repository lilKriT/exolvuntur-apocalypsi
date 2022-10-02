using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public int Tokens;

    public UIDocument gui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToken(int value = 1){
        Tokens += value;
        Debug.Log("Tokens: " + Tokens);
        // Debug.Log("I got a token");
    }
}
