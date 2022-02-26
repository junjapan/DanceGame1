using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage : MonoBehaviour
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
        float x = amplitude * Mathf.Sin(Time.time * speed);

        //xを変化させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(x, 0, 0);

    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.SetParent(this.transform);
    }

    void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
    */
}
