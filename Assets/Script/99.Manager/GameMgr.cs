using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    private static GameMgr instance;
    public static GameMgr Instance => instance;

    private int gamecoin = 0;
    public int GameCoin { get => gamecoin; set => gamecoin = value; }


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // 캐릭터 생성
        CanvasMgr.Instance.ActiveFalse(false);
    }

    void Update()
    {
        
    }
}
