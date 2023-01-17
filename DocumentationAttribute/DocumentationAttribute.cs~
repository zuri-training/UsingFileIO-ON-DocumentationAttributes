using System;
namespace Documentation
{
    public class DocumentationAttribute
    {
        [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        public class DocumentAttribute : Attribute
        {
            public string Description { get; }
            public string Input { get; }
            public string Output { get; }

            public DocumentAttribute(string description)
            {
                Description = description;
                Input = "";
                Output = "";
            }
            public DocumentAttribute(string description, string input , string output )
            {
                Description = description;
                Input = input;
                Output = output;
            }
        }
    }
}

