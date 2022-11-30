using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
      public RankedGradeBook(BaseGradeBook Type){
        this.Type = GradeBookType.Ranked;     
        }
      public RankedGradeBook(string name) : base(name)
        {
          
        }
    }
 }
