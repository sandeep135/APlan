﻿

namespace aplan.database
{

    /// <summary>
    /// Class <c>Height</c> models a height for internal used within the project.
    /// This is modeled based on the needs of keeping imported information,
    /// which later will be used for calculation and mapping.
    /// </summary>
    class Height
    {
        /// <value>
        /// Property <c>Id</c> represents the internal id used in database.
        /// </value>
        public int Id { get; set; }

        /// <value>
        /// Property <c>name</c> represents the internal name used in database.
        /// </value>
        public string name { get; set; }

        /// <value>
        /// Property <c>pad</c> represents the pad of respective object from import data.
        /// This property is found normally in mdb format.
        /// </value>
        public string pad { get; set; }

        /// <value>
        /// Property <c>height</c> represents height value.
        /// </value>
        public double height { get; set; }
    }
}
