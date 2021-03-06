using System;
using System.ComponentModel;

namespace Estimatorx.Core
{
    /// <summary>
    /// A matrix of hours based on the complexity of a task.
    /// </summary>
    public class Factor
    {
        public Factor()
        {
            VerySimple = 2;
            Simple = 4;
            Medium = 8;
            Complex = 16;
            VeryComplex = 32;
        }

        /// <summary>
        /// Gets or sets the identifier for the model.
        /// </summary>
        /// <value>
        /// The identifier for the model.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the factor.
        /// </summary>
        /// <value>
        /// The name of the factor.
        /// </value>
        public string Name { get; set; }
                
        /// <summary>
        /// Gets or sets the number of hours for a very simple tasks.
        /// </summary>
        /// <value>
        /// The number of hours for a very simple tasks.
        /// </value>
        [DefaultValue(0)]
        public byte VerySimple { get; set; }
        
        /// <summary>
        /// Gets or sets the number of hours for a simple tasks.
        /// </summary>
        /// <value>
        /// The number of hours for a simple tasks.
        /// </value>
        [DefaultValue(0)]
        public byte Simple { get; set; }
        
        /// <summary>
        /// Gets or sets the number of hours for a medium tasks.
        /// </summary>
        /// <value>
        /// The number of hours for a medium tasks.
        /// </value>
        [DefaultValue(0)]
        public byte Medium { get; set; }
        
        /// <summary>
        /// Gets or sets the number of hours for a complex tasks.
        /// </summary>
        /// <value>
        /// The number of hours for a complex tasks.
        /// </value>
        [DefaultValue(0)]
        public byte Complex { get; set; }
        
        /// <summary>
        /// Gets or sets the number of hours for a very complex tasks.
        /// </summary>
        /// <value>
        /// The number of hours for a very complex tasks.
        /// </value>
        [DefaultValue(0)]
        public byte VeryComplex { get; set; }
    }
}