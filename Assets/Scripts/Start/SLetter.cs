using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLetter : MonoBehaviour
{
    private float rotation = 0f;
    private Vector3 rot;
    private float dest;
    private float toRot;
    private bool toleft;

    // Start is called before the first frame update
    void Start()
    {
        dest = -4f;
        toRot = 0.1f;
        toleft = true;
    }


    // Update is called once per frame
    void Update()
    {
        rotation -= toRot;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        if(rotation <= dest && toleft )
        {
            toRot *= -1;
            dest *= -1;
            toleft = !toleft;
        }else if(rotation >= dest && !toleft)
        {
            toRot *= -1;
            dest *= -1;
            toleft = !toleft;
        }

    }
        
}
