using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void updateValue(float num)
    {
        value += num;
    }
}