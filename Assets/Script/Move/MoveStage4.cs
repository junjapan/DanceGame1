using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage4 : MonoBehaviour
{
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
}
