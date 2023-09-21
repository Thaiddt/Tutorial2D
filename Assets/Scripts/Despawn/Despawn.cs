using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : GameMonobehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    protected virtual void Despawning()
    {
        if(!this.CanDeSpawn()) return;
        this.DespawnObject();
    }

    protected virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }
    protected abstract bool CanDeSpawn();
    
}
