using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverImg;
    private Airplane airplane;
    private Score score;
    private SoundTrack soundTrack;

    private void Start()
    {
        this.airplane = GameObject.FindObjectOfType<Airplane>();
        this.score = GameObject.FindObjectOfType<Score>();
        this.soundTrack = GameObject.FindObjectOfType<SoundTrack>();
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        this.gameOverImg.SetActive(true);
        this.soundTrack.StopSound();
    }

    public void RestartGame()
    {
        this.gameOverImg.SetActive(false);
        Time.timeScale = 1;
        this.airplane.restartPosition();
        this.DestroyObstacles();
        this.score.ResetPoint();
        this.soundTrack.PlaySound();
    }

    public void DestroyObstacles()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        foreach(Obstacle obstacle in obstacles)
        {
            obstacle.DestroyerObstacle();
        }
    }
}
