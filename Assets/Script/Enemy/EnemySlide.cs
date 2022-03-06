using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlide : MonoBehaviour
{
    int counter = 0;
    public int range;
    float move = 0.1f;

    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == range)
        {
            counter = 0;
            move *= -1;
        }
    }
}
