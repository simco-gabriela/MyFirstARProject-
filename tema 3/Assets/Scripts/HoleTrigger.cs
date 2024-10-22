using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
        }
    }
}
