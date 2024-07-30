using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Auxiliar : MonoBehaviour
{

    #region enviarDatos
    public string SucursalSeleccionada;
    public float CalificacionAtencion;
    public float CalificacionServicio;
    public float CalificacionTiempo;
    public bool SiguienteCita;
    #endregion

    public Auxiliar(string Sucursal, float CalifAtencion, float CalifServicio, float CalifTiempo, bool CitaOfrecida)
    {
        this.SucursalSeleccionada = Sucursal;
        this.CalificacionAtencion = CalifAtencion;
        this.CalificacionServicio = CalifServicio;
        this.CalificacionTiempo = CalifTiempo;
        this.SiguienteCita = CitaOfrecida;
    }

    public Auxiliar()
    {

    }



}
