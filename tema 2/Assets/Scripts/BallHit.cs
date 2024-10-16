using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallHit : MonoBehaviour
{
    public Rigidbody ballRigidbody;  
    private float forceMultiplier = 100f;  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("mingeee");
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                Vector3 clubVelocity = GetComponent<Rigidbody>().velocity;

                Vector3 hitDirection = collision.contacts[0].normal;

                Vector3 force = -hitDirection * clubVelocity.magnitude * forceMultiplier;
                ballRb.AddForce(force, ForceMode.Impulse);  
            }
        }
    }
}
