using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _bindings = new Dictionary<Type, Type>();

        /// <summary>
        /// Binds an interface type to an implementation type.
        /// </summary>
        /// <param name="interfaceType">The interface type to bind.</param>
        /// <param name="implementationType">The implementation type to bind to the interface.</param>
        public void Bind(Type interfaceType, Type implementationType)
        {
            _bindings[interfaceType] = implementationType;
        }

        /// <summary>
        /// Resolves an instance of the specified type from the container.
        /// </summary>
        /// <typeparam name="T">The type to resolve.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        /// <exception cref="InvalidOperationException">Thrown when no binding is found for the specified type.</exception>
        public T Get<T>()
        {
            var interfaceType = typeof(T);
            if (_bindings.TryGetValue(interfaceType, out var implementationType))
            {
                return (T)Activator.CreateInstance(implementationType);
            }
            throw new InvalidOperationException($"No binding found for {interfaceType.FullName}");
        }
    }
}
