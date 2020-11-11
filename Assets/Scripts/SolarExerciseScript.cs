using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarExerciseScript : MonoBehaviour
{
    GameObject sun;
    GameObject earth;
    GameObject moon;

    // Start is called before the first frame update
    void Start()
    {
        // YOUR CODE - BEGIN

        // YOUR CODE - END
    }

    // Update is called once per frame
    void Update()
    {
        // Exercise 1.9
        // Check if unity world matrix is the same as your own GetWorldTransform.
        //if (!CompareMatrix(moon))
        //{
        //    Debug.Log("not the same - solve exercise 1.9");
        //}

        // Control Speed with Arrow Buttons 
        // Exercise 1.7
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // YOUR CODE - BEGIN

            // YOUR CODE - END
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // YOUR CODE - BEGIN

            // YOUR CODE - END
        }

        // Comment in for exercise 1.8
        //RotateAroundParent(earthTransform, 20);
        //RotateAroundParent(moonTransform, 10);
    }

    // Exercise 1.8
    void RotateAroundParent(GameObject go, float rotationVelocity)
    {
        // YOUR CODE - BEGIN

        // YOUR CODE - END
    }

    // Exercise 1.9
    Matrix4x4 GetWorldTransform(GameObject go)
    {
        Matrix4x4 mat = new Matrix4x4();
        // YOUR CODE - BEGIN

        // YOUR CODE - END
        return mat;
    }

    bool CompareMatrix(GameObject go)
    {
        Matrix4x4 unityWorldMat = Matrix4x4.TRS(go.transform.position, go.transform.rotation, go.transform.lossyScale);
        Matrix4x4 ownWorldMat = GetWorldTransform(go);
        if (unityWorldMat == ownWorldMat)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
