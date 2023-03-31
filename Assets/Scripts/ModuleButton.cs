using UnityEngine;
using UnityEngine.UI;

public class ModuleButton : MonoBehaviour
{
    public int sceneIndex;
    LevelLoader levelLoader;

    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>();
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(CallLevelLoader);
    }

    private void Update()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }

    void CallLevelLoader()
    {
        levelLoader.LoadLevel(sceneIndex);
    }
}