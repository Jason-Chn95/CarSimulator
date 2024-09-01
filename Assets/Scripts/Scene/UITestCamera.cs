using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITestCamera : MonoBehaviour
{
    public float rotationspeed = 3;//旋转速度
    //public float speedpostpone = 3;//移动延迟
    public Transform targetmodel;//围绕的目标物体
    private GameObject[] image;//需要旋转的物体

    private void Awake()
    {
        image = GameObject.FindGameObjectsWithTag("UI");//你定义tag的名字
    }

    private void Update()
    {
        foreach (GameObject game in image)
        {
            game.GetComponent<Transform>().eulerAngles = new Vector3(targetmodel.eulerAngles.x, targetmodel.eulerAngles.y, 0);
        }
    }
}
