using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    //TODO: next time
    protected override bool CanDeSpawn()
    {
        return false;
    }
}
