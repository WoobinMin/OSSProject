using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIBtn : MonoBehaviour
{
    public void ReStart()
    {
        SceneMgr.Instance.PrevName = SceneMgr.Instance.SceneName;
        SceneMgr.Instance.SceneChange("99.RestartScene");
        CharacterMgr.Instance.SeeUI = false;

    }

    public void MenuBtn()
    {
        SceneMgr.Instance.SceneChange("1.LobbyScene");
        CharacterMgr.Instance.SeeUI = true;
    }
}
