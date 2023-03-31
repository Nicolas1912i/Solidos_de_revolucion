using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentationController : MonoBehaviour
{

    [SerializeField] Sprite[] documents;
    public int n;

    void Update()
    {
        this.GetComponent<Image>().sprite = documents[n];
    }

    public void NTOM(int m)
    {
        n = m;
    }
}