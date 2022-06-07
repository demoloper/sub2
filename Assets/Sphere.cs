using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public GameObject kure;
    public Vector3 firstPos;
    public Vector3 lastPos;
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z =4;
            firstPos = Camera.main.ScreenToWorldPoint(pos);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 4;
            lastPos = Camera.main.ScreenToWorldPoint(pos);
            transform.position = lastPos;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="SphereGizmo")
        {
            kure.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}
