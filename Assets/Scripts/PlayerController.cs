using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Text mouse;

    private Vector3 mouseOld;
    private float xDiff;
    private float yDiff;
    private Vector3 mouseNew;


    // Use this for initialization
    void Start () {
        mouse.text = "";
        Vector3 mouseOld = Input.mousePosition;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 mouseMovement = Input.mousePosition;
        xDiff = mouseMovement.x - mouseOld.x;
        yDiff = mouseMovement.y - mouseOld.y;
        mouseOld = mouseMovement;

        //System.Console.WriteLine("X: " + mouseMovement.x + " Y: " + mouseMovement.y + " Z: " + mouseMovement.z);
        //Quaternion rotation = transform.rotation;
        //rotation.x = xDiff * Time.deltaTime;


        //transform.Rotate(Vector3.up, xDiff);
        //transform.Rotate(new Vector3(1, 0, 0), yDiff);

        //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        //Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        //transform.rotation = Quaternion.Slerp(target, target, Time.deltaTime * smooth);

        mouse.text = "X: " + xDiff.ToString() + " Y: " + yDiff.ToString() + " Z: " + mouseMovement.z.ToString();

    }
}
