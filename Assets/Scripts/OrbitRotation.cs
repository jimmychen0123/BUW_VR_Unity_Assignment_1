using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    public GameObject targetToRotateAround;
    public float orbitSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(targetToRotateAround.transform.position, Vector3.up, Time.deltaTime * orbitSpeed);

    }
}
