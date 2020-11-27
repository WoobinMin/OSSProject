using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMgr : MonoBehaviour
{

    private static CharacterMgr instance;
    public static CharacterMgr Instance => instance;

    private int charselect;
    public int Charselect { get => charselect; set => charselect = value; }

    private bool isRunning = false;
    public bool IsRunning { get => isRunning; set => isRunning = value; }
    private bool seeUI = false;
    public bool SeeUI { get => seeUI; set => seeUI = value; }

    private int coin;
    public int Coin { get => coin; set => coin = value; }

    private int hpupgrade;
    public int HPUpgrade { set => hpupgrade = value; get => hpupgrade; }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
    }

}
