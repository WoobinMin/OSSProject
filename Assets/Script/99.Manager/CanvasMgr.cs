using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMgr : MonoBehaviour
{
    private static CanvasMgr instance;
    public static CanvasMgr Instance => instance;

    public GameObject cfadeinout;
    public GameObject cSettingButton;
    public GameObject cBackButton;


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
    }

    public void ActiveFalse(bool _isActive)
    {
        this.gameObject.SetActive(_isActive);
        cfadeinout.SetActive(false);
    }

}
