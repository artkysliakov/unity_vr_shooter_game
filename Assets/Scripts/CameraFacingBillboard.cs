using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour {

    private Transform mainCameraTransform;

	// Use this for initialization
	void Start () {
        mainCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(mainCameraTransform);
	}
}
