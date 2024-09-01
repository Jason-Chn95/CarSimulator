﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIExplode : MonoBehaviour
{
    public GameObject mCanvas;
    public ButtonAnim anim;
    private bool isOpened = false;

    public void ClickButton()
    {
        if (isOpened)
        {
            Close();
            anim.Close();
            isOpened = false;
            MouseLock.Instance.Lock(1.5f);
        }
        else
        {
            Open();
            anim.Open();
            isOpened = true;
            MouseLock.Instance.Lock(1.5f);
        }
        SoundManager.Instance.PlayExplode();
    }

    public void Open()
    {
        EventCenter.UIEvent.RaiseExplode(true);
        mCanvas.SetActive(true);
        //EventCenter.BillBoardEvent.RaiseShowBillBoard(true);      
    }

    private void Close()
    {
        EventCenter.UIEvent.RaiseExplode(false);
        mCanvas.SetActive(false);
        //EventCenter.BillBoardEvent.RaiseShowBillBoard(false);
    }
}
