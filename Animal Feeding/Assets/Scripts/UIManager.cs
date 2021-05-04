using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    GameObject playCanvas;
    GameObject gameOverCanvas;
    public bool isPlayGame;
    void Awake()
    {
        isPlayGame = false;
        playCanvas = gameObject.transform.GetChild(0).gameObject;
        gameOverCanvas = gameObject.transform.GetChild(1).gameObject;
        playCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayGame();
        }
    }
    public void PlayGame()
    {
        isPlayGame = true;
        playCanvas.SetActive(false);
    }
    public void GameOver()
    {
        isPlayGame = false;
        gameOverCanvas.SetActive(true);
    }
}
