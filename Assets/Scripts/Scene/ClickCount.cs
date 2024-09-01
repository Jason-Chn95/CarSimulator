using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCount : MonoBehaviour
{
    private int mCount;

    public GameObject mObj;

    public void OnClick()
    {
        mCount++;
        if (mCount % 2 == 1)
        {
            mObj.SetActive(false);
        }
        else
        {
            mObj.SetActive(true);
        }
    }
}
