using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    //GameObject型を変数pointで宣言します。
    public GameObject telepoOut;
    //GameObject型を変数charaで宣言します。
    public GameObject player;

    //コライダーが乗った時の関数
    private void OnTriggerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触した時の処理。
        if (other.name == player.name)
        {
            //Charaが接触したらpointオブジェクトの位置に移動するよ！
            player.transform.position = telepoOut.transform.position;

        }
    }
}
