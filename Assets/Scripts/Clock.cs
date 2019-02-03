using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTransform;

    const float 
        degreesPerHour = 30f,
		degreesPerMinute = 6f,
		degreesPerSecond = 6f;

    // Start is called before the first frame update
    void Start()
    {
        // hoursTransform.localRotation = 
        //     Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
		// minutesTransform.localRotation =
		// 	Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute, 0f);
		// secondsTransform.localRotation =
		// 	Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);

        // Debug.Log(Quaternion.Euler(0, DateTime.Now.Hour, 0));
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
		hoursTransform.localRotation =
			Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
		minutesTransform.localRotation =
			Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
		secondsTransform.localRotation =
			Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }
}
