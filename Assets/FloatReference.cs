using System;

[System.Serializable]
public class FloatReference
{
    public bool useConstant = true;
    public float constantValue;
    public FloatVariable objectVariable;

    public float Value
    {
        get { return useConstant ? constantValue : objectVariable.Value; }
    }
}
