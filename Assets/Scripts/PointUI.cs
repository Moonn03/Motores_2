using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointUI : MonoBehaviour
{
    //VARIABLES
    public TMP_Text ScoreText;

    void Update()
    {
        ScoreText.text = PointManager.instance.GetScore().ToString();
    }
    public void OnClick_AddPoints() 
    {
        //DESACTIVAR EL COLLIDER.
        //ACTIVAR SFX.
        //DESACTIVAR RENDER MESH.
        PointManager.instance.AddPoints(10);
    
    }
    public void Onclick_SubtractPoint() 
    {
        PointManager.instance.RemovePoints(5);    
    
    
    }
    public void Onclick_WinAnahuacEvent() 
    { 
        InvokeEvent<WinAnahuacRaffleEvent>(new WinAnahuacRaffleEvent());
    
    
    }
}
