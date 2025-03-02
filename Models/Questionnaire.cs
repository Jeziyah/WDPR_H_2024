using System.Reflection;
namespace WPR
{
    public class Questionnaire : Research{
        public List<Question> Questions = new List<Question>();
        
        public Questionnaire(string title, string? description, string? location, string? reward, string status, Company company)
        {
            this.StartDate = DateTime.Now;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Reward = reward;
            this.Status = status;
            this.Company = company;
        }
        private void AddQuestion(string text){
            Question question = new Question(text, this);
            Questions.Add(question);
        }
    }
}
