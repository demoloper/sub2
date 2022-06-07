using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cricle : MonoBehaviour
{
    public float spawnRadius=1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SphereCollider>().radius = spawnRadius;

    }
    void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }
    

}
