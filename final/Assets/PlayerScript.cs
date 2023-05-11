using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool stopmove = false;
    Rigidbody2D rb;
    BoxCollider2D box;
    public LayerMask mask;
    public float speed;
    public GameObject cam;
    Vector3 startPos;
    Vector3 currentPos;
    GameManager gm;
    float timerEn;
    public float encounterTimer;
    public TMP_Text interfaceText;
    public TMP_Text goldText;
    public TMP_Text XPText;

    public Animator anim;

    public Vignette vig;
    public PostProcessVolume ppp;


    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
        //startPos = gm.getPos();
        // gameObject.transform.position = startPos;
        //currentPos
        //ppp.profile.TryGetSettings(out vig);
        gm.SaveScene();
    }

    // Update is called once per frame
    void Update()
    {
        //currentPos = rb.transform.position;
        //timerEn += Time.deltaTime;
        //if (timerEn >= encounterTimer)
        //{
        //    timerEn = 0;
        //    Encounter();
        //    Debug.Log("10sec");

        //}
        //gm.sailingPosSave(currentPos);
        goldText.text = gm.getGold().ToString() + " Gold Coins";
        XPText.text = gm.getXP().ToString() + " XP";
        //Debug.Log(stopmove);

    }
    void FixedUpdate()
    {
        if (!stopmove)
        {
            //cam.transform.position = new Vector3(cam.transform.position.x, gameObject.transform.position.y, cam.transform.position.z);
            if (Input.GetKey(KeyCode.W))
            {
                //transform.eulerAngles = new Vector3(0, 0, 90);
                //vig.intensity.value = 1;

                rb.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
                //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

                //rb.AddForce(Vector2.up*speed);
                //Debug.Log("Up");
            }
            if (Input.GetKey(KeyCode.S))
            {
                //transform.eulerAngles = new Vector3(0, 0, -90);
                rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
                //cam.transform.position -= Vector3(0, gameObject.transform.position.y, 0);

                //rb.AddForce(Vector2.up*speed);
                //Debug.Log("Up");
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
                //transform.eulerAngles = new Vector3(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                //transform.eulerAngles = new Vector3(0, 0, 0);
                rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.U)&& Input.GetKey(KeyCode.B))
            {
                
                    gm.addGold(1000);
                
            }
            //if (Input.GetKey(KeyCode.L))
            //{
            //    SceneManager.LoadScene("SquidBattle");
            //}
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
            if (other.CompareTag("Port"))
            {
                interfaceText.text = "Press E to Sail";
                Debug.Log("port");
                //vig.intensity.value = 1;

                if (Input.GetKey(KeyCode.E))
                {
                    gm.boatDeath();
                    SceneManager.LoadScene("ShipTravel");
                }
            }
            else if (other.CompareTag("Town Hall"))
            {
                interfaceText.text = "Press E to Enter Town Hall";
                Debug.Log("port");
                //vig.intensity.value = 1;

                if (Input.GetKey(KeyCode.E))
                {
                    //gm.boatDeath();
                    SceneManager.LoadScene("TownHall");
                }
            }
            else if (other.CompareTag("Pyramid"))
            {
                interfaceText.text = "Press E to Enter Pyramid";
                Debug.Log("port");
                //vig.intensity.value = 1;

                if (Input.GetKey(KeyCode.E))
                {
                    //gm.boatDeath();
                    SceneManager.LoadScene("Pyramid");
                }
            }
            else if (other.CompareTag("Moroe"))
            {
                interfaceText.text = "Press E to Enter House";
                Debug.Log("Moroe");
                //vig.intensity.value = 1;

                if (Input.GetKey(KeyCode.E))
                {
                    //gm.boatDeath();
                    SceneManager.LoadScene("Moroe");
                }
            }
            else if (other.CompareTag("Market"))
            {
                interfaceText.text = "Press E to Enter Market";
                if (Input.GetKey(KeyCode.E))
                {
                    //gm.SaveScene();
                    anim.SetTrigger("MarketEnter");
                    stopmove = true;
                    
                    //SceneManager.LoadScene("Market");

                }

            }
            else if (other.CompareTag("Boat"))
            {
                interfaceText.text = "Press E to Enter Boat";
                if (Input.GetKey(KeyCode.E))
                {
                    //gm.boatDeath();
                    gm.SaveScene();
                    Debug.Log(gm.storedScene());
                    SceneManager.LoadScene("Boat");
                }

            }
            else if (other.CompareTag("DeadHouse"))
            {

                interfaceText.text = "You gaze upon the ashes of your old home.";
            }
            else
            {
                interfaceText.text = "";
            }

            //if (other.collider.CompareTag("DeadHouse"))
            //    {

            //        interfaceText.text = "Press E to Sail";
            //    }

        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        interfaceText.text = "";
    }
    public void buyHP()
    {
        if (gm.getGold() >= 200)
        {
            gm.addGold(-200);
            gm.addHP();
        }
    }
    public void buyPaintJob( string color)
    {
        //Color bc;
        if (gm.getGold() >= 5200)
        {
            if (color == "pink")
            {
                gm.addGold(-5200);
                gm.boatColor(new Color(1f, .5f, .9f));
            }
            if (color == "orange")
            {
                gm.addGold(-5200);
                gm.boatColor(new Color(1f, .6f, 0f));
            }
            if (color == "black")
            {
                gm.addGold(-5200);
                gm.boatColor(new Color(.2f, .2f, .2f));
            }
            if (gm.getGold() >= 10400 && color == "gold")
            {
                gm.addGold(-10400);
                gm.boatColor(new Color(.9f, .9f, .09f));
            }
        }
    }
    public void BuyJubilee()
    {
        if (gm.getGold() >= 10100)
        {
            gm.addGold(-10100);
            gm.CatComp();
        }
    }
    public void hireJubi()
    {
        if (gm.getGold() >= 8000)
        {
            gm.addGold(-8000);
            gm.JubiComp();
        }
    }
    public void stopMove()
    {
        stopmove = false;
    }
}

