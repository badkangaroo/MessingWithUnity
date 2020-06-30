using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotateTrigger : MonoBehaviour
{
    public Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        animator.SetTrigger("StartRotate");
    }
}
