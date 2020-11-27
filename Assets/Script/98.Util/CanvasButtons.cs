using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public void BackButton()
    {
            SceneMgr.Instance.SceneChange("0.StartScene");
    }


}
