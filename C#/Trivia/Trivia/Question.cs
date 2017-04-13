using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class Question
    {
       public string Description { get; private set; }

        public Question(string description)
        {
            Description = description;
        }
    }
}
