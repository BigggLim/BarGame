using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee_Spawner : MonoBehaviour
{
    public GameObject tempCoffee;
    
    static int amt = 0;
    bool canSpawn;

    
    void Start()
    {
        canSpawn = false;
        
    }

    
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
        if (Input.GetKeyDown(KeyCode.E) && amt == 0 && canSpawn == true)
        {
            GameObject coffee = Instantiate(tempCoffee, new Vector3(-3.9f, 3.181f, 13), Quaternion.identity);
            coffee.name = "Coffee";
            
            amt++;


        }
        /*else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 1 && canSpawn == true)
        {
            GameObject coffee = Instantiate(tempCoffee, new Vector3(-4.2f, 3.181f, 13), Quaternion.identity);
            coffee.name = "Coffee";

            amt++;
        }
        else if (Input.GetKeyDown(KeyCode.E) && exist == false && amt == 2 && canSpawn == true)
        {
            GameObject coffee = Instantiate(tempCoffee, new Vector3(-4.5f, 3.181f, 13), Quaternion.identity);
            coffee.name = "Coffee";
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



