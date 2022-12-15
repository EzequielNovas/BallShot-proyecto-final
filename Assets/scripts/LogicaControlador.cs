using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicaControlador : MonoBehaviour
{
    public GameObject panelGane;
    public int numEnemigos;
    public GameObject camara;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void SiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Debug.Log("salir...");
        Application.Quit();
    }
}
