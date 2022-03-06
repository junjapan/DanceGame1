using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage5 : MonoBehaviour
{
    int counter = 0;
    float move = 0.1f;

    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if (counter == 50)
        {
            counter = 0;
            move *= -1;
        }
    }

}
