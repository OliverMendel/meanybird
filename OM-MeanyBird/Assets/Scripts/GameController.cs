using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Things idk what they do lol")]

    public GameObject gameOverCanvas;

    public GameObject scoreCanvas;

    public GameObject spawner;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        scoreCanvas.SetActive(true);

        gameOverCanvas.SetActive(false);

        spawner.SetActive(true);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);

        spawner.SetActive(false);

        Time.timeScale = 0;
    }

    public void Update(){
        scoreText.text = Score.score.ToString();
    }

}
