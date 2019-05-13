using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnim : MonoBehaviour
{
    public float seconds;
    private float target, move;
    private float timer = 0f;
    private bool check = false;
    private bool checkUp, checkDown;
    public float dest;

    // Start is called before the first frame update
    void Start()
    {
        checkUp = false;
        checkDown = true;
        move = transform.position.y;
        target = transform.position.y;
        target += dest;
    }


    bool isOverButton()
    {
        return EventSystem.current.IsPointerOverGameObject(); 
    }

    public void ChangePos()
    {   
        
        if (move < target)
        {
            if (checkUp) target += dest;
            checkUp = false;
            checkDown = true;
            move += 0.001f;
            transform.position = new Vector3(transform.position.x, move, transform.position.z);
        }
        else if (move >= target)
        {
            if (checkDown) target -= dest;
            checkDown = false;
            checkUp = true;
            move -= 0.001f;
            transform.position = new Vector3(transform.position.x, move, transform.position.z);
        }
    }

    private void Update()
    {
        if (timer < seconds) timer += Time.deltaTime;
        else check = true;

        if (check) ChangePos();
    }
}
