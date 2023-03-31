using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjesControl : MonoBehaviour
{
    [Header("Objetos Ejes X/Y/Z")]
    [SerializeField] GameObject ejeX;
    [SerializeField] GameObject ejeY;
    [Header("Botones Ejes Individuales")]
    [SerializeField] GameObject activarEjeX;
    [SerializeField] GameObject desactivarEjeX;
    [SerializeField] GameObject activarEjeY;
    [SerializeField] GameObject desactivarEjeY;
    [Header("Botones Ejes Globales")]
    [SerializeField] GameObject activarEjes;
    [SerializeField] GameObject desactivarEjes;
    
    public void OcultarEjes(){
        activarEjeX.SetActive(false);
        activarEjeY.SetActive(false);
        desactivarEjeX.SetActive(false);
        desactivarEjeY.SetActive(false);
        ejeX.SetActive(false);
        ejeY.SetActive(false);
        desactivarEjes.SetActive(false);
        activarEjes.SetActive(true);
    }
    
    void Start()
    {
        OcultarEjes();
        desactivarEjes.SetActive(false);
        desactivarEjeX.SetActive(false);
        desactivarEjeY.SetActive(false);
    }

    public void MostrarEjes(){
        activarEjeX.SetActive(true);
        activarEjeY.SetActive(true);
        activarEjes.SetActive(false);
        desactivarEjes.SetActive(true);
    }

    public void MostrarEjeX(){
        ejeX.SetActive(true);
        activarEjeX.SetActive(false);
        desactivarEjeX.SetActive(true);
    }

    public void MostrarEjeY(){
        ejeY.SetActive(true);
        activarEjeY.SetActive(false);
        desactivarEjeY.SetActive(true);
    }

    public void OcultarEjeX(){
        ejeX.SetActive(false);
        activarEjeX.SetActive(true);    
        desactivarEjeX.SetActive(false);  
    }

    public void OcultarEjeY(){
        ejeY.SetActive(false);
        activarEjeY.SetActive(true);
        desactivarEjeY.SetActive(false);
    }
}
