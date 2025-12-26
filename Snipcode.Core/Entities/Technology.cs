using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.Core.Entities
{
    public enum Technology
    {
        CSharp = 0,
        Python = 1,
        JavaScript = 2,
        TypeScript = 3,
        Java = 4,
        CPlusPlus = 5,
        SQL = 6,
        HTML = 7,
        Css = 8,

        WPF = 20,      // Синтаксис -> XML/XAML?
        React = 21,    // Синтаксис -> JavaScript/JSX
        Angular = 22,  // Синтаксис -> TypeScript
        Blazor = 23,   // Синтаксис -> HTML (Razor) або C#
        ASP_NET = 24,  // Синтаксис -> C#
        Vue = 25       // Синтаксис -> JavaScript
    }
}
