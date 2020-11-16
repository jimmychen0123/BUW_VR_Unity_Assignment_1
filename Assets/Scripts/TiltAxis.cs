using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltAxis : MonoBehaviour
{
    public float tiltAngle;
    // Start is called before the first frame update
    void Start()
    {

        transform.Rotate(Vector3.forward * tiltAngle, Space.Self);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
