using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject manager;
    public RecopilarDatos recopilarDatos;
    public Animator fadePanelAnimator;

    private void Start()
    {
        recopilarDatos = FindObjectOfType<RecopilarDatos>().GetComponent<RecopilarDatos>();
    }

    public void CargarPantallaPuntuacion()
    {
        DontDestroyOnLoad(manager);
        AsignarID();
        fadePanelAnimator.SetTrigger("FadeIn");
        Invoke("LoadSlidersScene", 0.5f) ;
    }

    public void CargarUltimaPantalla()
    {
        DontDestroyOnLoad(manager);
        SceneManager.LoadScene("PantallaFinal");
    }

    public void CargarPrimeraPantalla()
    {
        DontDestroyOnLoad(manager);
        SceneManager.LoadScene("SampleScene");
    }

    public void AsignarID()
    {
        if (recopilarDatos.nombreDeEmpleada == "Paola")
        {
            if (PlayerPrefs.GetInt("idPaola", recopilarDatos.id[0]) == 0)
            {
                recopilarDatos.id[0]++;
                recopilarDatos.index = 0;
                PlayerPrefs.SetInt("idPaola", recopilarDatos.id[0]);
            }
            else
            {
                recopilarDatos.id[0] = PlayerPrefs.GetInt("idPaola", recopilarDatos.id[0]);
                recopilarDatos.id[0]++;
                recopilarDatos.index = 0;
                PlayerPrefs.SetInt("idPaola", recopilarDatos.id[0]);
            }

        }
        if (recopilarDatos.nombreDeEmpleada == "Indira")
        {

            if (PlayerPrefs.GetInt("idIndira", recopilarDatos.id[1]) == 0)
            {
                recopilarDatos.id[1]++;
                recopilarDatos.index = 1;
                PlayerPrefs.SetInt("idIndira", recopilarDatos.id[1]);
            }
            else
            {
                recopilarDatos.id[1] = PlayerPrefs.GetInt("idIndira", recopilarDatos.id[1]);
                recopilarDatos.id[1]++;
                recopilarDatos.index = 1;
                PlayerPrefs.SetInt("idIndira", recopilarDatos.id[1]);
            }

        }
        if (recopilarDatos.nombreDeEmpleada == "Frida")
        {
            if (PlayerPrefs.GetInt("idFrida", recopilarDatos.id[2]) == 0)
            {
                recopilarDatos.id[2]++;
                recopilarDatos.index = 2;
                PlayerPrefs.SetInt("idFrida", recopilarDatos.id[2]);
            }
            else
            {
                recopilarDatos.id[2] = PlayerPrefs.GetInt("idFrida", recopilarDatos.id[2]);
                recopilarDatos.id[2]++;
                recopilarDatos.index = 2;
                PlayerPrefs.SetInt("idFrida", recopilarDatos.id[2]);
            }
        }
    }

    public void AsignarID2()
    {
        if (recopilarDatos.nombreDeEmpleada == "Paola")
        {
            if (PlayerPrefs.GetInt("idPaola", recopilarDatos.id[0]) == 0)
            {
                recopilarDatos.id[0]++;
                recopilarDatos.index = 0;
                PlayerPrefs.SetInt("idPaola", recopilarDatos.id[0]);
            }
            else
            {
                recopilarDatos.id[0] = PlayerPrefs.GetInt("idPaola", recopilarDatos.id[0]);
                recopilarDatos.id[0]++;
                recopilarDatos.index = 0;
                PlayerPrefs.SetInt("idPaola", recopilarDatos.id[0]);
            }

        }
        if (recopilarDatos.nombreDeEmpleada == "Indira")
        {

            if (PlayerPrefs.GetInt("idIndira", recopilarDatos.id[1]) == 0)
            {
                recopilarDatos.id[1]++;
                recopilarDatos.index = 1;
                PlayerPrefs.SetInt("idIndira", recopilarDatos.id[1]);
            }
            else
            {
                recopilarDatos.id[1] = PlayerPrefs.GetInt("idIndira", recopilarDatos.id[1]);
                recopilarDatos.id[1]++;
                recopilarDatos.index = 1;
                PlayerPrefs.SetInt("idIndira", recopilarDatos.id[1]);
            }

        }
        if (recopilarDatos.nombreDeEmpleada == "Frida")
        {
            if (PlayerPrefs.GetInt("idFrida", recopilarDatos.id[2]) == 0)
            {
                recopilarDatos.id[2]++;
                recopilarDatos.index = 2;
                PlayerPrefs.SetInt("idFrida", recopilarDatos.id[2]);
            }
            else
            {
                recopilarDatos.id[2] = PlayerPrefs.GetInt("idFrida", recopilarDatos.id[2]);
                recopilarDatos.id[2]++;
                recopilarDatos.index = 2;
                PlayerPrefs.SetInt("idFrida", recopilarDatos.id[2]);
            }
        }
    }

    

    public void CrearID()
    {

    }

    public void EliminarID()
    {
        PlayerPrefs.DeleteAll();
    }


    public void LoadSlidersScene()
    {
        SceneManager.LoadScene("Puntuaciones");
    }

}
