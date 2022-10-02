using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apocalypse : MonoBehaviour
{

    private enum Method {FireRain, FloorSpikes, Arrows}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApocalypseNow(){
        int numberOfMethods = System.Enum.GetValues(typeof(Method)).Length;
        Method currentMethod = (Method)Random.Range(0, numberOfMethods);
        Debug.Log("Method: " + currentMethod);
    }
}
