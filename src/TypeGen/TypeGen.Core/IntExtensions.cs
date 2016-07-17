﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeGen.Core
{
    internal static class IntExtensions
    {
        /// <summary>
        /// Invokes an action for every integer from 0 to "integer"-1
        /// </summary>
        /// <param name="integer"></param>
        /// <param name="action"></param>
        public static void Times(this int integer, Action<int> action)
        {
            for (var i = 0; i < integer; i++)
            {
                action.Invoke(i);
            }
        }
    }
}
