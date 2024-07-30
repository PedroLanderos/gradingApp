using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class RecopilarDatos : MonoBehaviour
{
    public string nombreDeEmpleada;
    public string sucursalSeleccionada;
    public float valorTiempo;
    public float valorAtencion;
    public float valorServicio;
    public bool citaAgendada;
    public int[] id = new int[3];
    public int index;

}
