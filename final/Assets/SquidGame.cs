using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class SquidGame : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 5;
    int health = 4;
    public TMP_Text timerText;
    GameManager gm;
    
    void Start()
    {
       gm = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gm.addXP(30);
            SceneManager.LoadScene("ShipTravel");
        }
        if (timer <= 0)
        {
            gm.boatDeath();
            SceneManager.LoadScene("ShipTravel");
        }
        timer -= Time.deltaTime;
        int tim = ((int)timer);
        timerText.text = tim.ToString();
    }
    public void Shot()
    {
        health--;
        Debug.Log(health);
    }
}
