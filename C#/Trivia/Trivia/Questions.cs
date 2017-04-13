using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Questions
    {
        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };
        private QuestionStack popQuestions = new QuestionStack();
        private QuestionStack scienceQuestions = new QuestionStack();
        private QuestionStack sportsQuestions = new QuestionStack();
        private QuestionStack rockQuestions = new QuestionStack();
        //LinkedList<string> popQuestions = new LinkedList<string>();
        //LinkedList<string> scienceQuestions = new LinkedList<string>();
        //LinkedList<string> sportsQuestions = new LinkedList<string>();
        //LinkedList<string> rockQuestions = new LinkedList<string>();

        //private List<Question> _questions = new List<Question>();

        public Questions()
        {
            for (var i = 0; i < 50; i++)
            {
                popQuestions.Add("Pop Question "  + i.ToString());
                scienceQuestions.Add(("Science Question " + i.ToString()));
                sportsQuestions.Add(("Sports Question " + i.ToString()));
                rockQuestions.Add(CreateRockQuestion(i));
            }
            
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public void AskQuestion(Players players)
        {
            if (CurrentCategory(players) == "Pop")
            {
                //Console.WriteLine(popQuestions.First());
                //popQuestions.RemoveFirst();
                popQuestions.Draw();
            }
            if (CurrentCategory(players) == "Science")
            {
                //Console.WriteLine(scienceQuestions.First());
                //scienceQuestions.RemoveFirst();
                scienceQuestions.Draw();
            }
            if (CurrentCategory(players) == "Sports")
            {
                //Console.WriteLine(sportsQuestions.First());
                //sportsQuestions.RemoveFirst();
                sportsQuestions.Draw();
            }
            if (CurrentCategory(players) == "Rock")
            {
                //Console.WriteLine(rockQuestions.First());
                //rockQuestions.RemoveFirst();
                rockQuestions.Draw();
            }
        }

        public string CurrentCategory(Players players)
        {
            return _categories[players.Current.Place % 4];
        }

        //end of class
    }
}
