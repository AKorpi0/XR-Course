using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public Light flash;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    bool power = false;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;   
    }

   private void OnTriggerEnter(Collider other) {
        if(!isPressed && power == true)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
   }

   private void OnTriggerExit(Collider other) {
        if(other.gameObject == presser ){
            button.transform.localPosition = new Vector3 ( 0, 0.015f, 0);
            isPressed = false;
            power = false;
            flash.enabled = false;
            onRelease.Invoke();
        }
   }

   public void SpawnSphere(){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
   }

   public void turnOn(){
    flash.enabled = true;
    power = true;
   }
}
