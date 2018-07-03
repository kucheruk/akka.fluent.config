using System;
using System.Collections.Generic;
using System.Linq;

namespace Akka.Fluent.Config
{
    public class HoconConfigBuilder : HoconSection
    {
        private readonly Dictionary<string, HoconSection> _childs = new Dictionary<string, HoconSection>();


        protected HoconConfigBuilder(string name) : base(name)
        {
        }


        protected void AddKeyValue(string name, string value)
        {
            _childs.Add(name, new HoconKeyStringValue(name, value));
        }

        protected void AddKeyValue(string name, bool value)
        {
            _childs.Add(name, new HoconKeyStringValue(name, value ? "on" : "off"));
        }

        protected void AddKeyValue(string name, string[] value)
        {
            _childs.Add(name, new HoconKeyListValue(name, value));
        }

        protected T SectionBuilder<T>(string name, Action<T> builder) where T : HoconSection, new()
        {
            var b = GetOrAdd(name, () => new T());
            builder(b);
            return b;
        }

        protected T GetOrAdd<T>(string name, Func<T> factory) where T : HoconSection
        {
            if (_childs.ContainsKey(name))
            {
                return _childs[name] as T;
            }

            var ret = factory();
            _childs.Add(name, ret);
            return ret;
        }


        public override string ToConfig()
        {
            return $"{Name} {{ {string.Join("\n", _childs.Values.Select(s => s.ToConfig()))} }}";
        }
    }
}