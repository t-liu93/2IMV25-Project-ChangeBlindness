using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class GameObjectController : MonoBehaviour {

    private GameObject grenade;

    private Stopwatch timer;

    private Boolean scaled;

    private TimeSpan startTime;
    private TimeSpan triggerTime;

    public Text showTime;

    // Use this for initialization
    void Start()
    {
        grenade = GameObject.Find("Grenade");
        timer = new Stopwatch();
        timer.Start();
        scaled = false;
        showTime.text = "123";
    }

    // Update is called once per frame
    void Update()
    {

        if (timer.Elapsed.Seconds == 3 && scaled == false)
        {

            float scaleX = 15f;
            float scaleY = 15f;
            float scaleZ = 15f;

            transform.Find("Lamp").localScale = new Vector3(scaleX, scaleY, scaleZ);
            startTime = timer.Elapsed;
            scaled = true;
            //transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
        }

        if (Input.GetMouseButtonDown(0))
        {
            triggerTime = timer.Elapsed;
            showTime.text = (triggerTime - startTime).ToString();
        }


    }
}
