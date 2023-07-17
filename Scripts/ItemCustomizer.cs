using UnityEngine;

public class ItemCustomizer : MonoBehaviour
{
    public static ItemCustomizer Instance;

    private void Awake()
    {
        Instance = this;
    }

    public event Action OnPartChanged; 
}