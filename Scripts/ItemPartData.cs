using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemPartData")]
public class ItemPartData : ScriptableObject
{
    [Header("General")]
    public float weight;
    public float value;
    public List<RangedPartData> restrictedParts;
}