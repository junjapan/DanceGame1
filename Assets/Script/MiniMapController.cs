using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapController : MonoBehaviour
{
    public void MiniMapOn()
    {
        gameObject.SetActive(true);
    }

    public void MiniMapOff()
    {
        gameObject.SetActive(false);
    }
}
