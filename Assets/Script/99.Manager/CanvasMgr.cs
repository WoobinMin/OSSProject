using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMgr : MonoBehaviour
{
    private static CanvasMgr instance;
    public static CanvasMgr Instance => instance;

    public GameObject cfadeinout;
    public GameObject cSettingButton;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }


    void Start()
    {
        instance = this;
    }


}
