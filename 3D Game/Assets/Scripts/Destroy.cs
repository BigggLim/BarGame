using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        
            Destroy(other.gameObject);
            if(other.tag == "Cus1")
        {
            GameObject.FindGameObjectWithTag("Spawner").SendMessage("Custom1");
        }
        if (other.tag == "Cus2")
        {
            GameObject.FindGameObjectWithTag("Spawner").SendMessage("Custom2");
        }
        if (other.tag == "Cus3")
        {
            GameObject.FindGameObjectWithTag("Spawner").SendMessage("Custom3");
        }
        if (other.tag == "Cus4")
        {
            GameObject.FindGameObjectWithTag("Spawner").SendMessage("Custom4");
        }


    }
}
