using UnityEngine;

public class CubeColor : MonoBehaviour
{

    private Color GetRandomColor()
    {
        return new Color(GetRandomFloatValue(), GetRandomFloatValue(), GetRandomFloatValue());
    }

    private float GetRandomFloatValue(float min = 0.0f, float max = 1.0f)
    {
        return Random.Range(min, max);
    }

    // Use this for initialization
    void Start()
    {
        var newColor = GetRandomColor();
        this.GetComponent<Renderer>().material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
