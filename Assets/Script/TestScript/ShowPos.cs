using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPos : MonoBehaviour
{
    public GameObject ball;
    public TextMeshProUGUI text;
    Vector3 deviceGravity;
    //设备的旋转速度，返回结果为x，y，z轴的旋转速度，单位为（弧度/秒）    
    Vector3 rotationVelocity ;
    //获取更加精确的旋转    
    Vector3 rotationVelocity2;
    //设置陀螺仪的更新检索时间，即隔 0.1秒更新一次    
        //获取移除重力加速度后设备的加速度    
        Vector3 acceleration;
    // Start is called before the first frame update
    void Start()
    {
        //获取设备重力加速度向量    
         deviceGravity = Input.gyro.gravity;
        //设备的旋转速度，返回结果为x，y，z轴的旋转速度，单位为（弧度/秒）    
         rotationVelocity = Input.gyro.rotationRate;
        //获取更加精确的旋转    
         rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        //设置陀螺仪的更新检索时间，即隔 0.1秒更新一次    
        Input.gyro.updateInterval = 0.1f;
        //获取移除重力加速度后设备的加速度    
         acceleration = Input.gyro.userAcceleration;
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = ball.transform.position + "  ";
        //text.text = deviceGravity + "  " ;
        deviceGravity = Input.gyro.gravity;
        //设备的旋转速度，返回结果为x，y，z轴的旋转速度，单位为（弧度/秒）    
        rotationVelocity = Input.gyro.rotationRate;
        //获取更加精确的旋转    
        rotationVelocity2 = Input.gyro.rotationRateUnbiased;
        //设置陀螺仪的更新检索时间，即隔 0.1秒更新一次    
        Input.gyro.updateInterval = 0.1f;
        //获取移除重力加速度后设备的加速度    
        acceleration = Input.gyro.userAcceleration;
        //text.text = SystemInfo.supportsGyroscope + "  ";
        text.text =  deviceGravity + "  ";
    }
}
