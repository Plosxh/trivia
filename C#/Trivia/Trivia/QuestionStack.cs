using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class QuestionStack
    {
        private LinkedList<Question> Questions;

        public QuestionStack()
        {
            Questions = new LinkedList<Question>();
        }

        public void Add(string description)
        {
            Questions.AddLast(new Question(description));
        }

        public void Draw()
        {
            Console.WriteLine(Questions.First().Description);
            Questions.RemoveFirst();
        }
    }
}
