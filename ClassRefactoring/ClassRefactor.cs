using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        /// <summary>
        /// Creates and returns a Swallow object based on the specified SwallowType.
        /// </summary>
        /// <param name="swallowType">The type of swallow (African or European).</param>
        /// <returns>A Swallow object of the specified type.</returns>
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Swallow class.
        /// </summary>
        /// <param name="swallowType">The type of swallow (African or European).</param>
        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
            Load = SwallowLoad.None;
        }

        /// <summary>
        /// Adds a load to the swallow, such as a coconut.
        /// </summary>
        /// <param name="load">The load to add to the swallow.</param>
        public void AddLoad(SwallowLoad load)
        {
            Load = load;
        }

        /// <summary>
        /// Gets the airspeed velocity of the swallow, adjusted for type and load.
        /// </summary>
        /// <returns>The airspeed velocity of the swallow.</returns>
        public int GetAirspeedVelocity()
        {
            if (Load == SwallowLoad.Coconut)
            {
                return Type == SwallowType.African ? 14 : 10;
            }

            return Type == SwallowType.African ? 22 : 20;
        }
    }
}
