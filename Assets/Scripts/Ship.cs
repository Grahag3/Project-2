using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject LifeCounter;

    private Lives lives;

    private void Awake()
    {
        lives = LifeCounter.GetComponent<Lives>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
        lives.current_lives -= 1;
        SFX.play_sound("Explosion41");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
