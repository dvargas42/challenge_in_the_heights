using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
   private Rigidbody2D fisica;
   [SerializeField]
   private float force;
   private Director director;
   private Vector3 initialPosition;

   private void Awake()
   {
        this.initialPosition = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
   }

   private void Start()
   {
        this.director = GameObject.FindObjectOfType<Director>();
   }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
    }

    public void restartPosition()
    {
        this.transform.position = this.initialPosition;
        this.fisica.simulated = true;
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.director.EndGame();
    }
}
