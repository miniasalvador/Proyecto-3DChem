using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenas : MonoBehaviour
{

    public void RegresarMenu() 
    {
        SceneManager.LoadScene("Inicio"); 
    }
    
    public void AtomoScene()
    {
        SceneManager.LoadScene("Atomo");
    }

    public void TablaPScene() 
    {
        SceneManager.LoadScene("TablaP");
    }
    public void CompsScene() 
    {
        SceneManager.LoadScene("Comps");
    }

    public void CerrarApp()
    {
        Application.Quit();
    }

}
