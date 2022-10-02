using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    private Label counterLabel;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        counterLabel = rootVisualElement.Q<Label>("TokensLabel");
    }

    public void RefreshCounter(int tokens){
        counterLabel.text = $"Tokens: {tokens}";
    }
}
