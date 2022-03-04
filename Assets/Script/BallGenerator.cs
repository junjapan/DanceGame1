using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Ball");
    }

    IEnumerator Ball()
    {
        for(int i = 0; i < 500; i++)
        {
            Instantiate(ball, transform.position, transform.transform.rotation);

            yield return new WaitForSeconds(6f);
        }
    }
}
