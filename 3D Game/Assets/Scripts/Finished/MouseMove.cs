using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float mouseSensitivity = 100f;
  
    
    public Transform playerBody;

    float xRotation = 0f;
    
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            float mouseX = Input.GetAxis("Mouse X") + mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") + mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        
       
    }
}
