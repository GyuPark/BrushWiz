using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateReflection
{
    /// <summary>
    /// Returns the gradient(a) and the constant(b) of linear equation y = ax+b. 
    /// </summary>
    /// <param name="yRot"></param>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public static Vector2 GetLinearEquation(float yRot, float x, float z)
    {
        float angle = (90f - yRot) * Mathf.PI/180f; //angle은 radian이어야 한다
        float a = Mathf.Tan(angle); 
        float b = z - a * x;
        Vector2 equation = new Vector2(a, b);
        return equation;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gradient">the gradient(a) of linear equation y = ax+b</param>
    /// <param name="constant">the constant(b) of linear equation y = ax+b</param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public static Vector3 GetReflection(float gradient, float constant, float x, float y, float z)
    {
        float newX = ((1 - Mathf.Pow(gradient, 2)) * x + 2 * gradient * z - 2 * gradient * constant) / ((Mathf.Pow(gradient,2) + 1));
        float newZ = ((Mathf.Pow(gradient, 2) - 1) * z + 2 * gradient * x + 2 * constant) / ((Mathf.Pow(gradient,2) + 1));
        Vector3 reflection = new Vector3(newX, y, newZ);
        return reflection;
    }
}
