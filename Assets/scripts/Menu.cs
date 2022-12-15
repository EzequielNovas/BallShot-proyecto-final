using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void Salir()
    {
        Debug.Log("salir...");
        Application.Quit();
    }
    public void SeleccionarNivel(int NumeroNivel)
    {
        SceneManager.LoadScene(NumeroNivel);
        Time.timeScale = 1f;
    }
}
