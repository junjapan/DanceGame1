using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleportation : MonoBehaviour
{
    public float moveTime = 3.0f;
    public float rangeX = 5.0f;
    public float rangeZ = 5.0f;
    float time;
    float vecX;
    float vecZ;
    Vector3 startPosition; 

    void Start()
    {
        startPosition = gameObject.transform.position;
        time = moveTime;
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            vecX = Random.Range(-rangeX, rangeX);
            vecZ = Random.Range(-rangeZ, rangeZ);
            gameObject.transform.position = startPosition + new Vector3(vecX, 0.5f, vecZ);
            time = moveTime;
        }
    }
}
