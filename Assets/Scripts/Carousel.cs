using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    private Vector3 initialPosition;
    private float realImageWidth;

    private void Awake()
    {
        this.initialPosition = this.transform.position;
        float imageWidth = this.GetComponent<SpriteRenderer>().size.x;
        float imageScale = this.transform.localScale.x;
        this.realImageWidth = imageWidth * imageScale;
    }

    void Update()
    {
        float displacement = Mathf.Repeat(this.velocity * Time.time, this.realImageWidth);
        this.transform.position = this.initialPosition + Vector3.left * displacement;
    }
}
