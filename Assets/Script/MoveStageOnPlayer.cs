using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStageOnPlayer : MonoBehaviour
{
    
    public float upForce = 100f;
    
    void OnCollisionEnter(Collision col)
    {
        if (transform.parent == null &&
            (col.gameObject.name == "MoveStage"
            || col.gameObject.name == "MoveStage1"
            || col.gameObject.name == "MoveStage2"
            || col.gameObject.name == "MoveStage3"
            || col.gameObject.name == "MoveStage4"))
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (transform.parent != null &&
            (col.gameObject.name == "MoveStage"
            || col.gameObject.name == "MoveStage1"
            || col.gameObject.name == "MoveStage2"
            || col.gameObject.name == "MoveStage3"
            || col.gameObject.name == "MoveStage4"))
        {
            transform.parent = null;
        }
    }
}
