// Copyright (c) 2018 Southrop. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

using DG.Tweening;
using UniRx;

public static class DOTweenRxExtensions
{
    public static IObservable<Unit> OnCompleteAsObservable(this Sequence sequence)
    {
        return Observable.Create<Unit>(observer =>
        {
            sequence.OnComplete(() =>
            {
                observer.OnNext(Unit.Default);
                observer.OnCompleted();
            });

            return Disposable.Create(() => { });
        });
    }
}
