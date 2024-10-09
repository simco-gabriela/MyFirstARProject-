using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;

    private AudioSource target1AudioSource;
    private AudioSource target2AudioSource;

    public float minimumDistance = 0.15f;

    private float lastTimePlayedTarget1 = 0f;
    private float lastTimePlayedTarget2 = 0f;

    void Start()
    {
        target1AudioSource = target1.GetComponent<AudioSource>();
        target2AudioSource = target2.GetComponent<AudioSource>();
    }

    void Update()
    {
        float distance = Vector3.Distance(target1.transform.position, target2.transform.position);

        if (distance <= minimumDistance)
        {
            PlayAttackSound(target1, target1AudioSource, ref lastTimePlayedTarget1);
            PlayAttackSound(target2, target2AudioSource, ref lastTimePlayedTarget2);
            target1.GetComponent<Animator>().SetBool("isAttacking", true);
            target2.GetComponent<Animator>().SetBool("isAttacking", true);

            Debug.Log("In attack range");
        }
        else
        {
            target1.GetComponent<Animator>().SetBool("isAttacking", false);
            target2.GetComponent<Animator>().SetBool("isAttacking", false);
            Debug.Log("In idle");
        }
    }

    private void PlayAttackSound(GameObject target, AudioSource audioSource, ref float lastTimePlayed)
    {
        float soundDelay = audioSource.clip.length;

        if (Time.time - lastTimePlayed >= soundDelay)
        {
            if (audioSource && !audioSource.isPlaying)
            {
                audioSource.Play();
                lastTimePlayed = Time.time;
            }
        }
    }
}
