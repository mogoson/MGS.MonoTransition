/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.MonoTransition
{
    [Serializable]
    public struct TransitionState<T>
    {
        public T normal;
        public T hover;
        public T hold;
        public T select;
    }

    public abstract class MonoTransition : MonoBehaviour, IMonoTransition
    {
        public abstract void Transit(Transition transition);
    }

    public abstract class MonoTransition<T, S> : MonoTransition
    {
        public T target;
        public TransitionState<S> state;

        protected virtual void Reset()
        {
            target = GetComponent<T>();
        }

        public override void Transit(Transition transition)
        {
            var state = ResolveState(transition);
            OnTransit(target, state);
        }

        protected virtual S ResolveState(Transition transition)
        {
            return transition switch
            {
                Transition.Hover => state.hover,
                Transition.Hold => state.hold,
                Transition.Select => state.select,
                _ => state.normal
            };
        }

        protected abstract void OnTransit(T target, S state);
    }
}