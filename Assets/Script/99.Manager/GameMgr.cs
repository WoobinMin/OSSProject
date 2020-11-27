using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    private static GameMgr instance;
    public static GameMgr Instance => instance;


    private int gamecoin = 0;
    public int GameCoin { get => gamecoin; set => gamecoin = value; }



    public Transform startpoint;
    public GameObject boyprefab;
    public GameObject catprefab;
    public GameObject dogprefab;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GameStart();
    }

    public void GameStart()
    {
        gamecoin = 0;
        CharacterMgr.Instance.IsRunning = true;
        switch (CharacterMgr.Instance.Charselect)
        {
            case 0:
                Instantiate(boyprefab, startpoint.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(catprefab, startpoint.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(dogprefab, startpoint.position, Quaternion.identity);
                break;
        }

    }

    public void GameEnd()
    {
        CharacterMgr.Instance.IsRunning = false;
    }
}
