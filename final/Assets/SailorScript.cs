using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class SailorScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager gm;
    Rigidbody2D rb;
    BoxCollider2D box;
    bool stopmove = false;

    public TMP_Text interfaceText;
    public TMP_Text goldText;
    public TMP_Text XPText;
    public TMP_Text inventoryText;
    public Animator anim;

    float speed = 5;

    public GameObject Jubi;
    public GameObject Penne;
    public GameObject Aho;
    public GameObject Brent;
    public GameObject Jubilee;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        box = gameObject.GetComponent<BoxCollider2D>();
        if (!gm.JubiJoined())
        {
            Destroy(Jubi);
        }
        if (!gm.PenneJoined())
        {
            Destroy(Penne);
        }
        if (!gm.AhoJoined())
        {
            Destroy(Aho);
        }
        if (!gm.BrentJoined())
        {
            Destroy(Brent);
        }
        if (!gm.CatJoined())
        {
            Destroy(Jubilee);
        }

    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = gm.getGold().ToString() + " Gold Coins";
        XPText.text = gm.getXP().ToString() + " XP";
        inventoryText.text = "You have " + gm.getHP().ToString() + " Health Packs in storage";
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
            if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.U) && Input.GetKey(KeyCode.B))
            {

                gm.addGold(1000);

            }
            if (Input.GetKey(KeyCode.L))
            {
                string ls = gm.storedScene();
                SceneManager.LoadScene(ls);

            }
            //if (Input.GetKey(KeyCode.L))
            //{
            //    SceneManager.LoadScene("SquidBattle");
            //}
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Inventory"))
        {
            interfaceText.text = "Press E to Access Inventory";
            if (Input.GetKey(KeyCode.E))
            {
                //gm.SaveScene();
                anim.SetTrigger("MarketEnter");
                stopmove = true;

                //SceneManager.LoadScene("Market");

            }
        }
        else if (other.CompareTag("Jubi"))
        {
            Debug.Log("Jubi");
            interfaceText.text = "Jubi: I've got my pirates grabbing loot for us. Passive income. You're welcome!";
        }
        else if (other.CompareTag("Penne"))
        {
            Debug.Log("Penne");
            interfaceText.text = "Penne: This is just like old times with your aunt!";
        }
        else if (other.CompareTag("Aho"))
        {
            Debug.Log("Aho");
            interfaceText.text = "Aho: The river looks so beautiful today!";
        }
        else if (other.CompareTag("Brent"))
        {
            Debug.Log("Brent");
            interfaceText.text = "Brent:This has been quite a wacky turn of events, I have to admit.";
        }
        else if (other.CompareTag("Jubilee"))
        {
            Debug.Log("Brent");
            interfaceText.text = "Jubilee the Cat: MEOWWW";
        }
        else
        {
            interfaceText.text = "";
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        interfaceText.text = "Press L to Disenbark";
    }
    public void stopMove()
    {
        stopmove = false;
    }
}
