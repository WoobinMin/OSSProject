using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMgr : MonoBehaviour
{
    private static CanvasMgr instance;
    public static CanvasMgr Instance => instance;

    public GameObject cfadeinout;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        instance = this;
    }


}
