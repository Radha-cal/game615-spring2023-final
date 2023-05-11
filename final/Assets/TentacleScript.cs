using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TentacleScript : MonoBehaviour
{
    // Start is called before the first frame update
    float targetNum = 3;
    GameManager gm;
    //public GameObject enemy;
    public Animator ani;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (targetNum <= 0)
        //{
        //    SceneManager.LoadScene("ShipTravel");
        //}
    }

    private void OnMouseDown()
    {
        Destroy(gameObject.GetComponent<Collider2D>());
        ani.SetTrigger("hitTentacle");
        //GameObject.Find("Pirate Ship").GetComponent<Pirategame>().Shot();
        GameObject.Find("Squid").GetComponent<SquidGame>().Shot();


    }
}
