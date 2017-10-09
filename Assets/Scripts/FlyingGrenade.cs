using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using UnityEngine.UI;

public class FlyingGrenade : MonoBehaviour {

    public float speed;
    public Stopwatch time;
    public Text timeText;
    

    // Use this for initialization
    void Start () {
        speed = 20; //20 -> 18s

        time = new Stopwatch();
        time.Start();
        timeText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if (time.Elapsed.Seconds <= 3)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        }
        else if (time.Elapsed.Seconds <= 6)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0.5f), speed * Time.deltaTime);
        }
        else if (time.Elapsed.Seconds <= 9)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 1, -0.5f), speed * Time.deltaTime);
        }
        else if (time.Elapsed.Seconds <= 12)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0.4f), speed * Time.deltaTime);
        }
        else if (time.Elapsed.Seconds <= 15)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 1, -0.8f), speed * Time.deltaTime);
        }
        else if (time.Elapsed.Seconds <= 18)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0.2f), speed * Time.deltaTime);
        }
    }
        //if (transform.position.x <= 0.01f && transform.position.x >= -0.01f)
        //{
        //    timeText.text = time.Elapsed.Seconds.ToString();
        //}

}
