using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinMonoBehaviour : MonoBehaviour
{
    protected virtual void Start()
    {
        LoadCompoment();
    }
    protected virtual void Reset()
    {
        LoadCompoment();
    }
    protected virtual void LoadCompoment() { }
}
