using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform body;
    [Range(1,5)]
    public float z=15F;
    [Range(1,5)]
    public float x=15F;
            // Start is called before the first frame update

    void Start(){
        x=15F;
        z=15F;
    }
    // Update is called once per frame
    void Move(Vector3 direction){
        direction=new Vector3(direction.x*x,0,direction.z*z);
        body.Translate(direction* Time.fixedDeltaTime, Space.Self);
    }
    void Update()
    {

        Vector3 movement = new Vector3();
        if(Input.GetAxisRaw("Horizontal")!=0)
        {
           movement.x=Input.GetAxisRaw("Horizontal");
       }
            
       if(Input.GetAxisRaw("Vertical")!=0)
       {
           movement.z=Input.GetAxisRaw("Vertical");
       }
       
        Move(movement);
        
    
    }
}
