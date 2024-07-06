using Builder.Private;
using Builder.Public.Test;

namespace Builder.Public;

public class LiteratureExamBuilder: ExamBuilder
{
    public override ITest CreateTest()
    {
        var questions = GetQuestions();
        var information = GetInformationAboutQuestions();

        return new LiteratureTest(questions, information);
    }

    private IReadOnlyCollection<Question> GetQuestions()
    {
        var questions = new List<Question>();

        // read file

        return questions;
    }

    private IReadOnlyCollection<string> GetInformationAboutQuestions()
    {
        var information = new List<string>();

        // get post request from server

        return information;
    }
}