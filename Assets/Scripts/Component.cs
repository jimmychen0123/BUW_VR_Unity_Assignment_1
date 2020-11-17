using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    // A public variable is declared and can be modified in Inspector window of Unity.
    // Also, it can be accessed from other script from task 1.7
    public float rotateSpeed;

   

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local y axis at 1 degree per second
        // Vector3.up: shorthand for writing Vector3(0, 1, 0).
        /*
         * Time.deltaTime: The completion time in seconds since the last frame.
         * This property provides the time between the current and previous frame.
         * In general, Use Time.deltaTime to transform a GameObject.
         */
        //https://docs.unity3d.com/2018.1/Documentation/ScriptReference/Transform.Rotate.html
        //https://docs.unity3d.com/2018.1/Documentation/ScriptReference/Time-deltaTime.html

        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed, Space.Self);
        

    }
}
