using UnityEngine;
using System.Collections;

public class ToastStart : MonoBehaviour
{

    [SerializeField] private string prompt;
    [SerializeField] private float duration;

    void Start()
    {
        Toast.Instance.Show(prompt, duration);
    }

}
