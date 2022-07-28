using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    public static MonoBehaviour Self = null;

    // Use this for initialization
    private void Awake()
    {
        if (Self == null)
        {
            Self = this;
        }
        else
        {
            throw new Exception("UnityBehaviour assigned elsewhere. Are there two CoroutineBehaviour in the scene?");
        }
    }
}
