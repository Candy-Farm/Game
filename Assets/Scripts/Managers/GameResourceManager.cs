using System.Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameResourceManager
{
    public IEnumerator GetSOFromDir(string dir, Action<PlayerDataSO> callback)
    {
        PlayerDataSO scriptable;
        yield return scriptable = Resources.Load<PlayerDataSO>(dir);
        Debug.Log(scriptable);
        callback(scriptable);
    }
}
