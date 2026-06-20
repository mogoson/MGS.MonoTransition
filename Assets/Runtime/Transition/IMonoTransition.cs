/*************************************************************************
 *  Copyright © 2026 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMonoTransition.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  01/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.MonoTransition
{
    public enum Transition
    {
        Normal,
        Hover,
        Hold,
        Select
    }

    public interface IMonoTransition
    {
        void Transit(Transition state);
    }
}