/*
* Copyright (c) 2011 Erin Catto http://box2d.org
*
* This software is provided 'as-is', without any express or implied
* warranty.  In no event will the authors be held liable for any damages
* arising from the use of this software.
* Permission is granted to anyone to use this software for any purpose,
* including commercial applications, and to alter it and redistribute it
* freely, subject to the following restrictions:
* 1. The origin of this software must not be misrepresented; you must not
* claim that you wrote the original software. If you use this software
* in a product, an acknowledgment in the product documentation would be
* appreciated but is not required.
* 2. Altered source versions must be plainly marked as such, and must not be
* misrepresented as being the original software.
* 3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Diagnostics;

namespace Box2D.Common
{
    public class b2Timer
    {
        private long m_tickStart = 0L;

        static float s_invFrequency = 0.0f;

        public b2Timer()
        {
            Reset();
        }

        public void Reset()
        {
            m_tickStart = DateTime.Now.Ticks;
        }

        public float GetMilliseconds()
        {
            return ((float)(new TimeSpan(DateTime.Now.Ticks - m_tickStart).TotalMilliseconds));
        }
    }
}
