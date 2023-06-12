using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour
{
    Vector3 nowMove = Vector2.zero;
    public float Speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

        //设置设备陀螺仪的开启/关闭状态，使用陀螺仪功能必须设置为 true    
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    public void Move()
    {
        CheckDead();
        Vector3 moveVec;
        if (!SystemInfo.supportsGyroscope)
        {
        }
        else
        {
            OnMobileMove();
        }
        moveVec = new Vector3(nowMove.x, 0, nowMove.y);

        transform.position += moveVec * Speed;
    }

    public void Respawn()
    {
        float bornX = Random.Range(-150, 151);
        float bornZ = Random.Range(-150, 151);
        transform.position = new Vector3 (bornX, 0, bornZ);
    }

    public void CheckDead()
    {
        if(transform.position.y < -10)
        {
            Respawn();
        }
    }

    public void OnMove(InputValue vec)
    {
        if(!SystemInfo.supportsGyroscope)
        {
            nowMove = vec.Get<Vector2>();
        }
    }
    public void OnMobileMove()
    {
        if(SystemInfo.supportsGyroscope)
        {
            nowMove = Input.gyro.gravity;
        }
    }
}
