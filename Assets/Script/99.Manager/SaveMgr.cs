using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BayatGames.SaveGameFree;

public class SaveMgr : MonoBehaviour
{
    private static SaveMgr instance;
    public static SaveMgr Instance => instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    public void SaveGameData()
    {
        Debug.Log("Save Complete");
        SaveGame.Save<int>("CharacterColor", CharacterMgr.Instance.Charcolor);
    }


    public void LoadGameData()
    {
        Debug.Log("Load Complete");
        CharacterMgr.Instance.Charcolor = SaveGame.Load<int>("CharacterColor");
    }


}
