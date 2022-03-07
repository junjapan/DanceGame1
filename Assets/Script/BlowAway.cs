using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowAway : MonoBehaviour
{
    public GameObject effectPrefab;

    void OnCollisionEnter(Collision other)
    {
        //コライダに触れているオブジェクトのRigidbodyコンポーネントを取得
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        //ボールがどの方向にあるかを計測
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        //タグに応じてボールに力を加える
        if (other.gameObject.tag == "Player")
        {
            //r.AddForce(direction * 80.0f, ForceMode.Acceleration); //じわじわ
            r.AddForce(direction * 20.0f, ForceMode.Impulse); //瞬間的に

            //エフェクト用
            if (effectPrefab != null)
            {
                Instantiate(
                    effectPrefab,
                    other.transform.position,
                    Quaternion.Euler(transform.forward)
                    );
            }


        }

        
    }
}
