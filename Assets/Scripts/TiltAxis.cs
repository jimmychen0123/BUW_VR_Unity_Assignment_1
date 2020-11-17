using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltAxis : MonoBehaviour
{
    // A public variable is declared and can be modified in Inspector window of Unity.
    public float tiltAngle;

    // Start is called before the first frame update
    void Start()
    {
        //tilt the y axis means rotating around z axis
        //The second argument is the rotation axes, which is be set to local axis
        //https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
        transform.Rotate(Vector3.forward * tiltAngle, Space.Self);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
