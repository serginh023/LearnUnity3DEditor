
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int level;
    [SerializeField] private int experience;
    [SerializeField] private int xpToLevelUp;
    
    public int GetLevel
    {
        get => experience / xpToLevelUp;
    }
}
