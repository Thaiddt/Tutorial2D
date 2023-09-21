using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : GameMonobehaviour
{
    [SerializeField] protected float disLimit = 70f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Transform mainCamera;


    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.mainCamera != null) return;
        this.mainCamera = Transform.FindObjectOfType<Camera>().transform;
        Debug.Log(transform.parent.name + ": LoadCamera", gameObject);
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
    protected virtual bool CanDeSpawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCamera.position);
        if (this.distance >= disLimit) return true;
        return false;
    }
    
}
