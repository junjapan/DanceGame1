using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomWalk : MonoBehaviour
{
    public float changeTime = 5.0f;
    float timeCount;

    void Update()
    {
        timeCount += Time.deltaTime;

        transform.position += transform.forward * Time.deltaTime;

        if (timeCount > changeTime)
        {
            Vector3 course = new Vector3(0,Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);

            timeCount = 0;
        }
    }
}
