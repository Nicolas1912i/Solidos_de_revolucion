using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planos3DControl : MonoBehaviour
{
    [Header("Objetos Planos X/Y")]
    [SerializeField] GameObject planoX;
    [SerializeField] GameObject planoY;
    [Header("Botones Planos Individuales")]
    [SerializeField] GameObject activarPlanoX;
    [SerializeField] GameObject desactivarPlanoX;
    [SerializeField] GameObject activarPlanoY;
    [SerializeField] GameObject desactivarPlanoY;
    [Header("Botones Planos Globales")]
    [SerializeField] GameObject activarPlanos;
    [SerializeField] GameObject desactivarPlanos;
    
    public void OcultarPlanos(){
        activarPlanoX.SetActive(false);
        desactivarPlanoX.SetActive(false);
        planoX.SetActive(false);
        activarPlanoY.SetActive(false);
        desactivarPlanoY.SetActive(false);
        planoY.SetActive(false);
        desactivarPlanos.SetActive(false);
        activarPlanos.SetActive(true);
    }
    
    void Start()
    {
        OcultarPlanos();
        desactivarPlanos.SetActive(false);
        desactivarPlanoX.SetActive(false);
        desactivarPlanoY.SetActive(false);
    }

    public void MostrarPlanos(){
        activarPlanoX.SetActive(true);
        activarPlanoY.SetActive(true);
        activarPlanos.SetActive(false);
        desactivarPlanos.SetActive(true);
    }

    public void MostrarPlanoX(){
        planoX.SetActive(true);
        activarPlanoX.SetActive(false);
        desactivarPlanoX.SetActive(true);
    }

    public void OcultarPlanoX(){
        planoX.SetActive(false);
        activarPlanoX.SetActive(true);    
        desactivarPlanoX.SetActive(false);  
    }

    public void MostrarPlanoY(){
        planoY.SetActive(true);
        activarPlanoY.SetActive(false);
        desactivarPlanoY.SetActive(true);
    }

    public void OcultarPlanoY(){
        planoY.SetActive(false);
        activarPlanoY.SetActive(true);    
        desactivarPlanoY.SetActive(false);  
    }
}