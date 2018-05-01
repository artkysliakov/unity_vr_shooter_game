using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotStopTheMusic : MonoBehaviour {

    private static DoNotStopTheMusic instance = null;
    public static DoNotStopTheMusic Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
