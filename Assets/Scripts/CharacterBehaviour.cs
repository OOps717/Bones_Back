using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Animator GameOver;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        sprite = this.gameObject.GetComponentInChildren<SpriteRenderer>();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
        }
        if (!sprite.isVisible)
        {
            Debug.Log("NotVisible");
        }
    }
}
