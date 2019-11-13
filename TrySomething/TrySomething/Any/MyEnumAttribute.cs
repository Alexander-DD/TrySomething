using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TrySomething.Any
{
	public class MyEnumAttribute : Starter
	{
		public override void Start()
		{
			var enumList = new List<InputColumnName>()
			{
				InputColumnName.Address,
				InputColumnName.Name,
				InputColumnName.NameInDevice,
				InputColumnName.Units,
				InputColumnName.IsSigned,
				InputColumnName.IsDual
			};

			enumList.ForEach(curEnum => Console.WriteLine(curEnum.GetName()));
		}
	}

	public enum InputColumnName
	{
		[Description("Адрес")]
		Address,
		[Description("Имя")]
		Name,
		[Description("Название в приборе")]
		NameInDevice,
		[Description("Единицы измерения")]
		Units,
		[Description("Signed")]
		IsSigned,
		[Description("Dual")]
		IsDual,
	}

	public static class EnumExtensions
	{
		private static T GetAttribute<T>(this Enum value) where T : Attribute
		{
			var type = value.GetType();
			var memberInfo = type.GetMember(value.ToString());
			var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
			return (T)attributes[0];
		}

		public static string GetName(this Enum value)
		{
			DescriptionAttribute attribute = value.GetAttribute<DescriptionAttribute>();
			return attribute == null ? value.ToString() : attribute.Description;
		}
	}
}
