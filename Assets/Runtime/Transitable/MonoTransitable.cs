/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoTransitable.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections.Generic;
using UnityEngine;

namespace MGS.MonoTransition
{
    public abstract class MonoTransitable : MonoBehaviour, IMonoTransitable
    {
        public abstract bool Interactable { get; set; }
        protected IEnumerable<IMonoTransition> transitions;

        protected virtual void Awake()
        {
            transitions = GetComponentsInChildren<IMonoTransition>(true);
        }

        public virtual void Transit(Transition state)
        {
            foreach (var transition in transitions)
            {
                transition.Transit(state);
            }
        }
    }
}