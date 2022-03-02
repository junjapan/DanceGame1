using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage4 : MonoBehaviour
{
    /*
    Vector3 startPosition;

    public float amplitude;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //変位を計測
        float y = amplitude * Mathf.Sin(Time.time * speed);

        //yを変化させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(0, y, 0);

    }
    */

    int counter = 0;
    float move = -0.05f;

    void Update()
    {
        Vector3 p = new Vector3(0, move, 0);
        transform.Translate(p);
        counter++;

        if (counter == 200)
        {
            counter = 0;
            move *= -1;
        }
    }
}
