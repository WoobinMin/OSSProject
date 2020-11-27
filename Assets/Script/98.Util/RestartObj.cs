using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartObj : MonoBehaviour
{
    void Update()
    {
        SceneMgr.Instance.SceneChange(SceneMgr.Instance.PrevName);
    }

}
