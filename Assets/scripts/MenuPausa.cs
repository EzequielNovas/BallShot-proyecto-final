using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
    public GameObject menuDePausa;
    private bool menuOn;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuOn = !menuOn;
        }

        if(menuOn == true)
        {
            menuDePausa.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            menuDePausa.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Reanudar()
    {
        menuDePausa.SetActive(false);
        menuOn = false;
    }

    public void VolverAlInicio()
    {
        SceneManager.LoadScene(0);
     
    }
    

}
