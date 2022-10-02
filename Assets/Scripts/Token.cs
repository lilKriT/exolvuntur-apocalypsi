using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Token exists");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        // Debug.Log(collider.gameObject.name);
        if(collider.gameObject.name == "Player Mesh"){
            Debug.Log("Token Picked up");
        }
    }
}
