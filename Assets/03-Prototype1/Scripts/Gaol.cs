using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaol : MonoBehaviour
{
    public bool goalMet = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Goal.goalMet = true;

            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
        }
    }

    
}
