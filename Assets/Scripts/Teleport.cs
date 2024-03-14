using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    private int place = 1;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            transform.position += Vector3.left * 27.5f * place; 
            place = place * -1;
        };
        
    }
}
