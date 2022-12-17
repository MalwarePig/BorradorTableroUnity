using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableTiles : MonoBehaviour
{
      [SerializeField] GameObject TileSelected;

   void OnMouseExit()
    { 
       TileSelected.SetActive(false);
    }
}
