using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arandelas3D : MonoBehaviour
{
    [SerializeField] GameObject _object;
    int i;
    [SerializeField] int max_Arandelas;

    [Header("Buttons")]
    [SerializeField] GameObject startArandelas;
    [SerializeField] GameObject stopArandelas;
    [SerializeField] GameObject plusButton;
    [SerializeField] GameObject lessButton;

    [Header("Materials")]
    [SerializeField] Material arandelaMaterial;

    [Header("Arandelas")]
    [SerializeField] GameObject[] arandelas;

    private void Start()
    {
        _object = GameObject.FindGameObjectWithTag("Object");
        stopArandelas.SetActive(false);
        plusButton.SetActive(false);
        lessButton.SetActive(false);
        
        foreach (GameObject gameObject in arandelas)
        {
            gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        ArandelasAddLess();
    }

    void ArandelasAddLess()
    {
        /*if (i == 0)
        {
            foreach (GameObject gameObject in arandelas)
            {
                gameObject.SetActive(false);
            }
            lessButton.SetActive(false);
        }
        if (i >= 1)
        {
            arandelas[0].SetActive(true);
            for (int i = 1; i < arandelas.Length; i++) arandelas[i].SetActive(false);
            lessButton.SetActive(true);
            plusButton.SetActive(false);
        }
        if (i < 1)
        {
            lessButton.SetActive(false);
            plusButton.SetActive(true);
        }*/
        switch (i)
        {
            case 0:
                foreach (GameObject gameObject in arandelas)
                {
                    gameObject.SetActive(false);
                }
                lessButton.SetActive(false);
                break;
            case 1:
                arandelas[0].SetActive(true);
                for (int i = 1; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                lessButton.SetActive(true);
                break;
            case 2:
                for (int i = 0; i < 2; i++) arandelas[i].SetActive(true);
                for (int i = 2; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 3:
                for (int i = 0; i < 3; i++) arandelas[i].SetActive(true);
                for (int i = 3; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 4:
                for (int i = 0; i < 4; i++) arandelas[i].SetActive(true);
                for (int i = 4; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 5:
                for (int i = 0; i < 5; i++) arandelas[i].SetActive(true);
                for (int i = 5; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 6:
                for (int i = 0; i < 6; i++) arandelas[i].SetActive(true);
                for (int i = 6; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 7:
                for (int i = 0; i < 7; i++) arandelas[i].SetActive(true);
                for (int i = 7; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 8:
                for (int i = 0; i < 8; i++) arandelas[i].SetActive(true);
                for (int i = 8; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 9:
                for (int i = 0; i < 9; i++) arandelas[i].SetActive(true);
                for (int i = 9; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                break;
            case 10:
                for (int i = 0; i < 10; i++) arandelas[i].SetActive(true);
                for (int i = 10; i < arandelas.Length; i++) arandelas[i].SetActive(false);
                plusButton.SetActive(false);
                break;               
        }
        if (i < 10) plusButton.SetActive(true);
    }

    public void InitializeArandelas()
    {
        stopArandelas.SetActive(true);
        startArandelas.SetActive(false);
        plusButton.SetActive(true);
        lessButton.SetActive(true);
    }

    public void StopArandelas()
    {
        stopArandelas.SetActive(false);
        startArandelas.SetActive(true);
        plusButton.SetActive(false);
        lessButton.SetActive(false);
    }

    public void InstantiateArandela()
    {
        i++;
    }

    public void DeleteArandela()
    {
        i--;
    }
}