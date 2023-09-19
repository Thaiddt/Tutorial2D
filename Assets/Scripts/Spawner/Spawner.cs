using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : GameMonobehaviour
{
    private static Spawner instance;

    [SerializeField] protected List<Transform> prefabs;

    public static Spawner Instance { get =>  instance; }

    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPrefabs();
    }

    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;

        Transform prefabObj = transform.Find("Prefabs");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }

        this.HidePrefabs();

        Debug.Log(transform.name + " : LoadPrefabs", gameObject);
    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    public virtual Transform Spawn(Vector3 spawnPos, Quaternion rotation)
    {
        Transform prefab = this.prefabs[0];
        Transform newPrefab = Instantiate(prefab, spawnPos, rotation);
        return newPrefab;
    }


}
