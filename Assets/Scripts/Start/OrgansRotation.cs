using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgansRotation : MonoBehaviour
{
    private float rotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation -= 0.25f;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
