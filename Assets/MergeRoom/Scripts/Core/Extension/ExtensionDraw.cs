using UnityEngine;

public static class ExtensionDraw
{
    public static void DrawCircle(this LineRenderer line, ref Vector3[] points, float radius, float lineWidth, float height = 0f)
    {
        line.useWorldSpace = false;
        line.startWidth = lineWidth;
        line.endWidth = lineWidth;
        line.positionCount = 361;

        var pointCount = 361;

        for (int i = 0; i < pointCount; i++)
        {
            var rad = Mathf.Deg2Rad * i;
            points[i] = new Vector3(Mathf.Sin(rad) * radius, height, Mathf.Cos(rad) * radius);
        }

        line.SetPositions(points);
    }
}