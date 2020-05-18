using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Private variables
    private float speed = 25.0f;
    private float turnInput = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * turnInput);
        if (this.name == "KDTIX" || this.name == "AFSL")
            transform.Rotate(Vector3.up, Time.deltaTime * speed * turnInput);
        if (this.name == "AFSL") 
            transform.Rotate(Vector3.right, Time.deltaTime * speed * turnInput);
    }
}
