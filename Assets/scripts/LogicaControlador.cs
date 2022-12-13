using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicaControlador : MonoBehaviour
{
    public GameObject panelGane;
    public int numEnemigos;

    void Start()
    {
        numEnemigos = GameObject.FindGameObjectsWithTag("enemigo").Length;
        panelGane.SetActive(false);
    }

    void update()
    {

    }

    public void RestarEnemigos()
    {
        numEnemigos--;
        if (numEnemigos <= 0)
        {
            panelGane.SetActive(true);
        }
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
