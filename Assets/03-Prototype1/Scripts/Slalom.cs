using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slalom : MonoBehaviour
{
    public bool ready = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        
        if ( Input.GetMouseButtonUp(0) ) { 

            // The mouse has been released

            ready = false;
            EventManager.OnTimerStart();



        }

    }
}