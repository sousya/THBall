using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPos : MonoBehaviour
{
    public GameObject ball;
    public TextMeshProUGUI text;
    Vector3 deviceGravity;
    //�豸����ת�ٶȣ����ؽ��Ϊx��y��z�����ת�ٶȣ���λΪ������/�룩    
    Vector3 rotationVelocity ;
    //��ȡ���Ӿ�ȷ����ת    
    Vector3 rotationVelocity2;
    //���������ǵĸ��¼���ʱ�䣬���� 0.1�����һ��    
        //��ȡ�Ƴ��������ٶȺ��豸�ļ��ٶ�    
        Vector3 acceleration;
    // Start is called before the first frame update
    void Start()
    {
        //��ȡ�豸�������ٶ�����    
         deviceGravity = Input.gyro.gravity;
        //�豸����ת�ٶȣ����ؽ��Ϊx��y��z�����ת�ٶȣ���λΪ������/�룩    
         rotationVelocity = Input.gyro.rotationRate;
        //��ȡ���Ӿ�ȷ����ת    
         rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        //���������ǵĸ��¼���ʱ�䣬���� 0.1�����һ��    
        Input.gyro.updateInterval = 0.1f;
        //��ȡ�Ƴ��������ٶȺ��豸�ļ��ٶ�    
         acceleration = Input.gyro.userAcceleration;
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = ball.transform.position + "  ";
        //text.text = deviceGravity + "  " ;
        deviceGravity = Input.gyro.gravity;
        //�豸����ת�ٶȣ����ؽ��Ϊx��y��z�����ת�ٶȣ���λΪ������/�룩    
        rotationVelocity = Input.gyro.rotationRate;
        //��ȡ���Ӿ�ȷ����ת    
        rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        //���������ǵĸ��¼���ʱ�䣬���� 0.1�����һ��    
        Input.gyro.updateInterval = 0.1f;
        //��ȡ�Ƴ��������ٶȺ��豸�ļ��ٶ�    
        acceleration = Input.gyro.userAcceleration;
        //text.text = SystemInfo.supportsGyroscope + "  ";
        text.text =  deviceGravity + "  ";
    }
}
