using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slalom : MonoBehaviour
{
    public bool ready = true;
    public GameObject player;
    public Gaol gaol;
    private Vector3 offset;
    public GameObject finalPos;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update() {

        if (ready)
        {
            if ( Input.GetMouseButtonUp(0) ) { 

                // The mouse has been released

                ready = false;
                EventManager.OnTimerStart();
                player.GetComponent<Rigidbody>().isKinematic = false;

            }
        }
        
    }

    void LateUpdate()
    {
        if (!ready)
        {
            transform.position = player.transform.position + offset; 
        }
    }
}
