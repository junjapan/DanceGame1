using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMotionList : MonoBehaviour
{
    public List<string> motionList = new List<string>();
    Animator anim;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Animator animator = other.gameObject.GetComponent<Animator>();
            RuntimeAnimatorController ac = animator.runtimeAnimatorController;
            int count = 0;
            while(count < ac.animationClips.Length)
            {
                motionList.Add(ac.animationClips[count].name);
                Debug.Log(ac.animationClips[count].name);
                count++;
            }
                    
            
            Destroy(other.gameObject);
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //        if (Input.GetKeyDown(KeyCode.A) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Punch") && !anim.IsInTransition(0))
        if (!Input.GetKeyDown(KeyCode.A) &&
            !Input.GetKey(KeyCode.UpArrow) && 
            !Input.GetKey(KeyCode.DownArrow) && 
            !Input.GetKey(KeyCode.RightArrow) && 
            !Input.GetKey(KeyCode.LeftArrow) &&
            (!anim.GetBool("Dance01") ||
             !anim.GetBool("Dance02")
             )
            &&
            !Input.GetKey(KeyCode.Space)
            )
        {
            foreach(string s in motionList)
            {
                string str = s.Substring(10);
                Debug.Log(str);
                anim.SetBool(str, true);
            }
        }
        else
        {
            foreach (string s in motionList)
            {
                string str = s.Substring(10);
                anim.SetBool(str, false);
            }
        }
    }

}
