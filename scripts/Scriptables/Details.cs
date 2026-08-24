using UnityEngine;

[CreateAssetMenu(fileName = "Details", menuName = "Scriptable Objects/Details")]
public class Details : ScriptableObject
{
    public int[] person;
    public string[] personNames;
    public bool[] found;
    public int day;
    
}
