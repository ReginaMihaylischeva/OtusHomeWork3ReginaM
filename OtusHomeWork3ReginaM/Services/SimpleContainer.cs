using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OtusHomeWork3ReginaM.Services
{
    static class SimpleContainer
    {
		readonly static Dictionary<Type, Func<object>> registeredCreators = new Dictionary<Type, Func<object>>();

		public static void Register<TAbstraction, TImpl>()
			where TImpl : new()
		{
			registeredCreators.Add(typeof(TAbstraction), () => new TImpl());
		}	

		public static T Create<T>()
		{
			return (T)Create(typeof(T));
		}

		public static object Create(Type type)
		{
			TypeInfo typeInfo = type.GetTypeInfo();

			Func<object> creator;
			if (registeredCreators.TryGetValue(type, out creator))
				return registeredCreators[type]();

			var ctors = typeInfo.DeclaredConstructors.Where(c => c.IsPublic).ToArray();
			var ctor = ctors.FirstOrDefault(c => c.GetParameters().Length == 0);
			if (ctor != null)
				return Activator.CreateInstance(type);

			ctor = ctors[0];
			List<object> parameters = new List<object>();
			foreach (var p in ctor.GetParameters())
				parameters.Add(Create(p.ParameterType));

			return Activator.CreateInstance(type, parameters.ToArray());
		}
	}
}
