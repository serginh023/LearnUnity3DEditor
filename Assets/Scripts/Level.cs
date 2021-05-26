using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int xpForEachLevel;
    private int level;
    public int experience;

    public int GetLevel
    {
        get => experience / xpForEachLevel;
    }

    public void ObjectScream()
    {
        Debug.Log("Ahhhhhhhhh");
    }
}
