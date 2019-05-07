﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player.GUI
{
    interface IResetable
    {
        /// <summary>
        /// Rolls back all fields to initial state
        /// </summary>
        void Reset();
    }
}
