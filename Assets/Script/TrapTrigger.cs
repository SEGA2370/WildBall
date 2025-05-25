using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] Animator trapAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
           trapAnimation.SetBool("Trap", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            trapAnimation.SetBool("Trap", false);
    }
}
