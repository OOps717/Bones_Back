using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
    }


    private void Fall()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.down, 4f * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

            Fall();
            if (!sprite.isVisible)
            {
                Destroy(gameObject);
            }
    }
}
