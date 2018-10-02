// Copyright (c) 2018 Southrop. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

using DG.Tweening;
using UnityEngine.UI;

public static class DOTweenExtensions
{
    public static Tweener DOTextInt(this Text text, int initialValue, int finalValue, float duration, Func<int, string> convertor)
    {
        return DOTween.To(() => initialValue, it => text.text = convertor(it), finalValue, duration);
    }

    public static Tweener DOTextInt(this Text text, int initialValue, int finalValue, float duration)
    {
        return DOTextInt(text, initialValue, finalValue, duration, it => it.ToString());
    }

    public static Tweener DOTextFloat(this Text text, float initialValue, float finalValue, float duration, Func<float, string> convertor)
    {
        return DOTween.To(() => initialValue, it => text.text = convertor(it), finalValue, duration);
    }

    public static Tweener DOTextFloat(this Text text, float initialValue, float finalValue, float duration)
    {
        return DOTextFloat(text, initialValue, finalValue, duration, it => it.ToString());
    }

    public static Tweener DOTextLong(this Text text, long initialValue, long finalValue, float duration, Func<long, string> convertor)
    {
        return DOTween.To(() => initialValue, it => text.text = convertor(it), finalValue, duration);
    }

    public static Tweener DOTextLong(this Text text, long initialValue, long finalValue, float duration)
    {
        return DOTextLong(text, initialValue, finalValue, duration, it => it.ToString());
    }

    public static Tweener DOTextDouble(this Text text, double initialValue, double finalValue, float duration, Func<double, string> convertor)
    {
        return DOTween.To(() => initialValue, it => text.text = convertor(it), finalValue, duration);
    }

    public static Tweener DOTextDouble(this Text text, double initialValue, double finalValue, float duration)
    {
        return DOTextDouble(text, initialValue, finalValue, duration, it => it.ToString());
    }
}
