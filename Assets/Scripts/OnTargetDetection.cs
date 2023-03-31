using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTargetDetection : MonoBehaviour
{

    [Header("Objetos emergentes")]
    [SerializeField] GameObject Arandelas;
    [SerializeField] GameObject Planos;
    [SerializeField] GameObject Ejes;
    [SerializeField] GameObject Malla;

    public void Gotcha(){
        Arandelas.SetActive(true);
        Planos.SetActive(true);
        Ejes.SetActive(true);
        Malla.SetActive(true);
    }

    public void OhShit(){
        Arandelas.SetActive(false);
        Planos.SetActive(false);
        Ejes.SetActive(false);
        Malla.SetActive(false);
    }
}
