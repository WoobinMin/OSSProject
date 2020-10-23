using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public void BackButton()
    {
        if (SceneMgr.Instance.SceneLog.Count > 1)
        {
            SceneMgr.Instance.SceneLog.Pop();
            SceneMgr.Instance.SceneChange(SceneMgr.Instance.SceneLog.Pop());
        }
    }


}
