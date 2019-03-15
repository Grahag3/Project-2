using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool game_started = false;

    public GameObject Intro;
    public GameObject drop;
    public GameObject container;

    public float min_speed;
    public float max_speed;

    float left_right_bounds = 7.9f;

    public float change_chance = 0.3f;
    public float speed_change_chance = 0.3f;

    private Vector3 direction = Vector3.right;

    private float speed;


    private void Awake()
    {

      
    }

    private void SpawnObject()
    {
        if (game_started)
        {
            GameObject drop_instance = Instantiate(drop, transform.position, Quaternion.identity);
            drop_instance.transform.SetParent(container.transform);
            SFX.play_sound("Laser_Shoot36");

        }

    }

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnObject", 2, 2);

        if (game_started)
        {
           
            speed = Random.Range(min_speed, max_speed);
        }
         
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            game_started = true;
            Intro.SetActive(false);

        }
    }

    void FixedUpdate()
    {
        
        if (game_started)
        {
            if (Random.value <= speed_change_chance)
            {
                speed = Random.Range(min_speed, max_speed);
            }
        }
        



        //transform.position += direction * speed;

        if (Random.value <= change_chance)
        {
            speed *= -1;
        }

        
        
        if (transform.position.x <= -left_right_bounds)
        {
            print("went off left");
            speed *= -1;
        }
        else if (transform.position.x >= left_right_bounds)
        {
            print("went off right");
      
            speed *= -1;
        
        }

        transform.position += direction * speed * Time.deltaTime;

    }
}
