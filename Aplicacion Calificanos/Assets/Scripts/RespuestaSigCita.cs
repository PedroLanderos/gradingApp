using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespuestaSigCita : MonoBehaviour
{
    public string respuestaCita;
    public bool citaOfrecida;
    RecopilarDatos recopilarDatos;
    private void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>();
        var dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();

        List<string> sucursales = new List<string>();
        sucursales.Add("Si");
        sucursales.Add("No");

        foreach (var item in sucursales)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropdownSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownSelected(dropdown); });

    }

    private void DropdownSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        respuestaCita = dropdown.options[index].text;

        if (respuestaCita == "Si")
        {
            recopilarDatos.citaAgendada = true;
        }
        if (respuestaCita == "No")
        {
            recopilarDatos.citaAgendada = false;
        }

    }
}
