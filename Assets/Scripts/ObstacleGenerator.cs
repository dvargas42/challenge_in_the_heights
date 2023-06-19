using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private float timeInterval;
    [SerializeField]
    private GameObject ObjectReference;
    private float chronometer;

    private void Awake()
    {
        this.chronometer = this.timeInterval;
    }

    private void Update()
    {
        this.chronometer -= Time.deltaTime;
        if (this.chronometer <= 0)
        {
            GameObject.Instantiate(this.ObjectReference, this.transform.position, Quaternion.identity);
            this.chronometer = this.timeInterval;
        }
    }
}
