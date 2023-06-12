using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChacterCamera : MonoBehaviour
{
    public Transform player;

    public Transform camara;

    private Vector2 startTouchPos;

    Vector3 startPos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        CheckRotate();
    }

    void CheckRotate()
    {
        int touchCount = Input.touchCount;
        if(Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 currPos = Input.mousePosition;
                Vector3 offset = currPos - startPos;
                print("offset  " + offset);
                Vector3 move = new Vector3(0, offset.x, 0);
                transform.Rotate(move * 0.05f);
                startPos = currPos;
            }
            if (Input.GetMouseButtonUp(0))
            {               
                startPos = Vector3.zero;
            }

        }
        else
        {
            if (touchCount > 0)
            {
                for (int i = 0; i < touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);
                    if (touch.phase.Equals(TouchPhase.Began))
                    {
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            Debug.Log(hit.transform.name);
                            startTouchPos = touch.position;
                        }
                    }
                    else if (touch.phase.Equals(TouchPhase.Moved))
                    {
                        if (touch.position.y - startTouchPos.y > 0)
                        {
                            Debug.Log("Ìø");
                        }
                        if (touch.position.x - startTouchPos.x != 0)
                        {
                            Vector3 move = new Vector3(0, touch.position.x - startTouchPos.x, 0);
                            transform.Rotate(move * 0.3f);
                        }
                    }
                    else if (touch.phase.Equals(TouchPhase.Ended))
                    {
                        startTouchPos = Vector2.zero;
                    }
                }
            }
        }

       
    }
}

