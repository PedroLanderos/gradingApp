using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeleccionSucursal : MonoBehaviour
{
    RecopilarDatos recopilarDatos;
    public string sucursalSeleccionada;
    private void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>();
        var dropdown = GetComponent<Dropdown>();
        dropdown.options.Clear();

        List<string> sucursales = new List<string>();
        sucursales.Add("Cimatario");
        sucursales.Add("Mirador");
        
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

        recopilarDatos.sucursalSeleccionada = dropdown.options[index].text;

    }

}
