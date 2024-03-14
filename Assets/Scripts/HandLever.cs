using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLever : MonoBehaviour
{
    public Transform lever;
    public GameObject hand1;
    public GameObject hand2;
    public GameObject hand3;
    public GameObject hand4;
    // Start is called before the first frame update
    void Start()
    {
        hand1.SetActive(false);
        hand2.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if(lever.eulerAngles.x > 290f && lever.eulerAngles.x < 300f){
            
            hand1.SetActive(true);
            hand2.SetActive(true);
            hand3.SetActive(false);
            hand4.SetActive(false);
        }
        if(lever.eulerAngles.x > 50f && lever.eulerAngles.x < 60f){
            
            hand1.SetActive(false);
            hand2.SetActive(false);
            hand3.SetActive(true);
            hand4.SetActive(true);
            
        }
    }
}
