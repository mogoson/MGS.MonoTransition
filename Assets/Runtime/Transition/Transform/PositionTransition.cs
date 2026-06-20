/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PositionTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.MonoTransition
{
    public class PositionTransition : MonoTransition<Transform, Vector3>
    {
        protected override void OnTransit(Transform target, Vector3 state)
        {
            target.localPosition = state;
        }
    }
}