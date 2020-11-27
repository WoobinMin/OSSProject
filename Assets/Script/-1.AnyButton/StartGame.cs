using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SaveMgr.Instance.LoadGameData();
            SceneMgr.Instance.SceneChange("0.StartScene");
        }
    }
}
