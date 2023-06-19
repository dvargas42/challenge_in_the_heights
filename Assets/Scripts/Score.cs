using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int score;
    private AudioSource scoreAudio;

    private void Awake()
    {
        this.scoreAudio = this.GetComponent<AudioSource>();
    }

    public void AddPoint()
    {
        this.score++;
        scoreText.text = this.score.ToString();
        this.scoreAudio.Play();
    }

    public void ResetPoint()
    {
        this.score = 0;
        scoreText.text = this.score.ToString();
    }
}
