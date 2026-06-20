/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  HoverTransitable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using MGS.MonoListener;
using UnityEngine;

namespace MGS.MonoTransition
{
    public class HoverTransitable : ListenerTransitable<IMonoHoverListener>
    {
        protected override void RegisterEvent(IMonoHoverListener listener)
        {
            listener.OnEnterEvent += OnEnter;
            listener.OnMoveEvent += OnMove;
            listener.OnExitEvent += OnExit;
        }

        protected override void UnregisterEvent(IMonoHoverListener listener)
        {
            listener.OnEnterEvent -= OnEnter;
            listener.OnMoveEvent -= OnMove;
            listener.OnExitEvent -= OnExit;
        }

        protected virtual void OnEnter(Vector3 pos)
        {
            Transit(Transition.Hold);
        }

        protected virtual void OnMove(Vector3 pos) { }

        protected virtual void OnExit(Vector3 pos)
        {
            Transit(Transition.Normal);
        }
    }
}