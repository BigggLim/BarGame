using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    public Transform dest1;
    public Transform dest2;
    public Transform dest3;
    bool slot1 = false;
    // bool slot2 = false;
    //bool slot3 = false;

    RB_Spawner amts;
    
    
    RaycastHit hit;
    int layerMask = 1 << 3;
    int layerMask2 = 1 << 7;
    [SerializeField] GameObject drank;
    

    void Start()
    {



    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10, layerMask))
            {

                drank = hit.transform.gameObject;
                Drink();

            }
            else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5, layerMask2))
            {
                if (drank != null)
                {
                    Sell();
                }
                
            }


        }
    }
        void Drink()
        {
            if (hit.transform.tag == "Drink")
            {
                if (slot1 == false)
                {
                    Debug.Log("HitDrink");

                    drank.transform.position = dest1.position;
                    drank.transform.parent = dest1.transform;
                    slot1 = true;
                    
                }
                /* else if (slot1 == true && slot2 == false)
                 {
                     Debug.Log("HitDrink1");

                     drank.transform.position = dest2.position;
                     drank.transform.parent = dest2.transform;
                     slot2 = true;
                 }
                 else if (slot1 == true && slot2 == true && slot3 == false)
                 {
                     Debug.Log("HitDrink2");

                     drank.transform.position = dest3.position;
                     drank.transform.parent = dest3.transform;
                     slot3 = true;
                 }
                 if (slot1 == true && slot2 == true && slot3 == true)
                 {
                     Debug.Log("Tray Full");
                 } */
            }

        }

        void Sell()
        {
            
            if (hit.transform.tag == "Cus1")
            {
                if (drank.name == "rootBeer" && slot1 == true)
                {
                    Destroy(GameObject.Find("rootBeer"));
                    slot1 = false;
                    GameObject.Find("Money").SendMessage("MoneyUpdate", 5);
                    drank = null;
                    
                    GameObject.FindGameObjectWithTag("Cus1").SendMessage("UpdateLeave", true);
                    GameObject.FindGameObjectWithTag("Cus1").SendMessage("MoveUpdate", false);
                    GameObject.FindGameObjectWithTag("Barrel").SendMessage("Receiver");


            }
               /* else if (drank.name == "rootBeer2" && slot1 == true)
                {
                    Destroy(GameObject.Find("rootBeer2"));
                    slot1 = false;
                    GameObject.Find("Money").SendMessage("MoneyUpdate", 5);
                    drank = null;
                    mover.move = false;
                    
                }
                else if (drank.name == "rootBeer3" && slot1 == true)
                {
                    Destroy(GameObject.Find("rootBeer3"));
                    GameObject.Find("Money").SendMessage("MoneyUpdate", 5);
                    
                    slot1 = false;
                    drank = null;
                    mover.move = false;
                    

                }*/
                else 
                {
                    Debug.Log("Need RB");
                }
            }
            else if (hit.transform.tag == "Cus2")
            {
                if (drank.name == "Coffee" && slot1 == true)
                {
                 Destroy(GameObject.Find("Coffee"));
                 slot1 = false;
                 GameObject.Find("Money").SendMessage("MoneyUpdate", 6);
                 drank = null;

                 GameObject.FindGameObjectWithTag("Cus2").SendMessage("UpdateLeave", true);
                 GameObject.FindGameObjectWithTag("Cus2").SendMessage("MoveUpdate", false);
                 GameObject.FindGameObjectWithTag("Kettle").SendMessage("Receiver");


                }
        }
            else if (hit.transform.tag == "Cus3")
            {

                if (drank.name == "Cosmo" && slot1 == true)
                {
                 Destroy(GameObject.Find("Cosmo"));
                 slot1 = false;
                 GameObject.Find("Money").SendMessage("MoneyUpdate", 8);
                 drank = null;

                 GameObject.FindGameObjectWithTag("Cus3").SendMessage("UpdateLeave", true);
                 GameObject.FindGameObjectWithTag("Cus3").SendMessage("MoveUpdate", false);
                 GameObject.FindGameObjectWithTag("Shaker").SendMessage("Receiver");


                }
        }
            else if (hit.transform.tag == "Cus4")
            {
                if (drank.name == "OldF" && slot1 == true)
                {
                    Destroy(GameObject.Find("OldF"));
                 slot1 = false;
                 GameObject.Find("Money").SendMessage("MoneyUpdate", 8);
                 drank = null;

                 GameObject.FindGameObjectWithTag("Cus4").SendMessage("UpdateLeave", true);
                 GameObject.FindGameObjectWithTag("Cus4").SendMessage("MoveUpdate", false);
                 GameObject.FindGameObjectWithTag("MixGlass").SendMessage("Receiver");


                 }
            }
        }

    
}
