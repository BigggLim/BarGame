using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
  
    [SerializeField] private string doorOpen = "DoubleDoorOpen";
    [SerializeField] private string doorClose = "DoubleDoorClose";
    private void OnTriggerEnter(Collider other)
    {
        
        
           
                myDoor.Play(doorOpen, 0, 0.0f);
               
             
         
        
    }
    private void OnTriggerExit(Collider other)
    {
       
        
            myDoor.Play(doorClose, 0, 0.0f);
            

    }
}
