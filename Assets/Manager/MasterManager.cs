using UnityEngine;

public class MasterManager : MonoBehaviour
{
    public DataManager dataManager;
    public UiManager uiManager;
    public KeyManager keyManager;
    static public MasterManager Instance;

    void Awake()
    {
        if(Instance != null)
        {
            Instance = this;
            uiManager = GetComponentInChildren<UiManager>();
            dataManager = GetComponentInChildren<DataManager>();
            keyManager = GetComponentInChildren<KeyManager>();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
