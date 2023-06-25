using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    GameObject LifeLine;
    public static UiHandler instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    public void updateLifeUi()
    {
        int index = LifeLine.transform.childCount - 1;
        Destroy(LifeLine.transform.GetChild(index).gameObject);
    }
}
