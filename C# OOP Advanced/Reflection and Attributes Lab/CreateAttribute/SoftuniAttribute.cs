
using System;
namespace SoftUniAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method ,AllowMultiple = true)]
    class SoftAttribute : Attribute
    {
        public SoftAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
