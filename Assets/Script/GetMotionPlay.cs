using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMotionPlay : MonoBehaviour
{
    public GetMotionList getMotionList;

    void Start() {
        getMotionList.anim = GetComponent<Animator>();
    }

    void Update() {
        if (!Input.GetKeyDown(KeyCode.A) &&
           !Input.GetKey(KeyCode.UpArrow) &&
           !Input.GetKey(KeyCode.DownArrow) &&
           !Input.GetKey(KeyCode.RightArrow) &&
           !Input.GetKey(KeyCode.LeftArrow) &&
//           (!getMotionList.anim.GetBool("Dance01") ||
//            !getMotionList.anim.GetBool("Dance02")
//            )
//           &&
           !Input.GetKey(KeyCode.Space)
           ) {
            foreach (string s in getMotionList.motionList) {
                string str = s.Substring(10,7);
//                Debug.Log(str);
                getMotionList.anim.SetBool(str, true);
            }
        } else {
            foreach (string s in getMotionList.motionList) {
                string str = s.Substring(10,7);
                getMotionList.anim.SetBool(str, false);
            }
        }
    }
}
