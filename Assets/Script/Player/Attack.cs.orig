using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator animator;
    CharacterController cc;
    Vector3 velocity;
    [SerializeField]
    float walkSpeed;

    void Start()
    {
        animator = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !animator.GetCurrentAnimatorStateInfo(0).IsName("Punch") && !animator.IsInTransition(0)) {
            animator.SetTrigger("Punch");
        }
    }
}
