using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distance = 100f;

        //Origen - Dirección - Color - duracion - depthTest
        //V3, V2 -  V3, V2 -   color - float    -   bool   
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);

 */ 
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit)
            {
                Debug.Log( hit.transform.name);
            }
    }
}
