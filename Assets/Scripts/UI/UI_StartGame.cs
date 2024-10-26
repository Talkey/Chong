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
        Button startGameBtn = this.transform.Find("Btn_StartGame").GetComponent<Button>();
        startGameBtn.onClick.AddListener(StartGame);
        Button exitGameBtn = this.transform.Find("Btn_ExitGame").GetComponent<Button>();
        exitGameBtn.onClick.AddListener(ExitGame);

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
