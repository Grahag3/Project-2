using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            music.Stop();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
  
        