using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    private bool game_started = true;

    private float edge = 7.9f;
    private Vector3 direction_right = Vector3.right;
    private Vector3 direction_left = Vector3.left;

    public float speed;

    public GameObject ScoreCounter;
    private Score score;

    private void Awake()
    {
        score = ScoreCounter.GetComponent<Score>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        score.score += 20;
        SFX.play_sound("Pickup_Coin");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            game_started = true;
        }
        */
        if (game_started)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += direction_right * speed;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += direction_left * speed;
            }

            if (transform.position.x > edge)
            {
                transform.position = new Vector3(edge, transform.position.y, transform.position.z);
            }
            if (transform.position.x < -edge)
            {
                transform.position = new Vector3(-edge, transform.position.y, transform.position.z);
            }
        }
       
    }
}
