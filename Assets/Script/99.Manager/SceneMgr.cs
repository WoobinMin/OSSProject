using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    private static SceneMgr instance;
    public static SceneMgr Instance => instance;

    private string sceneName;
    public string SceneName { get => sceneName; set => sceneName = value; }

    private Stack<string> sceneLog = new Stack<string>();
    public Stack<string> SceneLog { get => sceneLog; set => sceneLog = value; }


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

    private void Start()
    {
        sceneLog.Push("0.StartScene");
    }

    public void SceneChange(string _SceneName)
    {
        sceneName = _SceneName;
        CanvasMgr.Instance.cfadeinout.gameObject.SetActive(true);
    }

    public void ChangeScene()
    {
        sceneLog.Push(sceneName);
        SceneManager.LoadScene(sceneName);
    }

}