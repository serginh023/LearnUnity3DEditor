using UnityEngine;

public class NameBehaviour : MonoBehaviour
{
    [ContextMenuItem("Randomize Name", "Randomize")]
    public string Name;
    [ContextMenuItem("Randomize cpf", "RandomizeCpf")]
    public string CPF;

    private void Randomize()
    {
        Name = "Some Random Name";
    }    
    
    private void RandomizeCpf()
    {
        CPF = "Some Random CPF";
    }
}