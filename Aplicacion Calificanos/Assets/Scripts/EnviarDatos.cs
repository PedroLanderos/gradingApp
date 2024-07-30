using Firebase.Database;
using Google.MiniJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviarDatos : MonoBehaviour
{

    DatabaseReference reference;
    RecopilarDatos recopilarDatos;

    void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>().GetComponent<RecopilarDatos>();
        FirebaseDatabase database = FirebaseDatabase.GetInstance("https://salones-de-belleza-default-rtdb.firebaseio.com/");

        reference = database.RootReference;

    }

    public void EnviarDatosRecopilados()
    {
        Auxiliar auxiliar = new Auxiliar(recopilarDatos.sucursalSeleccionada, recopilarDatos.valorAtencion,
            recopilarDatos.valorServicio, recopilarDatos.valorTiempo, recopilarDatos.citaAgendada);

        string json = JsonUtility.ToJson(auxiliar);

        reference.Child(recopilarDatos.nombreDeEmpleada).Child(recopilarDatos.id[recopilarDatos.index].ToString()).SetRawJsonValueAsync(json);

    }

    public void EnviarID()
    {
        RecopilarDatos recopilarDatos = new RecopilarDatos();

        string json = JsonUtility.ToJson(recopilarDatos);

        if (recopilarDatos.nombreDeEmpleada == "Frida")
        {
            //reference.Child("ID").Child("Frida").set
        }
        if (recopilarDatos.nombreDeEmpleada == "Frida")
        {

        }
        if (recopilarDatos.nombreDeEmpleada == "Frida")
        {

        }

        //reference.Child("ID").Child();
    }

    public void ObtenerIdDeFirebase()
    {
        FirebaseDatabase.GetInstance("https://salones-de-belleza-default-rtdb.firebaseio.com/")
      .GetReference("ServiciosFrida") 
      .GetValueAsync().ContinueWith(task => {
          if (task.IsFaulted)
          {
              // Handle the error...
              Debug.Log("Error al acceder a los datos");
          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              // Do something with snapshot...
              foreach (var id in snapshot.Children)
              {
                  RecopilarDatos datosRecopilados = JsonUtility.FromJson<RecopilarDatos>(id.GetRawJsonValue());
                  //recopilarDatos.id[1] = datosRecopilados.
              }
          }
      });
    }
}
