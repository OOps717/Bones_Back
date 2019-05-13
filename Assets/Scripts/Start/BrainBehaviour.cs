using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainBehaviour : MonoBehaviour
{
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
    }

    private void Whirl()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0.3f);
    }


    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, 1f,Space.Self);
    }
}
