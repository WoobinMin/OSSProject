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
        SaveGame.Save<int>("CharacterSelect", CharacterMgr.Instance.Charselect);
        SaveGame.Save<int>("HPUpgrade", CharacterMgr.Instance.HPUpgrade);
        SaveGame.Save<int>("Coin", CharacterMgr.Instance.Coin);
    }


    public void LoadGameData()
    {
        Debug.Log("Load Complete");
        try { CharacterMgr.Instance.Charselect = SaveGame.Load<int>("CharacterSelect"); }
        catch { CharacterMgr.Instance.Charselect = (int)CharSelect.Boy; }

        try { CharacterMgr.Instance.HPUpgrade = SaveGame.Load<int>("HPUpgrade"); }
        catch { CharacterMgr.Instance.HPUpgrade = 0; }

        try { CharacterMgr.Instance.Coin = SaveGame.Load<int>("Coin"); }
        catch { CharacterMgr.Instance.Coin = 0; }
    }


}
