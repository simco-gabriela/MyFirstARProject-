using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    private Vector3 resetPosition = new Vector3(3, 0.5f, 2);
    public ParticleSystem particleSystem;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hole"))
        {
            scoreManager.Instance.AddPoint();
            if (particleSystem != null)
            {
                particleSystem.Play();
            }
            transform.position = resetPosition;
        }
    }
}
