using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("Fall", 1);
            Invoke("FallStop", 5);
        }
    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

    void FallStop()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
