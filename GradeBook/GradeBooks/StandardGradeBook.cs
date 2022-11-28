using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
    public GradeBooKType Type { get; set; };
      public StandardGradeBook{
        Type = GradeBookType.Standard;     
}
      public StandardGradeBook(string name) : base(name)
        {
          
        }
    }
 }
