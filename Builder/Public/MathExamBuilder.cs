using Builder.Private;
using Builder.Public.Test;

namespace Builder.Public;

public class MathExamBuilder: ExamBuilder
{
    public override ITest CreateTest()
    {
        var questions = GetQuestions();

        return new MathTest(questions);
    }

    private IReadOnlyCollection<Question> GetQuestions()
    {
        var questions = new List<Question>();

        // read file

        return questions;
    }
}