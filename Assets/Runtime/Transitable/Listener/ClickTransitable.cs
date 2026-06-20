/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ClickTransitable.cs
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
    public class ClickTransitable : ListenerTransitable<IMonoClickListener>
    {
        protected override void RegisterEvent(IMonoClickListener listener)
        {
            listener.OnDownEvent += OnDown;
            listener.OnClickEvent += OnClick;
            listener.OnUpEvent += OnUp;
        }

        protected override void UnregisterEvent(IMonoClickListener listener)
        {
            listener.OnDownEvent -= OnDown;
            listener.OnClickEvent -= OnClick;
            listener.OnUpEvent -= OnUp;
        }

        protected virtual void OnDown(Vector3 pos)
        {
            Transit(Transition.Hold);
        }

        protected virtual void OnClick(Vector3 pos) { }

        protected virtual void OnUp(Vector3 pos)
        {
            Transit(Transition.Normal);
        }
    }
}