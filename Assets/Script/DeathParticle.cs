using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticle : MonoBehaviour
{
    ParticleSystem death;
   
    void Start()
    {
        death = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DeathTrigger"))
        {
            death.Play();
        }
    }
}
