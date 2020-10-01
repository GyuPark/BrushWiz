using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateReflection
{
    /// <summary>
    /// 직선의 방정식 y = ax+b의 기울기 a와 y축 접점 b를 반환한다. 
    /// </summary>
    /// <param name="yRot">y축 회전값(localEulerAngle.y)</param>
    /// <param name="x">x축 포지션(position.x)</param>
    /// <param name="z">z축 포지션(position.z)</param>
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
    /// <param name="gradient">직선의 방정식 y = ax+b의 기울기 a</param>
    /// <param name="constant">직선의 방정식 y = ax+b의 접점 b</param>
    /// <param name="x">대칭하고자 하는 위치의 position.x</param>
    /// <param name="y">대칭하고자 하는 위치의 position.y</param>
    /// <param name="z">대칭하고자 하는 위치의 position.z</param>
    /// <returns></returns>
    public static Vector3 GetReflection(float gradient, float constant, float x, float y, float z)
    {
        float newX = ((1 - Mathf.Pow(gradient, 2)) * x + 2 * gradient * z - 2 * gradient * constant) / ((Mathf.Pow(gradient,2) + 1));
        float newZ = ((Mathf.Pow(gradient, 2) - 1) * z + 2 * gradient * x + 2 * constant) / ((Mathf.Pow(gradient,2) + 1));
        Vector3 reflection = new Vector3(newX, y, newZ);
        return reflection;
    }
}
