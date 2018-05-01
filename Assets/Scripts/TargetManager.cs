using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [Header("Bouncy Target")]
    public int maxBouncyTargetsCount = 2;
    private int currentBouncyTargetsCount = 0;
    public Transform bouncyRespawnPoint;
    public GameObject bouncyTargetPrefab;

    [Header("Heavy Target")]
    public int maxHeavyTargetsCount = 2;
    private int currentHeavyTargetsCount = 0;
    public Transform heavyRespawnPoint;
    public GameObject heavyTargetPrefab;

    [Header("Walking Target")]
    public Transform walkingTargetRespawnPoint;
    public Transform[] walkingTargetWaypoints;
    public GameObject walkingTargetPrefab;

    public void InstantiateBouncyTarget()
    {
        if(currentBouncyTargetsCount < maxBouncyTargetsCount)
        {
            Instantiate(bouncyTargetPrefab, bouncyRespawnPoint.position, bouncyRespawnPoint.rotation);
            currentBouncyTargetsCount++;
        }
    }

    public void InstantiateHeavyTarget()
    {
        if (currentHeavyTargetsCount < maxHeavyTargetsCount)
        {
            Instantiate(heavyTargetPrefab, heavyRespawnPoint.position, heavyRespawnPoint.rotation);
            currentHeavyTargetsCount++;
        }
    }

    public void InstantiateWalkingTarget()
    {
        GameObject walkingTarget = Instantiate(walkingTargetPrefab, walkingTargetRespawnPoint.position, walkingTargetRespawnPoint.rotation);
        walkingTarget.GetComponent<WalkingTarget>().Init(walkingTargetWaypoints);
    }

}
