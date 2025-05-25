using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    private Animator anim; 
    private void Awake()
    {
        anim = GetComponent<Animator>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Collect");
        Destroy(gameObject, 1f);
    }
}
