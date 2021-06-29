using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Events : MonoBehaviour
{
    public Transform scalarPanel;
    public RectTransform contentTransform;
    public float timeAnimation;

    
    public void OnMouseDown()
    {
        scalarPanel.DOScale(0.0055f,timeAnimation);
        contentTransform.localPosition = new Vector2 (0,0); 
    
    }

    public void QuitarInfo() 
    {   
        scalarPanel.DOScale(0f,timeAnimation);
    }
}


    
