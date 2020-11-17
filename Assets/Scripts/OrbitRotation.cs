using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    // A public variable is declared and can be modified in Inspector window of Unity.
    public GameObject targetToRotateAround;
    public float orbitSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The transform is referenced to the gameobject to which this script is attached. 
        transform.RotateAround(targetToRotateAround.transform.position, Vector3.up, Time.deltaTime * orbitSpeed);

    }
}
