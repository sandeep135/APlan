﻿using APLan.Model.aplan.Database;
using System.Collections.Generic;


namespace aplan.database
{

    /// <summary>
    /// Enum <c>horizontalAlignmentType</c> defines horizontal alignment types available.
    /// This enum is used to standardize the property when the algorithm calls the type.
    /// </summary>
    enum horizontalAlignmentType
    {
        Line,
        Arc,
        Clothoid,
        Bloss_curve = 4
    }

    /// <summary>
    /// Class <c>HorizontalAlignment</c> models a horizontal alignment for internal used within the project.
    /// This is modeled based on the needs of keeping imported information,
    /// which later will be used for calculation and mapping.
    /// </summary>
    class HorizontalAlignment : BaseElement
    {
        /// <value>
        /// Property <c>Id</c> represents the internal id used in database.
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Property <c>id</c> represents the id of the object.
        /// </value>
        public string id { get; set; }

        /// <value>
        /// Property <c>startPad</c> represents the start pad of respective object from import data.
        /// This property is used to help identifying exact geo coordinate and matching with other properties.
        /// </value>
        public string startPad { get; set; }

        /// <value>
        /// Property <c>endPad</c> represents the end pad of respective object from import data.
        /// This property is used to help identifying exact geo coordinate and matching with other properties.
        /// </value>
        public string endPad { get; set; }

        /// <value>
        /// Property <c>codeDirection</c> represents the direction of the object.
        /// Whether is it normal, reverse, or both.
        /// </value>
        public int codeDirection { get; set; }

        /// <value>
        /// Property <c>alignmentTypeCode</c> represents the type of the object in code.
        /// </value>
        public int alignmentTypeCode { get; set; }

        /// <value>
        /// Property <c>alignmentTypeText</c> represents the type of the object in text.
        /// </value>
        public horizontalAlignmentType alignmentTypeText { get; set; }

        /// <value>
        /// Property <c>length</c> represents the length of the object.
        /// </value>
        public double length { get; set; }

        /// <value>
        /// Property <c>initialRadius</c> represents the initial radius of the object.
        /// </value>
        public double initialRadius { get; set; }

        /// <value>
        /// Property <c>endRadius</c> represents the end radius of the object.
        /// </value>
        public double endRadius { get; set; }

        /// <value>
        /// Property <c>initialAzimuth</c> represents the initial azimuth of the object.
        /// </value>
        public double initialAzimuth { get; set; }

        /// <value>
        /// Property <c>endAzimuth</c> represents the end azimuth of the object.
        /// </value>
        public double endAzimuth { get; set; }

        /// <value>
        /// Property <c>startKm</c> represents the start kilometer of the object.
        /// </value>
        public double? startKM { get; set; }

        /// <value>
        /// Property <c>endKm</c> represents the end kilometer of the object.
        /// </value>
        public double? endKM { get; set; }

        /// <value>
        /// Property <c>unit</c> represents the unit which value of start and end km properties are using.
        /// This property helps some algorithm to find the group of objects.
        /// Particulary used for mdb format
        /// </value>
        public string unit { get; set; }

        /// <value>
        /// Property <c>geometryType</c> represents the geometry type of the object.
        /// This property is found particularly in json format.
        /// </value>
        public string geometryType { get; set; }

        /// <value>
        /// Property <c>lineCoordinates</c> represents the geo coordinates of the object.
        /// </value>
        public List<CartesianCoordinate> lineCoordinates { get; set; }

    }
}
