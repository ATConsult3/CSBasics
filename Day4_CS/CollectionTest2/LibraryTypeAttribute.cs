using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning.cs2022.library
{
    public enum LibraryType { 
    Univercity,
    School,
    Home,
    Private,
    Gov
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class LibraryTypeAttribute : Attribute
    {
        private LibraryType _libraryType = LibraryType.School;
        public LibraryTypeAttribute(LibraryType type)
        {
            _libraryType = type;
        }
        public LibraryType LibraryType { get { return _libraryType; } }


        public LibraryTypeAttribute() { } 


    }
}
