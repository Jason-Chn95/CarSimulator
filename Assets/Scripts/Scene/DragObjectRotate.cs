using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjectRotate : MonoBehaviour
{
    private bool onDrag = false;      
    public float speed = 6f;          
    private float tempSpeed;      
    private float axisX = 1;        
    private float axisY = 1;      
    private float cXY;

    void OnMouseDown()
    {
        
        axisX = 0f;
        axisY = 0f;
    }
   
    void OnMouseDrag()
    {
        onDrag = true;
        axisX = -Input.GetAxis("Mouse X");
       
       
        cXY = Mathf.Sqrt(axisX * axisX + axisY * axisY);
        if (cXY == 0f) { cXY = 1f; }
    }
   
    float Rigid()
    {
        if (onDrag)
        {
            tempSpeed = speed;
        }
        else
        {
            if (tempSpeed > 0)
            {
                
                tempSpeed -= speed * 2 * Time.deltaTime / cXY;
            }
            else
            {
                tempSpeed = 0;
            }
        }
        return tempSpeed;
    }

    void Update()
    {
       
        this.transform.Rotate(new Vector3(axisY, axisX, 0) * Rigid(), Space.World);

    }
}
