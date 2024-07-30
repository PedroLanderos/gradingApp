using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrellasManager : MonoBehaviour
{

    private int puntuacion = 0;
    private float time = 0;

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= 2.3f)
        {
            Debug.Log(puntuacion);
            time = 0;
        }
    }
    public void puntuacion1()
    {
        puntuacion = 1;
    }

    public void puntuacion2()
    {
        puntuacion = 2;
    }

    public void puntuacion3()
    {
        puntuacion = 3;
    }

    public void puntuacion4()
    {
        puntuacion = 4;
    }

    public void puntuacion5()
    {
        puntuacion = 5;
    }


}
