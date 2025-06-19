using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CusCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Physics.IgnoreLayerCollision(7,7);
        }
    }
}
