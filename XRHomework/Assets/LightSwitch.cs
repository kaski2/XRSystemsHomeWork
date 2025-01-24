using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        bool lightState = false;
        action.action.performed += (ctx) =>
        {
            if(!lightState){
                light.color = new Color(10, 0, 0);
                lightState = !lightState;
            }else {
                light.color = new Color(10, 10, 10);
                lightState = !lightState;
            }
            
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
