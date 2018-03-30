using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace BurgerThing.UtilityNamespace
{
    public static class Ext
    {
        public static void Each<T>(this IEnumerable els, Action<T, int> a)
        {
            int i = 0;
            foreach (T e in els)
            {
                a(e, i++);
            }
        }
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        MemberInfo[] memInfo = type.GetMember(type.GetEnumName(val));
                        DescriptionAttribute descriptionAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() as DescriptionAttribute;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }

            return null; // could also return string.Empty
        }
    }
    public class Util
    {
        private static readonly Random Random = new Random();
        public static void RepeatAction(int repeatCount, Action action)
        {
            for (int i = 0; i < repeatCount; i++)
                action();
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        public static bool HasDuplicates<T>(List<T> myList)
        {
            HashSet<T> hs = new HashSet<T>();
            return myList.Any(t => !hs.Add(t));
        }
        public static Dictionary<TKey, TValue> Merge<TKey, TValue>(IEnumerable<TKey> keys, IEnumerable<TValue> values)
        {
            Dictionary<TKey, TValue> dic = new Dictionary<TKey, TValue>();
            keys.Each<TKey>((x, i) =>
            {
                dic.Add(x, values.ElementAt(i));
            });
            return dic;
        }

        public static void Wo(string s)
        {
            Console.WriteLine(s);
        }
    }
}