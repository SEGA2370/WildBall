using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollow : MonoBehaviour
{
    [SerializeField] Transform player;

    void Update()
    {
        transform.position = player.position;
    }

}
