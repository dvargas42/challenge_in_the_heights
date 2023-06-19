using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    [SerializeField]
    private float yPositionInterval;
    private Vector3 airplanePosition;
    private bool pointed = false;
    private Score score;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-yPositionInterval, yPositionInterval));
    }

    private void Start()
    {
        this.airplanePosition = GameObject.FindObjectOfType<Airplane>().transform.position;
        this.score = GameObject.FindObjectOfType<Score>();
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * velocity *Time.deltaTime);

        if(!this.pointed && this.transform.position.x < this.airplanePosition.x)
        {
            this.score.AddPoint();
            this.pointed = !this.pointed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        this.DestroyerObstacle();
    }

    public void DestroyerObstacle()
    {
        GameObject.Destroy(this.gameObject);
    }
}
