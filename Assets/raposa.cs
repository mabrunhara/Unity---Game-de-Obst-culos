using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raposa : MonoBehaviour
{
    public Vector3 mov;
    // Start is called before the first frame update
    void Start()
    {
        mov= new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.UpArrow))
        {
            mov.Set(0f,0f,0.1f);
            transform.Translate (mov);
             mov.Set(0f,0f,0f);
        }
         
        if ( Input.GetKey(KeyCode.DownArrow))
        {
             mov.Set(0f,0f,-0.1f);
            transform.Translate (mov);
             mov.Set(0f,0f,0f);
            
        }
        if ( Input.GetKey(KeyCode.RightArrow))
        {
            mov.Set(0.1f,0f,0f);
            transform.Translate (mov);
             mov.Set(0f,0f,0f);
        }
         
        if ( Input.GetKey(KeyCode.LeftArrow))
        {
             mov.Set(-0.1f,0f,-0f);
            transform.Translate (mov);
             mov.Set(0f,0f,0f);

         

            
        }

        if ( Input.GetKey(KeyCode.Space))
        {
             mov.Set(0f,0.05f,0f);
            transform.Translate (mov);
             mov.Set(0f,0f,0f);
            
        }
    }
}
