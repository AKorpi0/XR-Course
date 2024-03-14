using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Switch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
     light = GetComponent<Light>();   
     action.action.Enable();
     action.action.performed += (ctx) =>
        {
            if(light.color == Color.white)
            {
                light.color = Color.magenta;
            }
            else
            {
                light.color = Color.white;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
    }
}
