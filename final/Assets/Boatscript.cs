using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Boatscript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    BoxCollider2D box;
    public LayerMask mask;
    float speed;
    public GameObject cam;
    Vector3 startPos;
    Vector3 currentPos;
    GameManager gm;
    float timerEn;
    public float encounterTimer;

    public TMP_Text goldText;
    public TMP_Text XPText;

    public Color bc;


    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
        startPos = gm.getPos();
        gameObject.transform.position = startPos;
        speed = gm.BoatSpeed();
        bc = gm.getboatcolor();
        //currentPos
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = gm.getGold().ToString() + " Gold Coins";
        XPText.text = gm.getXP().ToString() + " XP";
        // if (Input.GetKey(KeyCode.W)){
        //   transform.eulerAngles = new Vector3(0,0,90);  
        //   transform.position += Vector3.up*speed*Time.deltaTime;
        //   //cam.transform.position += Vector3.up*speed*Time.deltaTime;
        // //rb.AddForce(Vector2.up*speed);
        // Debug.Log("Up");
        // }
        // // if (Input.GetKey(KeyCode.S)){
        // //   transform.eulerAngles = new Vector3(0,0,-90);
        // //   rb.MovePosition(transform.position + Vector3.down*speed*Time.deltaTime);
        // //   cam.transform.position -= Vector3.up*speed*Time.deltaTime;

        // // //rb.AddForce(Vector2.up*speed);
        // // Debug.Log("Up");
        // // }
        // if (Input.GetKey(KeyCode.A)){
        //     transform.position += Vector3.left*speed*Time.deltaTime; 
        //     transform.eulerAngles = new Vector3(0,180,0);       }
        // if (Input.GetKey(KeyCode.D)){
        //     transform.eulerAngles = new Vector3(0,0,0);
        //     transform.position += Vector3.right*speed*Time.deltaTime;        }
        currentPos =rb.transform.position;
        timerEn += Time.deltaTime;
        if (rb.transform.position.y <= gm.DangerZone())
        {
            if (timerEn >= 1)
            {
                timerEn = 0;
                gm.addXP(10);
                Encounter();
                Debug.Log("Dangersec");

            }
        }
        else if ( timerEn>= encounterTimer) {
            timerEn = 0;
            gm.addXP(10);
            Encounter();
            Debug.Log("10sec");

        }
        gm.sailingPosSave(currentPos);
    }
    void FixedUpdate()
    {
        cam.transform.position = new Vector3(cam.transform.position.x, gameObject.transform.position.y, cam.transform.position.z);
        if (Input.GetKey(KeyCode.W)){
          transform.eulerAngles = new Vector3(0,0,90);
          rb.MovePosition(transform.position + Vector3.up*speed*Time.deltaTime);
          //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

        //rb.AddForce(Vector2.up*speed);
        //Debug.Log("Up");
        }
        if (Input.GetKey(KeyCode.S)){
          transform.eulerAngles = new Vector3(0,0,-90);
          rb.MovePosition(transform.position + Vector3.down*speed*Time.deltaTime);
          //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

        //rb.AddForce(Vector2.up*speed);
        //Debug.Log("Up");
        }
        if (Input.GetKey(KeyCode.A)){
            rb.MovePosition(transform.position + Vector3.left*speed*Time.deltaTime); 
            transform.eulerAngles = new Vector3(0,180,0);       }
        if (Input.GetKey(KeyCode.D)){
            transform.eulerAngles = new Vector3(0,0,0);
            rb.MovePosition(transform.position + Vector3.right*speed*Time.deltaTime);        }
        //if (Input.GetKey(KeyCode.L))
        //{
        //    SceneManager.LoadScene("SquidBattle");
        //}
    }
    private void OnCollisionEnter2D(Collision2D other){
        if (other.collider.CompareTag("Obstacles"))
        {
            //Debug.Log(rb.transform.position);
            gm.sailingPosSave(currentPos);
            //Debug.Log(gm.getPos());
            //SceneManager.LoadScene("SquidBattle");
        }
        if (other.collider.CompareTag("Davenport"))
        {
            gm.checkpointSave(new Vector3(1.45f, -1.36f, 0f));
            SceneManager.LoadScene("Davenport");
        }
        if (other.collider.CompareTag("Louisville"))
        {
            gm.checkpointSave( new Vector3(-0.82f, -16.4f, 0f));
            SceneManager.LoadScene("Louisville");
        }
        if (other.collider.CompareTag("Memphis"))
        {
            gm.checkpointSave(new Vector3(-0.1f, -46.5f, 0));
            SceneManager.LoadScene("RPGSection");
        }
        if (other.collider.CompareTag("New Orleans"))
        {
            gm.checkpointSave(new Vector3(1.45f, -106.4f, 0));
            SceneManager.LoadScene("RPGSection");
        }
    }
    //public void LoadGame(){
    //    SceneManager.LoadScene("SquidBattle");
    //}
    void Encounter()
    {
        int randEnem = Random.Range(0, 12);
        Debug.Log(randEnem);
        Debug.Log("CHUNGUS");
        if (randEnem >= 0 && randEnem < 3)
        {
            gm.sailingPosSave(currentPos);
            SceneManager.LoadScene("SquidBattle");
        }
        else if (randEnem >= 3 && randEnem <6)
        {
            SceneManager.LoadScene("PirateBattle");
        }
        
        else if (randEnem >= 6 && randEnem < 11)
        {
          SceneManager.LoadScene("RapidsEncounter");
        
        }
    }
}
