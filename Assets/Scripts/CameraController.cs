using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 mouseOld;
    private float xDiff;
    private float yDiff;
    private Vector3 mouseNew;

    // Use this for initialization
    void Start () {
        Vector3 mouseOld = Input.mousePosition;
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mouseMovement = Input.mousePosition;
        xDiff = mouseMovement.x - mouseOld.x;
        yDiff = mouseMovement.y - mouseOld.y;
        mouseOld = mouseMovement;

        //transform.Rotate(Vector3.up, xDiff);
        //transform.Rotate(new Vector3(1, 0, 0), yDiff);

        Quaternion rotation = Quaternion.Euler(new Vector3(xDiff, 0, yDiff));

        transform.rotation = rotation;

}

}
