using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Requests : MonoBehaviour
{
    public GameObject request;
    public bool show = false;
   

    private void Start()
    {
        request.SetActive(false);
    }


    private void OnTriggerExit(Collider other)
    {
        if(show == false)
        {
            request.SetActive(true);
            show = true;

        }
        
       
    }



}
