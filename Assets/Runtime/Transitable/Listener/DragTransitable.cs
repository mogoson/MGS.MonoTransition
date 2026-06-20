/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  DragTransitable.cs
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
    public class DragTransitable : ListenerTransitable<IMonoDragListener>
    {
        protected override void RegisterEvent(IMonoDragListener listener)
        {
            listener.OnBeginDragEvent += OnBeginDrag;
            listener.OnDragEvent += OnDrag;
            listener.OnEndDragEvent += OnEndDrag;
        }

        protected override void UnregisterEvent(IMonoDragListener listener)
        {
            listener.OnBeginDragEvent -= OnBeginDrag;
            listener.OnDragEvent -= OnDrag;
            listener.OnEndDragEvent -= OnEndDrag;
        }

        protected virtual void OnBeginDrag(Vector3 pos)
        {
            Transit(Transition.Hold);
        }

        protected virtual void OnDrag(Vector3 pos) { }

        protected virtual void OnEndDrag(Vector3 pos)
        {
            Transit(Transition.Normal);
        }
    }
}