using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyButtons : MonoBehaviour
{
    public string SceneName;


    public void GotoScene()
    {
        SceneMgr.Instance.SceneChange(SceneName);
    }


}
