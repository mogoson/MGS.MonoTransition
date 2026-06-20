/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ListenerTransitable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using MGS.MonoListener;

namespace MGS.MonoTransition
{
    public abstract class ListenerTransitable<T> : MonoTransitable where T : IMonoListener
    {
        public override bool Interactable
        {
            set { listener.Interactable = value; }
            get { return listener.Interactable; }
        }
        protected T listener;

        protected override void Awake()
        {
            base.Awake();
            listener = GetComponent<T>();
            RegisterEvent(listener);
        }

        protected virtual void OnDestroy()
        {
            UnregisterEvent(listener);
        }

        protected abstract void RegisterEvent(T listener);

        protected abstract void UnregisterEvent(T listener);
    }
}