using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anahuacteacher : GameMonoBehaviour
{
    private void Start()
    {
        AddEventListener<WinAnahuacRaffleEvent>(WinRaffle);


    }
    public WinRaffle (WinAnahuacRaffleEvent _event)
    {
        Debug.Log("GAME UNA RIFA WAOS");

    }

}
