using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{

    void Start()
    {
        this.gameObject.SetActive(false);   
    }





    public void SC()
    {
        SceneMgr.Instance.ChangeScene();
    }

    public void ActiveFalse()
    {
        this.gameObject.SetActive(false);
    }

}
