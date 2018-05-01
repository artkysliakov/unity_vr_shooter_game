using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTarget : MonoBehaviour {

    public float maxSpeedValue = 10;

    public AudioSource audioSourse;

    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter()
    {
        float clampedVolumeValue = 1 - Mathf.Clamp01((maxSpeedValue - rb.velocity.sqrMagnitude) / maxSpeedValue);
        audioSourse.volume = clampedVolumeValue;
        audioSourse.Play();
    }

}
