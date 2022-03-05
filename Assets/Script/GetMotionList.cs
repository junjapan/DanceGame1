using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMotionList : MonoBehaviour
{
    public List<string> motionList = new List<string>();
    public Animator anim;
    Collider handCollider;

    //エフェクト用
    public GameObject effectPrefab;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemy") {
            Animator animator = other.gameObject.GetComponent<Animator>();
            RuntimeAnimatorController ac = animator.runtimeAnimatorController;
            int count = 0;
            while (count < ac.animationClips.Length) {
                motionList.Add(ac.animationClips[count].name);
                Debug.Log(ac.animationClips[count].name);
                count++;
            }
            Destroy(other.gameObject);

            //エフェクト用
            if(effectPrefab != null)
            {
                Instantiate(
                    effectPrefab,
                    other.transform.position,
                    Quaternion.Euler(transform.forward)
                 );
            }
        }
    }

    void Start() {
//        handCollider = GameObject.Find("Character1_LeftHand").GetComponent<SphereCollider>();
        handCollider = GameObject.Find("Character1_RightHand").GetComponent<SphereCollider>();
    }

    void Update() {
    }
}
