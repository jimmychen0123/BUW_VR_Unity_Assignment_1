using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    
    public float rotateSpeed;

   

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local y axis at 1 degree per second
        //https://docs.unity3d.com/2018.1/Documentation/ScriptReference/Transform.Rotate.html
        
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed, Space.Self);
        

    }
}
