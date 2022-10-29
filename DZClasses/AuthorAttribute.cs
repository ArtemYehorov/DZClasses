using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    class AuthorAttribute : Attribute {}
}
