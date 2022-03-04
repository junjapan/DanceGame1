using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Attack : MonoBehaviour
{
    Animator animator;
    CharacterController cc;
    Vector3 velocity;
    Collider handCollider;
    [SerializeField]
    float walkSpeed;

    //音声ファイルを入れる。
    public AudioClip[] sound;

    //audioSourceコンポーネントを入れる変数
    AudioSource audioSource;
  
   

    void Start() {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
        velocity = Vector3.zero;
//        handCollider = GameObject.Find("Character1_LeftHand").GetComponent<SphereCollider>();
        handCollider = GameObject.Find("Character1_RightHand").GetComponent<SphereCollider>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.A) && !animator.GetCurrentAnimatorStateInfo(0).IsName("Punch") && !animator.IsInTransition(0)) {
            animator.SetTrigger("Punch");
            handCollider.enabled = true;
            Invoke("ColliderReset", 0.3f);
            AttackSound();
        }
    }

    void ColliderReset() {
        handCollider.enabled = false;
    }
    public void AttackSound()
    {
        //音声を鳴らす
        audioSource.PlayOneShot(sound[0]);

    }
}
