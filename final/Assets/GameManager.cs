using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //public static Vector3 startPos;
    //public static Vector3 currentPos;
    Vector3 currentPos; //= new Vector3(2.75f, -1.36f, 0f);
    Vector3 checkpointPos;
    float dangerzone = -21;
    float boatSpeed = 1;

    //Story variables
    bool Penne = false;
    bool Aho = false;
    bool Brent = false;
    bool Jubi = false;
    bool Cat = false;

    int gold = 0;
    int savedGold = 0;
    int xp = 0;
    int savedXP = 0;

    int hp = 0;
    string prevScene = "Davenport";
    Color boatcolor = new Color(1,1,1);
    bool sharkrepellent = false;

    //SINGLETON or PlayerPrefs
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.L))
        //{

        //    SceneManager.LoadScene("SquidBattle");
        //}
        //Debug.Log("Current Pos"+ currentPos);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Ending");
    }

    public void sailingPosSave(Vector3 newPos){
        currentPos = newPos;
        //Debug.Log(newPos);
        //return 
    }
    public void checkpointSave(Vector3 newPos){
        checkpointPos = newPos;
        savedGold = gold;
        savedXP = xp;
        //return 
    }
    public void UnlockRiver(int level)
    {
        if (level == 2)
        {
            dangerzone = -72;
        }
        if (level == 3)
        {
            dangerzone = -1000;
        }
        //return 
    }
    public float DangerZone()
    {
        return dangerzone;
    }
    public void BoatSpeedUp()
    {
        boatSpeed = 10;
    }
    public float BoatSpeed()
    {
        return boatSpeed;
    }
    public void boatDeath(){
        if (hp >= 1)
        {
            hp--; 
        }
        else{
            currentPos = checkpointPos;
            gold = savedGold;
            xp = savedXP;
        }
    }
    public Vector3 getPos(){
        return currentPos;
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    //Story Manager
    public void PenneComp()
    {
        Penne = true;
        Debug.Log("Penne joined the party");
    }
    public bool PenneJoined()
    {
        return Penne;
    }
    public void AhoComp()
    {
        Aho = true;
        Debug.Log("Aho joined the party");
    }
    public bool AhoJoined()
    {
        return Aho;
    }
    public void BrentComp()
    {
        Brent = true;
        Debug.Log("Brent joined the party");
    }
    public bool BrentJoined()
    {
        return Brent;
    }
    public void JubiComp()
    {
        Jubi = true;
        Debug.Log("Jubi joined the party");
    }
    public bool JubiJoined()
    {
        return Jubi;
    }
    public void CatComp()
    {
        Cat = true;
        Debug.Log("Jubi joined the party");
    }
    public bool CatJoined()
    {
        return Cat;
    }
    public string Companions()
    {
        string Comp = "";
        if (Penne)
        {
            Comp += "Penne, ";
        }
        if (Aho)
        {
            Comp += "Aho, ";
        }
        if (Brent)
        {
            Comp += "Brent, ";
        }
        if (Jubi)
        {
            Comp += "Jubi, ";
        }
        if (!Brent && !Aho && !Penne &&!Jubi)
        {
            Comp += "nobody";
        }
        Comp += ".";
        return Comp;
    }
    public void addGold(int goldy)
    {
        gold +=goldy;
    }
    public void addXP(int goldy)
    {
        xp += goldy;
    }
    public int getGold()
    {
        return gold;
    }
    public int getSavedGold()
    {
        return savedGold;
    }
    public int getXP()
    {
        return xp;
    }

    public void SaveScene()
    {
        prevScene=SceneManager.GetActiveScene().name;
        Debug.Log("scenesaved");
    }
    public string storedScene()
    {
         return prevScene;
    }

    public void addHP()
    {
        hp++;
    }
    public int getHP()
    {
        return hp;
    }
    public void boatColor(Color color)
    {
        boatcolor = color;
    }
    public Color getboatcolor()
    {
        return boatcolor;
    }


    public void SharkRepellent()
    {
        sharkrepellent =true;
    }
    public bool isSharkRepellent()
    {
        return sharkrepellent;
    }
}
