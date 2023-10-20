using System;
using System.Reflection;

namespace _5112_Assign_2_Hanze_Liu.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}