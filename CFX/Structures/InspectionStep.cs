﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures
{
    /// <summary>
    /// <para>** NOTE: ADDED in CFX 1.3 **</para>
    /// An inspection step is one step of an inspection. Each inspection step is associated with a measurements result.
    /// </summary>
    [CFX.Utilities.CreatedVersion("1.3")]
    public class InspectionStep
    {
        /// <summary>
        /// Optional: name of the inspection step
        /// E.g.: This could be the name of the algorithm to be  applied to perform the inspection step
        /// </summary>
        public  string Name { get; set; }
        /// <summary>
        /// Uniquely identifies the Inspection step for this Inspection Object
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// the target values for the related measurement
        /// In case of a SPI the InspectionMeasurementTarget would be used to provide the expected values
        /// </summary>
        public Measurement TargetValue { get; set; }
    }
}
