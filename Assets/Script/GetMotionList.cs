using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMotionList : MonoBehaviour
{
    public List<string> motionList = new List<string>();

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
}
