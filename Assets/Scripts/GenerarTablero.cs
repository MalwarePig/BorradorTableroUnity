using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarTablero : MonoBehaviour
{
    [SerializeField] GameObject[] gridPrefab;
    [SerializeField] float Tamaño;

    [SerializeField] Transform Maincamara;
    void Start()
    {
        //Generar Tablero
        for (int i = 0; i < Tamaño; i++)
        {
            for (int j = 0; j < Tamaño; j++)
            {
                if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0))//
                {
                    GameObject grid = Instantiate(gridPrefab[0]);
                    grid.name = "Casilla" + i + "," + j;
                    grid.transform.position = new Vector3(i, j, 0f);
                }
                else
                {
                    GameObject grid = Instantiate(gridPrefab[1]);
                    grid.name = "Casilla" + i + "," + j;
                    grid.transform.position = new Vector3(i, j, 0f);
                }
            }
        }

        //Localizar camara
        Maincamara.transform.position = new Vector3(Tamaño / 2 - 0.5f, Tamaño / 2 - 0.5f, -5);
    }

   



}
