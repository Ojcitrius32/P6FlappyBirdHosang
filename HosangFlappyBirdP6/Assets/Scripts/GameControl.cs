using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public static GameControl instance;

    public GameObject GameOverText;
        public bool gameover = false;
    public float scrollspeed = -1.5f;
    // Start is called before the first frame update
    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
    }
    public void BirdScored()
    {
        if (gameover)
        {
            return;
        }
        score++;
        scoreText.text = "score:" + score.ToString ();
    }

    public void BirdDied()
    {
        GameOverText.SetActive(true);
        gameover = true;
    }
}
