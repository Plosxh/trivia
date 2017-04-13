using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Questions
    {
        //private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };
        Dictionary<string, QuestionStack> DicoQuestion = new Dictionary<string, QuestionStack>();
        private QuestionStack popQuestions = new QuestionStack();
        private QuestionStack scienceQuestions = new QuestionStack();
        private QuestionStack sportsQuestions = new QuestionStack();
        private QuestionStack rockQuestions = new QuestionStack();


        public Questions()
        {
            for (var i = 0; i < 50; i++)
            {
                
                popQuestions.Add("Pop Question "  + i.ToString());
                scienceQuestions.Add(("Science Question " + i.ToString()));
                sportsQuestions.Add(("Sports Question " + i.ToString()));
                rockQuestions.Add(CreateRockQuestion(i));
            }
            DicoQuestion.Add("Pop", popQuestions);
            DicoQuestion.Add("Science", scienceQuestions);
            DicoQuestion.Add("Sports", sportsQuestions);
            DicoQuestion.Add("Rock", rockQuestions);
            
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public void AskQuestion(Players players)
        {
            DicoQuestion[CurrentCategory(players)].Draw();
        }

        public string CurrentCategory(Players players)
        {
            List<string> keyList = new List<string>(this.DicoQuestion.Keys);
            return keyList[players.Current.Place % 4];

            //return _categories[players.Current.Place % 4];
        }

        //end of class
    }
}
