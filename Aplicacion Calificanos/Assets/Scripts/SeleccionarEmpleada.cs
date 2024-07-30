using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeleccionarEmpleada : MonoBehaviour
{
    RecopilarDatos recopilarDatos;

    private void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>();
        var dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();

        List<string> empledas = new List<string>();
        empledas.Add("Paola");
        empledas.Add("Indira");
        empledas.Add("Frida");

        foreach (var item in empledas)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item});
        }

        DropdownSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownSelected(dropdown); });
    }

    private void DropdownSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        recopilarDatos.nombreDeEmpleada = dropdown.options[index].text;

    }

    
}
