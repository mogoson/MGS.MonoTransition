/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AnimatorTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/21/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.MonoTransition
{
    public class AnimatorTransition : MonoTransition<Animator, string>
    {
        protected override void Reset()
        {
            base.Reset();
            state.normal = "Normal";
            state.hover = "Hover";
            state.hold = "Press";
            state.select = "Select";
        }

        protected override void OnTransit(Animator target, string state)
        {
            target.Play(state);
        }
    }
}