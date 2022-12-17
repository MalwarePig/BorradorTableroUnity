using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField] GameObject TileSelected;


    void OnMouseOver()
    {
        TileSelected.SetActive(true);
    }

 

}

