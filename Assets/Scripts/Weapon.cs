using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public float fireRate = 0.1f;
    public float shootForce = 1000.0f;
    public Transform gunEnd;
    public AudioSource shootAudio;
    public LineRenderer projectileLineRenderer;

    public void Init()
    {
        projectileLineRenderer.positionCount = 2;
    }

    public void Shoot(Vector3 shootPoint, Vector3 force, Rigidbody targetRb)
    {
        projectileLineRenderer.enabled = true;
        projectileLineRenderer.SetPosition(0, gunEnd.position);
        projectileLineRenderer.SetPosition(1, shootPoint);

        targetRb.AddForceAtPosition(force * shootForce, shootPoint);
        shootAudio.Play();
    }

    public void ShootWalkingTarget(Vector3 shootPoint, Vector3 force, GameObject targetGo)
    {
        projectileLineRenderer.enabled = true;
        projectileLineRenderer.SetPosition(0, gunEnd.position);
        projectileLineRenderer.SetPosition(1, shootPoint);

        targetGo.GetComponent<WalkingTarget>().TakeDamage();
        shootAudio.Play();
    }

    public void ClearShootTrace()
    {
        projectileLineRenderer.enabled = false;
    }
   
}
