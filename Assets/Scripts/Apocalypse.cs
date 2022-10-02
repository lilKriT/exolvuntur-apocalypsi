using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Apocalypse : MonoBehaviour
{
    public enum Method {FireRain, FloorSpikes, Arrows}
    public Method nextMethod;

    public UIDocument gui;
    public NextMethod methodGUI;

    Player player;

    // Start is called before the first frame update
    void Start()
    {
        methodGUI = gui.GetComponent<NextMethod>();
        nextMethod = PickNextMethod();

        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApocalypseNow(){
        Debug.Log("Method: " + nextMethod);
        nextMethod = PickNextMethod();
        // FireRain();
        FloorSpikes();
    }

    public Method PickNextMethod(){
        int numberOfMethods = System.Enum.GetValues(typeof(Method)).Length;
        Method nextMethod = (Method)Random.Range(0, numberOfMethods);
        methodGUI.RefreshMethod(nextMethod.ToString());
        return nextMethod;
    }

    public void FireRain(){
        RaycastHit hit;
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        Debug.Log(player.transform.position);
        if(Physics.Raycast(player.transform.position, Vector3.up, out hit, 100f, layerMask)){
            // Debug.Log("Not DED");
            // Debug.DrawRay(player.transform.position, Vector3.forward * hit.distance, Color.yellow, 2);
        } else {
            // Debug.DrawRay(player.transform.position, Vector3.forward * 100, Color.red, 2);
            // Debug.Log("DED");
        }
    }

    public void FloorSpikes(){
        if(player.transform.position.y > 3f){
            Debug.Log("Not DED");
        } else {
            Debug.Log("DED");
        }
    }
}
