using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneInBack : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        pos = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = pos;

    }

}
