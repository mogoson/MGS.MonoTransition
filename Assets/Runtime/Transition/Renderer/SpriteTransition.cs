/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SpriteTransition.cs
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
    public class SpriteTransition : MonoTransition<SpriteRenderer, Sprite>
    {
        protected override void OnTransit(SpriteRenderer target, Sprite state)
        {
            target.sprite = state;
        }
    }
}