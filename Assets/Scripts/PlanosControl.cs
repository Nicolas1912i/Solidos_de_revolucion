using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanosControl : MonoBehaviour
{
    [Header("Objetos Planos X/Y")]
    [SerializeField] GameObject planoX;
    [Header("Botones Planos Individuales")]
    [SerializeField] GameObject activarPlanoX;
    [SerializeField] GameObject desactivarPlanoX;
    [Header("Botones Planos Globales")]
    [SerializeField] GameObject activarPlanos;
    [SerializeField] GameObject desactivarPlanos;
    
    public void OcultarPlanos(){
        activarPlanoX.SetActive(false);
        desactivarPlanoX.SetActive(false);
        planoX.SetActive(false);
        desactivarPlanos.SetActive(false);
        activarPlanos.SetActive(true);
    }
    
    void Start()
    {
        OcultarPlanos();
        desactivarPlanos.SetActive(false);
        desactivarPlanoX.SetActive(false);
    }

    public void MostrarPlanos(){
        activarPlanoX.SetActive(true);
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
}
