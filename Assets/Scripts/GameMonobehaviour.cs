using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMonobehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Start()
    {
        //For override
    }

    protected virtual void LoadComponents()
    {
        //For override
    }
}
