using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILightFlare : MonoBehaviour
{

    public ButtonAnim anim;
    private bool isOpened = false;
    public GameObject mLight;

    public void ClickButton()
    {
        if (isOpened)
        {
            mLight.SetActive(false);
            //EventCenter.UIEvent.RaiseLightFlare(false);   
            anim.Close();
            isOpened = false;
            SoundManager.Instance.PlayLightClose();
        }
        else
        {
            mLight.SetActive(true);
            //EventCenter.UIEvent.RaiseLightFlare(true);
            anim.Open();
            isOpened = true;
            SoundManager.Instance.PlayLightOpen();
        }
        MouseLock.Instance.Lock(1.5f);
    }
}
