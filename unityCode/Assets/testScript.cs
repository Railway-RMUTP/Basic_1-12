using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        cube1.transform.localScale = new Vector3(3.0f,3.0f,3.0f);
        cube1.GetComponent<Renderer>().material.color = Color.yellow;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cube2.transform.position = new Vector3(-1.0f, 1.0f, 1.0f);
        cube2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        cube2.transform.localScale = new Vector3(2.0f,2.0f,2.0f);
        cube2.GetComponent<Renderer>().material.color = Color.red;
        cube2.name = "World";
    }

    void Update()
    {
        var i = 10;
        for(i = 0; i<=20;i++){
        cube1.transform.position = cube1.transform.position + new Vector3(0.01f,0,0);
        cube2.transform.position = cube2.transform.position + new Vector3(0,0,0.01f);
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        }
         cube1.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        cube2.transform.position = new Vector3(-1.0f, 1.0f, 1.0f);
    }
}