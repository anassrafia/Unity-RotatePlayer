using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class RotatePlayer : MonoBehaviour  
{  
     
    void Start()  
    {  
          
    }  
  
    void Update()  
    {  
          
        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -10);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 10);  
        }  
  
    }  
}  
