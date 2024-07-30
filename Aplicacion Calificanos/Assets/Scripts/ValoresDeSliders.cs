using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValoresDeSliders : MonoBehaviour
{
    RecopilarDatos recopilarDatos;
    public Slider sliderAtencion, sliderServicio, sliderTiempo;
    public float valorSliderAtencion, valorSliderServicio, valorSliderTiempo;

    private void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>();
    }

    private void Update()
    {
        AsignarValores();
    }

    public void AsignarValores()
    {
        recopilarDatos.valorAtencion = sliderAtencion.value;
        recopilarDatos.valorServicio = sliderServicio.value;
        recopilarDatos.valorTiempo = sliderTiempo.value;
    }

}
