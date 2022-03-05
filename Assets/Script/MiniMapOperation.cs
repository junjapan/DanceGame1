using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapOperation : MonoBehaviour
{
    public GameObject miniMapImage;

    void Start()
    {
        miniMapImage = GameObject.Find("MiniMapImage");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.V)) //Vボタン
        {
            miniMapImage.GetComponent<MiniMapController>().MiniMapOn();
        }   

        if (Input.GetKey(KeyCode.B)) //Bボタン
        {
            miniMapImage.GetComponent<MiniMapController>().MiniMapOff();
        }
            
    }
}
