using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    Text text;
    public int current_lives;
    public int max_lives = 3;

    //public GameObject End;

    private void Awake()
    {
        text = GetComponent<Text>();
        current_lives = max_lives;
    }

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Ships:" + current_lives;

        if (current_lives == 0)
        {
            Time.timeScale = 0;
            //End.SetActive(true);
            SceneManager.LoadScene("Ending");

            
        }
    }
}
