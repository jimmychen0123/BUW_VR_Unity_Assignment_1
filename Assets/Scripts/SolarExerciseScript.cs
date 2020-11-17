using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarExerciseScript : MonoBehaviour
{
    GameObject sun;
    GameObject earth;
    GameObject moon;

    /*
     * I added this part below for exercise 1.7 since getComponent is expensive in terms of processing power, thus should be called as infrequently as possible.
     * It is always good practice to call in Awake or Start functions.
     * https://learn.unity.com/tutorial/getcomponent#5c8a65d5edbc2a001f47d6e6
     */

    // YOUR CODE - BEGIN
    private Component componentScriptInSunGO;
    private Component componentScriptInEarthGO;
    private Component componentScriptInMoonGO;
    // YOUR CODE - END



    // Start is called before the first frame update
    void Start()
    {
        // YOUR CODE - BEGIN
        sun = GameObject.Find("Sun");
        earth = GameObject.Find("Earth");
        moon = GameObject.Find("Moon");

        //used in task 1.7 to get the access the variable of the rotation veloctiy
        componentScriptInSunGO = sun.GetComponentInChildren<Component>();
        componentScriptInEarthGO = earth.GetComponentInChildren<Component>();
        componentScriptInMoonGO = moon.GetComponentInChildren<Component>();

        // YOUR CODE - END
    }

    // Update is called once per frame
    void Update()
    {
        // Exercise 1.9
        // Check if unity world matrix is the same as your own GetWorldTransform.
        if (!CompareMatrix(moon))
        {
            Debug.Log("not the same - solve exercise 1.9");
        }

        // Control Speed with Arrow Buttons 
        // Exercise 1.7
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // YOUR CODE - BEGIN
            componentScriptInSunGO.rotateSpeed += 1;
            componentScriptInEarthGO.rotateSpeed += 1;
            componentScriptInMoonGO.rotateSpeed += 1;


            // YOUR CODE - END
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // YOUR CODE - BEGIN
            componentScriptInSunGO.rotateSpeed -= 1;
            componentScriptInEarthGO.rotateSpeed -= 1;
            componentScriptInMoonGO.rotateSpeed -= 1;

            // YOUR CODE - END
        }

        // Comment in for exercise 1.8
        RotateAroundParent(earth, 20);
        RotateAroundParent(moon, 10);
    }

    // Exercise 1.8
    void RotateAroundParent(GameObject go, float rotationVelocity)
    {
        // YOUR CODE - BEGIN
        //Reference: https://docs.unity3d.com/ScriptReference/Transform-parent.html

        go.transform.RotateAround(go.transform.parent.position, Vector3.up, Time.deltaTime * rotationVelocity );

        // YOUR CODE - END
    }

    // Exercise 1.9
    Matrix4x4 GetWorldTransform(GameObject go)
    {
        Matrix4x4 mat = new Matrix4x4();
        // YOUR CODE - BEGIN
        /*
         * Reference: https://answers.unity.com/questions/1656903/how-to-manually-calculate-localtoworldmatrixworldt.html
         *            https://docs.unity3d.com/ScriptReference/Transform-localToWorldMatrix.html
         *            
         * Instead of using Transform.localToWorldMatrix, using localPosition, localRotation and localScale methods to form a matrix from local into parent space.
         * 
         */

        //mat = go.transform.localToWorldMatrix;
        // Relative matrix of Sun gameobject *  Relative matrix of Earth gameobject *  Relative matrix of Moon gameobject 
        mat = Matrix4x4.TRS(go.transform.parent.parent.localPosition, go.transform.parent.parent.localRotation, go.transform.parent.parent.localScale) *
              Matrix4x4.TRS(go.transform.parent.localPosition, go.transform.parent.localRotation, go.transform.parent.localScale) *
              Matrix4x4.TRS(go.transform.localPosition, go.transform.localRotation, go.transform.localScale);


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
