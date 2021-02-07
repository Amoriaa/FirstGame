using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.up *55;
    }
   public GameObject bucket;
   public Transform spawn;
    // Update is called once per frame
    void FixedUpdate()
    {
       
       bool didhit=DidHit();
    if(didhit && Input.GetMouseButtonDown(0))
    {
        Instantiate(bucket, spawn);
    
    }
    }
    bool DidHit()
    {
         RaycastHit hit;
        return ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5F))&&hit.transform.tag=="Usable");
    }
}
