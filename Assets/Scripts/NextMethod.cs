using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NextMethod : MonoBehaviour
{
    private Label methodLabel;

    // Start is called before the first frame update
    void Start()
    {
        var rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        methodLabel = rootVisualElement.Q<Label>("MethodLabel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefreshMethod(string s){
        methodLabel.text = s;
    }
}
