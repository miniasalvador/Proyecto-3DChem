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

    public void TP1() 
    {
        SceneManager.LoadScene("TP1");
    } 

     public void TP2() 
    {
        SceneManager.LoadScene("TP2");
    } 

    public void CompsScene() 
    {
        SceneManager.LoadScene("Compuestos");
    }

    public void CerrarApp()
    {
        Application.Quit();
    }

}
