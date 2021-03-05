using UnityEngine;

[CreateAssetMenu(fileName = "New Movement Curve", menuName = "MovementCurve")]
public class MovementCurve : ScriptableObject
{
    public string name = "New Movement Curve";
    public float timeScale = 1;
    public AnimationCurve Curve = null;

    public float Evaluate(float t)
    {
        return Curve.Evaluate(t) * timeScale;
    }
}
