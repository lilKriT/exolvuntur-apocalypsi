using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public int value = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        // Debug.Log(collider.gameObject.name);
        if(collider.gameObject.name == "Player Mesh"){
            // Debug.Log("Token Picked up");
            Player p = collider.transform.parent.GetComponent<Player>();
            p.AddToken(value);
            Destroy(this.gameObject);
        }
    }
}
