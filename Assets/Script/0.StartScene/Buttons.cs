using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Buttons : MonoBehaviour
{

    public void GotoLobby()
    {
        SaveMgr.Instance.LoadGameData();
        SceneMgr.Instance.SceneChange("1.LobbyScene");
    }

    public void GameEnd()
    {
        SaveMgr.Instance.SaveGameData();
    }

}
