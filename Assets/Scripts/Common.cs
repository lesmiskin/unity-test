using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MqCommon
{
    public const double RADIAN_CIRCLE = 6.28;

    public static float cosInc(float offset, ref float cosInc, float speed, float magnitude) {
        cosInc = cosInc >= RADIAN_CIRCLE ? 0 : cosInc + speed;

        float cosOffset = (Mathf.Cos(cosInc) * magnitude);
        return offset - cosOffset;
    }

    public static float sineInc(float offset, ref float sineInc, float speed, float magnitude) {
        sineInc = sineInc >= RADIAN_CIRCLE ? 0 : sineInc + speed;

        float sineOffset = (Mathf.Sin(sineInc) * magnitude);
        return offset - sineOffset;
    }
}
