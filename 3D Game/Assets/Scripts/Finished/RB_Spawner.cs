using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RB_Spawner : MonoBehaviour
{
    public GameObject rootBeer;
    
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

    private void OnTriggerEnter(Collider Trigger)
    {
        canSpawn = true;
    }
    private void OnTriggerExit(Collider Trigger)
    {
        canSpawn = false;
    }
    void Spawner()
    {
        if (Input.GetKeyDown(KeyCode.E) && amt == 0 && canSpawn == true)
        {
            GameObject rootBeerMug = Instantiate(rootBeer, new Vector3(-6, 3.21f, 13), Quaternion.identity);
            
            rootBeerMug.name = "rootBeer";
            
            amt++;


        }
       /* else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 1 && canSpawn == true)
        {
            GameObject rootBeerMug = Instantiate(rootBeer, new Vector3(-6, 3.21f, 13), Quaternion.identity);
            
            rootBeerMug.name = "rootBeer2";
            exist = false;
            amt++;
        }
        else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 2 && canSpawn == true)
        {
            GameObject rootBeerMug = Instantiate(rootBeer, new Vector3(-6.5f, 3.21f, 13), Quaternion.identity);
            
            rootBeerMug.name = "rootBeer3";
            exist = true;
            amt++;
        }*/
        if (Input.GetKeyDown(KeyCode.E)  && amt >= 1)
        {
            Debug.Log("no more");

        }
    }

    void Receiver()
    {
        amt--;
    }
}

