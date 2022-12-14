using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public GameObject efecto;
    public LogicaControlador logicaControlador;
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnMouseDown()
    {
        Instantiate(efecto, transform.position, Quaternion.identity);
        logicaControlador.RestarEnemigos();
        Destroy(gameObject);
    }
}
