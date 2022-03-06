using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
    int counter = 0;
    public int range;
    float move = 0.1f;
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if (counter == range)
        {
            counter = 0;
            transform.position = startPosition;
        }
    }
}
