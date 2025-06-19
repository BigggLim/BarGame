using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldF_Spawner : MonoBehaviour
{
    public GameObject oldF;
    
    static int amt = 0;
    bool canSpawn;

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            Spawner();
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        canSpawn = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canSpawn = false;
    }

    void Spawner()
    {
        if (Input.GetKeyDown(KeyCode.E)  && amt == 0 && canSpawn == true)
        {
            GameObject oldFa = Instantiate(oldF, new Vector3(5.24f, 3.2f, 12.9f), Quaternion.identity);
            oldFa.name = "OldF";
            
            amt++;


        }/*
        else if (Input.GetKeyDown(KeyCode.E) && amt == 1 && canSpawn == true)
        {
            GameObject oldFa = Instantiate(oldF, new Vector3(5.54f, 3.2f, 12.9f), Quaternion.identity);
            oldFa.name = "OldF";
            
            amt++;
        }
        else if (Input.GetKeyDown(KeyCode.E) && amt == 2 && canSpawn == true)
        {
            GameObject oldFa = Instantiate(oldF, new Vector3(5.84f, 3.2f, 12.9f), Quaternion.identity);
            oldFa.name = "OldF";
            
            amt++;
        }*/
        if (Input.GetKeyDown(KeyCode.E)  && amt >= 1)
        {
            Debug.Log("Max drinks hit");

        }

    }
    void Receiver()
    {
        amt--;
    }
}
