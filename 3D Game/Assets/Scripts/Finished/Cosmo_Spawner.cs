using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmo_Spawner : MonoBehaviour
{
    public GameObject cosmo;
    
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
            GameObject cosmop = Instantiate(cosmo, new Vector3(1.25f, 3.22f, 13), Quaternion.identity);
            cosmop.name = "Cosmo";
            
            amt++;


        }
       /* else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 1 && canSpawn == true)
        {
            GameObject cosmop = Instantiate(cosmo, new Vector3(1.55f, 3.22f, 13), Quaternion.identity);
            cosmop.name = "Cosmo";
            exist = false;
            amt++;
        }
        else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 2 && canSpawn == true)
        {
            GameObject cosmop = Instantiate(cosmo, new Vector3(1.85f, 3.22f, 13), Quaternion.identity);
            cosmop.name = "Cosmo";
            exist = true;
            amt++;
        }*/
        if (Input.GetKeyDown(KeyCode.E) && amt >= 1)
        {
            Debug.Log("Max drinks hit");

        }
    }

    void Receiver()
    {
        amt--;
    }
}
