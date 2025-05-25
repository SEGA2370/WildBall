using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl_4_ShieldAnimController : MonoBehaviour
{
    [SerializeField] Animator shieldAnimator;

    void Start()
    {
        shieldAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            shieldAnimator.Play("Lvl_4_ShieldAnimation");
    }
}