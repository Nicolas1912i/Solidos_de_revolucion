using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentPortrait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
