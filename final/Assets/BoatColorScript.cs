using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BoatColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Tilemap t;
    public Tilemap t2;
    //public Color color;
    GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gm.boatColor(new Color(1f, .5f, .9f));
        t.color = gm.getboatcolor();
        t2.color = gm.getboatcolor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
