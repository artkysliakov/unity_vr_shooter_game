using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingTarget : MonoBehaviour {

    private NavMeshAgent navMesh;

    private Transform currentDestination;
    private Transform[] wayPoints;

    private int health;
    public GameObject[] healthImages;
    public GameObject destroyedTargetPrefab;

    public void Init(Transform[] _wayPoints)
    {
        wayPoints = _wayPoints;
    }

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        health = healthImages.Length;
        SetRandomNavMeshAgentDestionation();
    }

    void Update()
    {
        float dist = navMesh.remainingDistance;
        if(dist != Mathf.Infinity && navMesh.pathStatus == NavMeshPathStatus.PathComplete && navMesh.remainingDistance < 0.1f)
        {
            SetRandomNavMeshAgentDestionation();
        }
    }

    private void SetRandomNavMeshAgentDestionation()
    {
        int wayPointIndex = Random.Range(0, wayPoints.Length);
        currentDestination = wayPoints[wayPointIndex];
        navMesh.SetDestination(currentDestination.position);
    }

    public void TakeDamage()
    {
        health--;
        healthImages[health].SetActive(false);
        if(health <= 0)
        {
            Transform currentTransform = transform;
            GameObject go = Instantiate(destroyedTargetPrefab, currentTransform.position, currentTransform.rotation);
            Destroy(gameObject);
            Destroy(go, 5.0f);
        }
    }
}
