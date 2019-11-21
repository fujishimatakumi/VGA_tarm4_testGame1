using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    Gamestatus m_gameStatus = Gamestatus.NonInitialized;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        switch(m_gameStatus)
        {
            case Gamestatus.NonInitialized:
                break;

            case Gamestatus.Initialized:
                break;

            case Gamestatus.Ingame:
                break;

            case Gamestatus.Failed:
                break;
        }
        */
    }

    public static void RelodeScene()
    {
        SceneManager.LoadScene("main");
    }
}

public enum Gamestatus
{
    /// <summary>/// ゲーム初期化前/// </summary>
    NonInitialized,
    /// <summary>/// ゲーム初期化済み、開始前/// </summary>
    Initialized,
    /// <summary>/// ゲーム進行中/// </summary>
    Ingame,
    /// <summary>/// 失敗時処理を実行/// </summary>
    Failed,
}
