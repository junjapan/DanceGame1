using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Actions : MonoBehaviour
{
    float countTime = 0;

    public GameObject player;
    GetMotionList motions;

    void Start()
    {
        motions = player.gameObject.GetComponent<GetMotionList>();
    }

    // Update is called once per frame
    void Update()
    {



        List<string> actions = motions.motionList;

        string[] array = actions.ToArray();

        for (int i = 0; i <= array.Length; i++)
        {

            GetComponent<Text>().text = string.Join("\n", array);
        }
    }


}
