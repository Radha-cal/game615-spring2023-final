using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BoatDangerScript : MonoBehaviour
{ 



    // Start is called before the first frame update
    Rigidbody2D rb;
    BoxCollider2D box;
    public GameObject rock;
    public LayerMask mask;
    public float speed;
    public float currentSpeed;
    public float spawnSpeed=2;
    //public GameObject cam;
    Vector3 startPos;
    Vector3 currentPos;
    GameManager gm;
    float timerEn;
    public float encounterTimer;
    public Animator ani;
    public TMP_Text timerText;
    float timer = 10;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
        //startPos = gm.getPos();
        //gameObject.transform.position = startPos;
        //currentPos
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            //gm.boatDeath();
            gm.addXP(45);
            SceneManager.LoadScene("ShipTravel");
        }
        int tim = ((int)timer);
        timerText.text = tim.ToString();
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
        //currentPos = rb.transform.position;
        //timerEn += Time.deltaTime;
        //if (timerEn >= encounterTimer)
        //{
        //    timerEn = 0;
        //    //Encounter();
        //    Debug.Log("10sec");

        //}
        //gm.sailingPosSave(currentPos);
        if (Input.GetKey(KeyCode.W))
        {
            
            //transform.eulerAngles = new Vector3(0, 0, 90);
            rb.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
            //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

            //rb.AddForce(Vector2.up*speed);
            Debug.Log("Up");
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.eulerAngles = new Vector3(0, 0, -90);
            rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
            //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

            //rb.AddForce(Vector2.up*speed);
            Debug.Log("Down");
        }
        timerEn += Time.deltaTime;
        if (timerEn >= spawnSpeed)
        {
            timerEn = 0;
            Vector3 rocPos = new Vector3(9, Random.Range(-.5f, -2.5f),0);
            Instantiate(rock, rocPos, Quaternion.identity);
            //Encounter();
            Debug.Log("10sec");

        }


        //transform.eulerAngles = new Vector3(0, 0, 0);
        //rb.MovePosition(transform.position + Vector3.right * currentSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Obstacles"))
        {
            ani.SetTrigger("Wipeout");
            gm.boatDeath();
            SceneManager.LoadScene("ShipTravel");

        }
    }
    //public void LoadGame(){
    //    SceneManager.LoadScene("SquidBattle");
    //}
    //void Encounter()
    //{
    //    int randEnem = Random.Range(0, 12);
    //    Debug.Log(randEnem);
    //    Debug.Log("CHUNGUS");
    //    if (randEnem >= 0 && randEnem < 4)
    //    {
    //        gm.sailingPosSave(currentPos);
    //        SceneManager.LoadScene("SquidBattle");
    //    }
    //    else if (randEnem >= 4 && randEnem < 8)
    //    {
    //        SceneManager.LoadScene("PirateBattle");
    //    }
    //    //else if (randEnem == 3)
    //    //{
    //    //    SceneManager.LoadScene("Pirate Battle");
    //    //}
    //}
}
