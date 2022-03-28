﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.Depaneling
{
    public class Axis
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Axis()
        {

        }

        /// <summary>
        /// Name of the Axis 
        /// </summary>
        public string AxisName
        {
            get;
            set;
        }

        /// <summary>
        /// Max axis speed in mm/s
        /// </summary>
        public decimal AxisSpeed
        {
            get;
            set;
        }
        /// <summary>
        /// Set value in (mm/s2)
        /// /// <summary>
        public decimal AxisAcceleration
        {
            get;
            set;
        }
        /// <summary>
        /// Set value in (mm/s2)
        /// </summary>
        public decimal AxisDeceleration
        {
            get;
            set;
        }
        /// <summary>
        /// Operating at Maximum speed.
        /// </summary>
        public decimal ActualPeakVelocity
        {
            get;
            set;
        }
    }
}
