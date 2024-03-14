using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{
    
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public GameObject self;
    public GameObject winscreen;
    public GameObject lossscreen;
    public Material material;
    private float timer = 5;
    private int successes = 10;
    private bool activebutton = false;

    private bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (successes < 1){
            Win();
        }else{
            timer -= Time.deltaTime;
            if(!start){
                timer = 5;
            }else{
                if (timer < 0)
                {
                    Lose();
                }
                if (!activebutton)
                {
                    int rand = Random.Range(1,4);
                    if (rand == 1){
                        button1.turnOn();
                    }
                    if (rand == 2){
                        button2.turnOn();
                    }
                    if (rand == 3){
                        button3.turnOn();
                    }
                    if (rand == 4){
                        button4.turnOn();
                    }
                    activebutton = !activebutton;
                }

            }
        }
    }

    public void Reset()
    {
        timer = 5;
        successes -= 1;
        activebutton = !activebutton;
    }

    void Win()
    {
        winscreen.SetActive(true);
        self.SetActive(false);
        for (int i = 0; i < 50; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            sphere.transform.localPosition = new Vector3(0, 1, 2);
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<MeshRenderer>().material = material;
        }
    }

    void Lose()
    {
        lossscreen.SetActive(true);
        self.SetActive(false);

    }

    public void StartGame(){
        successes = 10;
        lossscreen.SetActive(false);
        winscreen.SetActive(false);
        start = true;
    }
}
