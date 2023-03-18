using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float flapStrength;
    // Start is called before the first frame update
     public LogicManagerScript logic;
     public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidBody.velocity  = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        logic.toggleGameOver();
        birdIsAlive = false;
    }
}
