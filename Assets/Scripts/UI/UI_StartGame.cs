using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartGame : UIObject
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Init()
    {
        base.Init();
        UITool.RegistButton(this,"Btn_StartGame", StartGame);
        UITool.RegistButton(this, "Btn_ExitGame", ExitGame);
    }

    public override void Open()
    {
        base.Open();
    }

    public void StartGame()
    {
        Invoke("StartGameFunc", 3f);
        GameManager.Instance.ShowLoading();
    }
    public void StartGameFunc()
    {
        GameManager.Instance.LoadScene(SceneData.GameScene);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
