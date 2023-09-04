using System.Resources;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResourceManager
{
    public IEnumerator<Object> GetResourceItemFromDir()
    {
        yield return Resources.Load<Object>("Resources/ScriptableObjects/New Profile Picture Data SO.asset");
    }
}
