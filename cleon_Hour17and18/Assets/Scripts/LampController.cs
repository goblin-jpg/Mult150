using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            animator.SetTrigger("Recolor");
        }
        if (Input.GetKeyDown(KeyCode.D)){
            animator.SetTrigger("Scale");
        }
        if (Input.GetKeyDown(KeyCode.S)){
            animator.SetTrigger("Spin");
        }
        if (Input.GetKeyDown(KeyCode.W)){
            animator.SetTrigger("Float");
        }
    }
}
