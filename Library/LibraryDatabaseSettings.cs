using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public interface ILibraryDatabaseSettings
    {
        string ConnectionString { get; set; }
        
        string DatabaseString { get; set; }
    }
    public class LibraryDatabaseSettings : ILibraryDatabaseSettings
    {
        public string ConnectionString { get; set; }
        
        public string DatabaseString { get; set; }
    }
}
