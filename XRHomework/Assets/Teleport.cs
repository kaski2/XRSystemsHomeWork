using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference action;
    bool startingPoint = true;
    void Start()
    {
        action.action.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        action.action.performed += (ctx) => {
            if(startingPoint){
                transform.position = new Vector3(-40f, 1.7f, 0f);
                startingPoint = !startingPoint;
            }else {
                transform.position = new Vector3(0f, 1.7f, 0f);
                startingPoint = !startingPoint;
            }
        };
    }
}
