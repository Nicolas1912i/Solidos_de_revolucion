using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explation : MonoBehaviour
{

    [SerializeField] string prompt1;
    [SerializeField] string prompt2;
    [SerializeField] int time1;
    [SerializeField] int time2;
    
    void Start()
    {
        StartCoroutine(Messages());
    }

    IEnumerator Messages(){
        Toast.Instance.Show(prompt1, time1);
        yield return new WaitForSeconds(4f);
        Toast.Instance.Show(prompt2, time2);
    }
}
