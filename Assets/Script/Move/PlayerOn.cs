using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOn : MonoBehaviour
{
    Rigidbody rb;
    float upForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(transform.parent == null && col.gameObject.name == "MoveStage")
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if(transform.parent != null
            && col.gameObject.name == "MoveStage"
            || col.gameObject.name == "MoveStage1"
            || col.gameObject.name == "MoveStage2"
            || col.gameObject.name == "MoveStage3"
            || col.gameObject.name == "MoveStage4")
        {
            transform.parent = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector3(0, upForce, 0));
        }
    }
}
